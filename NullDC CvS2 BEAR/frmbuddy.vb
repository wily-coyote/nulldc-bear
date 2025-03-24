Imports System.IO
Imports System.Media
Imports System.Text

Public Class frmBuddy
    Private Shared buddyListPath As String = MainformRef.NullDCPath & "\buddylist"
    Private Shared buddies As List(Of String())
    Private Sub PopulateListView()
        For Each buddy As String() In buddies
            Dim item = New ListViewItem({buddy(0), buddy(1)})
            buddyList.Items.Add(item)
        Next
    End Sub

    Public Shared Sub PokeBuddyList()
        If Not File.Exists(buddyListPath) Then
            Dim writer = File.CreateText(buddyListPath)
            writer.WriteLine("255.255.255.255|All")
            writer.Close()
        End If
    End Sub
    Public Shared Sub AddBuddy(ip As String, name As String)
        buddies.Add({ip, name})
        SaveBuddies()
    End Sub

    Public Shared Sub RenameBuddy(ip As String, newName As String)
        For I As Integer = 0 To buddies.Count - 1
            Dim buddy = buddies(I)
            If buddy(0).Equals(ip) Then
                buddies(I)(1) = newName
            End If
        Next
        SaveBuddies()
    End Sub

    Public Shared Function CheckBuddy(ip As String)
        For Each buddy As String() In buddies
            If buddy(0).Equals(ip) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Sub RemoveBuddy(ip As String)
        For Each buddy As String() In buddies
            If buddy(0).Equals(ip) Then
                buddies.Remove(buddy)
        	SaveBuddies()
                Exit Sub
            End If
        Next
    End Sub

    Public Shared Sub LoadBuddies()
        Dim lines = File.ReadLines(buddyListPath)
        buddies = New List(Of String())
        For Each line As String In lines
            Dim fields = line.Split("|")
            Dim fieldCount = fields.Length
            If fieldCount >= 2 Then
                Dim buddy As String() = {fields(0), fields(1)}
                buddies.Add(buddy)
            End If
        Next
    End Sub

    Public Shared Sub SaveBuddies()
        Dim writer = New FileStream(buddyListPath, FileMode.Truncate, FileAccess.Write)
	For Each buddy As String() In buddies
	    Dim data As Byte() = New UTF8Encoding(False).GetBytes(buddy(0) & "|"c & buddy(1) & vbNewLine)
	    writer.Write(data, 0, data.Length)
	Next
        writer.Close()
    End Sub

    Private Sub ReloadTheme()
        ApplyThemeToControl(tableLayout)
        ApplyThemeToControl(buddyList)
        ApplyThemeToControl(menuStrip)
    End Sub

    Private Sub frmBuddy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.fan_icon_text
	Me.CenterToParent()
        ReloadTheme()
        RefreshBuddyList()
    End Sub

    Private Sub buddyList_MouseClick(sender As Object, e As MouseEventArgs) Handles buddyList.MouseClick
        If e.Button.Equals(MouseButtons.Right) Then
            If buddyList.FocusedItem IsNot Nothing And buddyList.FocusedItem.Bounds.Contains(e.Location) Then
                buddyActions.Show(Me.Location + e.Location)
            End If
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveBuddy(buddyList.FocusedItem.SubItems(0).Text)
        RefreshBuddyList()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        Dim newName = Interaction.InputBox("Enter new name", "Rename Buddy", buddyList.FocusedItem.SubItems(1).Text)
        If newName IsNot "" Then
            RenameBuddy(buddyList.FocusedItem.SubItems(0).Text, newName)
        Else
            SystemSounds.Asterisk.Play()
        End If
        RefreshBuddyList()
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        MainformRef.tbSendTo.Text = buddyList.FocusedItem.SubItems(0).Text
        MainformRef.Focus()
        SystemSounds.Asterisk.Play()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim ip = Interaction.InputBox("Enter buddy's IP", "Add Buddy")
            Dim name = Interaction.InputBox("Enter buddy's nickname", "Add Buddy")
        If name Is "" Then
            name = "Your New Buddy"
        End If
        If ip Is "" Then
            MainformRef.NotificationForm.ShowMessage("You didn't specify the IP address.")
            Exit Sub
        End If
        AddBuddy(ip, name)
        RefreshBuddyList()
    End Sub

    Public Sub RefreshBuddyList()
        buddyList.Items.Clear()
        PopulateListView()
    End Sub

    Private Sub frmBuddy_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Application.OpenForms(0).Activate()
    End Sub
End Class
