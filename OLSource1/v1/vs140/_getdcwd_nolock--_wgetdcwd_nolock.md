---
title: "_getdcwd_nolock, _wgetdcwd_nolock"
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
  - "_wgetdcwd_nolock"
  - "_getdcwd_nolock"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wgetdcwd_nolock"
  - "tgetdcwd_nolock"
  - "wgetdcwd_nolock"
  - "_getdcwd_nolock"
  - "_tgetdcwd_nolock"
  - "getdcwd_nolock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "getdcwd_nolock function"
  - "_tgetdcwd_nolock function"
  - "working directory"
  - "tgetdcwd_nolock function"
  - "_getdcwd_nolock function"
  - "current working directory"
  - "wgetdcwd_nolock function"
  - "_wgetdcwd_nolock function"
  - "directories [C++], current working"
ms.assetid: d9bdf712-43f8-4173-8f9a-844e82beaa97
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getdcwd_nolock, _wgetdcwd_nolock
Gets the full path of the current working directory on the specified drive.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Disk drive.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for the path.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Maximum length of path in characters: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 See [_getdcwd, _wgetdcwd, _getdcwd_nolock, _wgetdcwd_nolock](../vs140/_getdcwd--_wgetdcwd.md).  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are identical to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, respectively, except that they are not protected from interference by other threads. They might be faster because they do not incur the overhead of locking out other threads. Use these functions only in thread-safe contexts such as single-threaded applications or where the calling scope already handles thread isolation.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<direct.h>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<direct.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)   
 [_chdir, _wchdir](../vs140/_chdir--_wchdir.md)   
 [_getcwd, _wgetcwd](../vs140/_getcwd--_wgetcwd.md)   
 [_getdrive](../vs140/_getdrive.md)   
 [_mkdir, _wmkdir](../vs140/_mkdir--_wmkdir.md)   
 [_rmdir, _wrmdir](../vs140/_rmdir--_wrmdir.md)