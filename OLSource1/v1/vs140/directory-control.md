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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Directory Control
These routines access, modify, and obtain information about the directory structure.  
  
### Directory-Control Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_chdir, _wchdir](../vs140/_chdir--_wchdir.md)|Change current working directory|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_chdrive](../vs140/_chdrive.md)|Change current drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getcwd, _wgetcwd](../vs140/_getcwd--_wgetcwd.md)|Get current working directory for default drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getdcwd, _wgetdcwd](../vs140/_getdcwd--_wgetdcwd.md)|Get current working directory for specified drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getdiskfree](../vs140/_getdiskfree.md)|Populates a `_diskfree_t` structure with information about a disk drive.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_getdrive](../vs140/_getdrive.md)|Get current (default) drive|[System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)|  
|[_getdrives](../vs140/_getdrives.md)|Returns a bitmask representing the currently available disk drives.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_mkdir, _wmkdir](../vs140/_mkdir--_wmkdir.md)|Make new directory|[System::IO::Directory::CreateDirectory](https://msdn.microsoft.com/en-us/library/system.io.directory.createdirectory.aspx), [System::IO::DirectoryInfo::CreateSubdirectory](https://msdn.microsoft.com/en-us/library/system.io.directoryinfo.createsubdirectory.aspx)|  
|[_rmdir, _wrmdir](../vs140/_rmdir--_wrmdir.md)|Remove directory|[System::IO::Directory::Delete](https://msdn.microsoft.com/en-us/library/system.io.directory.delete.aspx)|  
|[_searchenv, _wsearchenv](../vs140/_searchenv--_wsearchenv.md), [_searchenv_s, _wsearchenv_s](../vs140/_searchenv_s--_wsearchenv_s.md)|Search for given file on specified paths|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)   
 [File Handling](../vs140/file-handling.md)   
 [System Calls](../vs140/system-calls.md)