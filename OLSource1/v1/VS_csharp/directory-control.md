---
title: "Directory Control"
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
  - "c.programs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "controls [C++], directory"
  - "directory control routines"
ms.assetid: a72dcf6f-f366-4d20-8850-0e19cc53ca18
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Directory Control
These routines access, modify, and obtain information about the directory structure.  
  
### Directory-Control Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_chdir, _wchdir](../VS_csharp/_chdir--_wchdir.md)|Change current working directory|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_chdrive](../VS_csharp/_chdrive.md)|Change current drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getcwd, _wgetcwd](../VS_csharp/_getcwd--_wgetcwd.md)|Get current working directory for default drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getdcwd, _wgetdcwd](../VS_csharp/_getdcwd--_wgetdcwd.md)|Get current working directory for specified drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getdiskfree](../VS_csharp/_getdiskfree.md)|Populates a `_diskfree_t` structure with information about a disk drive.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_getdrive](../VS_csharp/_getdrive.md)|Get current (default) drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getdrives](../VS_csharp/_getdrives.md)|Returns a bitmask representing the currently available disk drives.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_mkdir, _wmkdir](../VS_csharp/_mkdir--_wmkdir.md)|Make new directory|[System::IO::Directory::CreateDirectory](https://msdn.microsoft.com/en-us/library/system.io.directory.createdirectory.aspx), [System::IO::DirectoryInfo::CreateSubdirectory](https://msdn.microsoft.com/en-us/library/system.io.directoryinfo.createsubdirectory.aspx)|  
|[_rmdir, _wrmdir](../VS_csharp/_rmdir--_wrmdir.md)|Remove directory|[System::IO::Directory::Delete](https://msdn.microsoft.com/en-us/library/system.io.directory.delete.aspx)|  
|[_searchenv, _wsearchenv](../VS_csharp/_searchenv--_wsearchenv.md), [_searchenv_s, _wsearchenv_s](../VS_csharp/_searchenv_s--_wsearchenv_s.md)|Search for given file on specified paths|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
## See Also  
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)   
 [File Handling](../VS_csharp/file-handling.md)   
 [System Calls](../VS_csharp/system-calls.md)