# nullDC-BEAR-mod

This is a fork that adds advanced connection options for certain VPNs
(ZeroTier) not supporting the broadcast address as well as a custom Buddy List.

It also cleans up the repository a little bit and adds static linking via
ILMerge. When properly built, it can act as a drop-in replacement to the
original executable file.

[Read the original README here.](https://github.com/RossenX/NullDC-BEAR)

## To build

Clone, run a NuGet restore, then build.

```bat
git clone https://github.com/wily-coyote/nullDC-BEAR-mod
cd nullDC-BEAR-mod
msbuild -t:Restore NullDC-BEAR.sln
msbuild -p:Platform=x64 -p:Configuration="Release" NullDC-BEAR.sln
```

You can then replace an existing installation of NullDC BEAR, or create a new
one by running the executable. If the statically linked version is being used,
these DLL files are not needed anymore and can be safely deleted.

- `Downloader.dll`
- `NAudio.dll`
- `SDL2-CS.dll`
- `SevenZipSharp.dll`
