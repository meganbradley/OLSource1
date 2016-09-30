---
title: "_chmod, _wchmod"
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
  - "_chmod"
  - "_wchmod"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_chmod"
  - "_wchmod"
  - "wchmod"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_chmod function"
  - "wchmod function"
  - "file permissions [C++]"
  - "chmod function"
  - "files [C++], changing permissions"
  - "_wchmod function"
ms.assetid: 92f7cb86-b3b0-4232-a599-b8c04a2f2c19
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _chmod, _wchmod
Changes the file-permission settings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Name of the existing file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Permission setting for the file.  
  
## Return Value  
 These functions return 0 if the permission setting is successfully changed. A return value of –1 indicates failure. If the specified file could not be found, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; if a parameter is invalid, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function changes the permission setting of the file specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>*.* The permission setting controls the read and write access to the file. The integer expression <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> contains one or both of the following manifest constants, defined in SYS\Stat.h.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Writing permitted.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Reading permitted.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Reading and writing permitted.  
  
 When both constants are given, they are joined with the bitwise <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operator ( <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> ). If write permission is not given, the file is read-only. Note that all files are always readable; it is not possible to give write-only permission. Thus, the modes <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are equivalent.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> behave identically otherwise.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not a combination of one of the manifest constants or incorporates an alternate set of constants, the function simply ignores those. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and the function returns -1.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<io.h>|\<sys/types.h>, \<sys/stat.h>, \<errno.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|\<sys/types.h>, \<sys/stat.h>, \<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>Mode set to read-only**  
**Access is denied.**  
**Mode set to read/write**   
## .NET Framework Equivalent  
  
-   [System::IO::File::SetAttributes](https://msdn.microsoft.com/en-us/library/system.io.file.setattributes.aspx)  
  
-   [System::Security::Permissions::FileIOPermission](https://msdn.microsoft.com/en-us/library/system.security.permissions.fileiopermission.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_access, _waccess](../vs140/_access--_waccess.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_stat, _wstat Functions](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md)