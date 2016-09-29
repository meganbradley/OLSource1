---
title: "File Handling"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.files"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "files [C++], handling"
  - "files [C++], opening"
  - "files [C++], manipulating"
ms.assetid: 48119e2e-e94f-4602-b08b-b72440f731d8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File Handling
Use these routines to create, delete, and manipulate files and to set and check file-access permissions.  
  
 The C run-time libraries have a 512 limit for the number of files that can be open at any one time. Attempting to open more than the maximum number of file descriptors or file streams causes program failure. Use [_setmaxstdio](../VS_csharp/_setmaxstdio.md) to change this number.  
  
 The following routines operate on files designated by a file descriptor.  
  
### File-Handling Routines (File Descriptor)  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_chsize](../VS_csharp/_chsize.md),[_chsize_s](../VS_csharp/_chsize_s.md)|Change file size|[System::IO::Stream::SetLength](https://msdn.microsoft.com/en-us/library/system.io.stream.setlength.aspx), [System::IO::FileStream::SetLength](https://msdn.microsoft.com/en-us/library/system.io.filestream.setlength.aspx)|  
|[_filelength, _filelengthi64](../VS_csharp/_filelength--_filelengthi64.md)|Get file length|[System::IO::Stream::Length](https://msdn.microsoft.com/en-us/library/system.io.stream.length.aspx), [System::IO::FileStream::Length](https://msdn.microsoft.com/en-us/library/system.io.filestream.length.aspx)|  
|[_fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32](../VS_csharp/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md)|Get file-status information on descriptor|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_get_osfhandle](../VS_csharp/_get_osfhandle.md)|Return operating-system file handle associated with existing C run-time file descriptor|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_isatty](../VS_csharp/_isatty.md)|Check for character device|[System::IO::Stream::CanWrite](https://msdn.microsoft.com/en-us/library/system.io.filestream.canwrite.aspx), [System::IO::FileStream::CanWrite](https://msdn.microsoft.com/en-us/library/system.io.stream.canwrite.aspx)|  
|[_locking](../VS_csharp/_locking.md)|Lock areas of file|[System::IO::FileStream::Lock](https://msdn.microsoft.com/en-us/library/system.io.filestream.lock.aspx)|  
|[_open_osfhandle](../VS_csharp/_open_osfhandle.md)|Associate C run-time file descriptor with existing operating-system file handle|[System::IO::FileStream::Handle](https://msdn.microsoft.com/en-us/library/system.io.filestream.handle.aspx)|  
|[_setmode](../VS_csharp/_setmode.md)|Set file-translation mode|[System::IO::BinaryReader Class](https://msdn.microsoft.com/en-us/library/system.io.binaryreader.aspx), [System::IO::TextReader Class](https://msdn.microsoft.com/en-us/library/system.io.textreader.aspx)|  
  
 The following routines operate on files specified by a path or filename.  
  
### File-Handling Routines (Path or Filename)  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_access, _waccess](../VS_csharp/_access--_waccess.md), [_access_s, _waccess_s](../VS_csharp/_access_s--_waccess_s.md)|Check file-permission setting|[System::IO::FileAccess Enumeration](https://msdn.microsoft.com/en-us/library/4z36sx0f.aspx)|  
|[_chmod, _wchmod](../VS_csharp/_chmod--_wchmod.md)|Change file-permission setting|[System::IO::File::SetAttributes](https://msdn.microsoft.com/en-us/library/system.io.file.setattributes.aspx), [System::Security::Permissions::FileIOPermission](https://msdn.microsoft.com/en-us/library/system.security.permissions.fileiopermission.aspx)|  
|[_fullpath, _wfullpath](../VS_csharp/_fullpath--_wfullpath.md)|Expand a relative path to its absolute path name|[System::IO::File::Create](https://msdn.microsoft.com/en-us/library/system.io.file.create.aspx)|  
|[_makepath, _wmakepath](../VS_csharp/_makepath--_wmakepath.md), [_makepath_s, _wmakepath_s](../VS_csharp/_makepath_s--_wmakepath_s.md)|Merge path components into single, full path|[System::IO::File::Create](https://msdn.microsoft.com/en-us/library/system.io.file.create.aspx)|  
|[_mktemp, _wmktemp](../VS_csharp/_mktemp--_wmktemp.md), [_mktemp_s, _wmktemp_s](../VS_csharp/_mktemp_s--_wmktemp_s.md)|Create unique filename|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[remove, _wremove](../VS_csharp/remove--_wremove.md)|Delete file|[System::IO::File::Delete](https://msdn.microsoft.com/en-us/library/system.io.file.delete.aspx)|  
|[rename, _wrename](../VS_csharp/rename--_wrename.md)|Rename file|[System::IO::File::Move](https://msdn.microsoft.com/en-us/library/system.io.file.move.aspx)|  
|[_splitpath, _wsplitpath](../VS_csharp/_splitpath--_wsplitpath.md), [_splitpath_s, _wsplitpath_s](../VS_csharp/_splitpath_s--_wsplitpath_s.md)|Parse path into components|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_stat, _stat64, _stati64, _wstat, _wstat64, _wstati64](../VS_csharp/_stat--_stat32--_stat64--_stati64--_stat32i64--_stat64i32--_wstat--_wstat32--_wstat64--_wstati64--_wstat32i64--_wstat64i32.md)|Get file-status information on named file|[System::IO::File::GetAttributes](https://msdn.microsoft.com/en-us/library/system.io.file.getattributes.aspx), [System::IO::File::GetCreationTime](https://msdn.microsoft.com/en-us/library/system.io.file.getcreationtime.aspx), [System::IO::File::GetLastAccessTime](https://msdn.microsoft.com/en-us/library/system.io.file.getlastaccesstime.aspx), [System::IO::File::GetLastWriteTime](https://msdn.microsoft.com/en-us/library/system.io.file.getlastwritetime.aspx)|  
|[_umask](../VS_csharp/_umask.md), [_umask_s](../VS_csharp/_umask_s.md)|Set default permission mask for new files created by program|[System::IO::File::SetAttributes](https://msdn.microsoft.com/en-us/library/system.io.file.setattributes.aspx)|  
|[_unlink, _wunlink](../VS_csharp/_unlink--_wunlink.md)|Delete file|[System::IO::File::Delete](https://msdn.microsoft.com/en-us/library/system.io.file.delete.aspx)|  
  
 The following routines open files.  
  
### File-Handling Routines (Open File)  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[fopen, _wfopen](../VS_csharp/fopen--_wfopen.md), [fopen_s, _wfopen_s](../VS_csharp/fopen_s--_wfopen_s.md)|Opens a file and returns a pointer to the open file.|[System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx), <xref:System.IO.FileStream.#ctor*>|  
|[_fsopen, _wfsopen](../VS_csharp/_fsopen--_wfsopen.md)|Open a stream with file sharing and returns a pointer to the open file.|[System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx), <xref:System.IO.FileStream.#ctor*>|  
|[_open, _wopen](../VS_csharp/_open--_wopen.md)|Opens a file and returns a file descriptor to the opened file.|[System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx), <xref:System.IO.FileStream.#ctor*>|  
|[_sopen, _wsopen](../VS_csharp/_sopen--_wsopen.md), [_sopen_s, _wsopen_s](../VS_csharp/_sopen_s--_wsopen_s.md)|Open a file with file sharing and returns a file descriptor to the open file.||  
|[_pipe](../VS_csharp/_pipe.md)|Creates a pipe for reading and writing.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[freopen, _wfreopen](../VS_csharp/freopen--_wfreopen.md), [freopen_s, _wfreopen_s](../VS_csharp/freopen_s--_wfreopen_s.md)|Reassign a file pointer.|[System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.file.open.aspx), <xref:System.IO.FileStream.#ctor*>|  
  
 The following functions provide a way to change the representation of the file between a `FILE` structure, a file descriptor, and a Win32 file handle.  
  
||||  
|-|-|-|  
|[_fdopen, _wfdopen](../VS_csharp/_fdopen--_wfdopen.md)|Associates a stream with a file that was previously opened for low-level I/O and returns a pointer to the open stream.|[System::IO::File::Open](https://msdn.microsoft.com/en-us/library/system.io.filestream.aspx)|  
|[_fileno](../VS_csharp/_fileno.md)|Gets the file descriptor associated with a stream.|[System::IO::FileStream::Handle](https://msdn.microsoft.com/en-us/library/system.io.filestream.handle.aspx)|  
|[_get_osfhandle](../VS_csharp/_get_osfhandle.md)|Return operating-system file handle associated with existing C run-time file descriptor|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_open_osfhandle](../VS_csharp/_open_osfhandle.md)|Associates C run-time file descriptor with an existing operating-system file handle.|[System::IO::FileStream::Handle](https://msdn.microsoft.com/en-us/library/system.io.filestream.handle.aspx)|  
  
 The following Win32 functions also open files and pipes:  
  
-   [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858.aspx)  
  
-   [CreatePipe](http://msdn.microsoft.com/library/windows/desktop/aa365152.aspx)  
  
-   [CreateNamedPipe](http://msdn.microsoft.com/library/windows/desktop/aa365150.aspx)  
  
## See Also  
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)   
 [Directory Control](../VS_csharp/directory-control.md)   
 [System Calls](../VS_csharp/system-calls.md)