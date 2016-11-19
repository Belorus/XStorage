# XStorage

Do you need File/Directory code in PCL libs ? 

This library will help you. It is a synchronous wrapper around System.IO that allows you to write platform-agnostic PCL code 
that works with files and directories.

To use simply
* Reference XStorage in PCL projects where you need it
* Reference XStorage and XStorage.NET (or XStorage.WP8) in entrypoint project
* Somewhere in the main function in entrypoint project just write 

```C#
XStorage.XFileStorage.Initialize(new XStorage.NET.XStorage());
```
