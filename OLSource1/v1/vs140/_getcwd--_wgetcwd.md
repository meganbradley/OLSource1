---
title: "_getcwd, _wgetcwd"
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
  - "_wgetcwd"
  - "_getcwd"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getcwd"
  - "wgetcwd"
  - "_wgetcwd"
  - "tgetcwd"
  - "_tgetcwd"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "getcwd function"
  - "working directory"
  - "_wgetcwd function"
  - "_getcwd function"
  - "current working directory"
  - "wgetcwd function"
  - "directories [C++], current working"
ms.assetid: 888dc8c6-5595-4071-be55-816b38e3e739
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _getcwd, _wgetcwd
Gets the current working directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for the path.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Maximum length of the path in characters: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns a pointer to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> return value indicates an error, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set either to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, indicating that there is insufficient memory to allocate <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> bytes (when a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument is given as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>), or to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, indicating that the path is longer than <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> characters. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is less than or equal to zero, this function invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function gets the full path of the current working directory for the default drive and stores it at <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The integer argument <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> specifies the maximum length for the path. An error occurs if the length of the path (including the terminating null character) exceeds <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>*.* The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument can be <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; a buffer of at least size <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> (more only if necessary) is automatically allocated, using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, to store the path. This buffer can later be freed by calling <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and passing it the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> return value (a pointer to the allocated buffer).  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns a string that represents the path of the current working directory. If the current working directory is the root, the string ends with a backslash ( <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> ). If the current working directory is a directory other than the root, the string ends with the directory name and not with a backslash.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument and return value of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> behave identically otherwise.  
  
 When <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> are defined, calls to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> are replaced by calls to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to allow for debugging memory allocations. For more information, see [_getcwd_dbg, _wgetcwd_dbg](../vs140/_getcwd_dbg--_wgetcwd_dbg.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<direct.h>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<direct.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **C:\Code**   
## .NET Framework Equivalent  
 [System::Environment::CurrentDirectory](https://msdn.microsoft.com/en-us/library/system.environment.currentdirectory.aspx)  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)   
 [_chdir, _wchdir](../vs140/_chdir--_wchdir.md)   
 [_mkdir, _wmkdir](../vs140/_mkdir--_wmkdir.md)   
 [_rmdir, _wrmdir](../vs140/_rmdir--_wrmdir.md)