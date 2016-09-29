---
title: "_chdrive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_chdrive"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "chdrive"
  - "_chdrive"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "drives, changing"
  - "_chdrive function"
  - "chdrive function"
ms.assetid: 212a1a4b-4fa8-444e-9677-7fca4c8c47e3
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _chdrive
Changes the current working drive.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
int _chdrive(   
   int drive   
);  
```  
  
#### Parameters  
 `drive`  
 An integer from 1 through 26 that specifies the current working drive (1=A, 2=B, and so forth).  
  
## Return Value  
 Zero (0) if the current working drive was changed successfully; otherwise, -1.  
  
## Remarks  
 If `drive` is not in the range from 1 through 26, the invalid-parameter handler is invoked as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, the **_chdrive** function returns -1, `errno` is set to `EACCES`, and `_doserrno` is set to `ERROR_INVALID_DRIVE`.  
  
 The **_chdrive** function is not thread-safe because it depends on the **SetCurrentDirectory** function, which is itself not thread-safe. To use **_chdrive** safely in a multi-threaded application, you must provide your own thread synchronization. For more information, go to [MSDN Library](http://go.microsoft.com/fwlink/?LinkID=150542) and then search for **SetCurrentDirectory**.  
  
 The **_chdrive** function changes only the current working drive;  **_chdir** changes the current working directory.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**_chdrive**|<direct.h>|  
  
 For more information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
 See the example for [_getdrive](../VS_csharp/_getdrive.md).  
  
## .NET Framework Equivalent  
 [System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)  
  
## See Also  
 [Directory Control](../VS_csharp/directory-control.md)   
 [_chdir, _wchdir](../VS_csharp/_chdir--_wchdir.md)   
 [_fullpath, _wfullpath](../VS_csharp/_fullpath--_wfullpath.md)   
 [_getcwd, _wgetcwd](../VS_csharp/_getcwd--_wgetcwd.md)   
 [_getdrive](../VS_csharp/_getdrive.md)   
 [_mkdir, _wmkdir](../VS_csharp/_mkdir--_wmkdir.md)   
 [_rmdir, _wrmdir](../VS_csharp/_rmdir--_wrmdir.md)   
 [system, _wsystem](../VS_csharp/system--_wsystem.md)