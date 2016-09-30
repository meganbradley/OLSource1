---
title: "_umask_s"
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
  - "_umask_s"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "unmask_s"
  - "_umask_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "masks, file-permission-setting"
  - "_umask_s function"
  - "masks"
  - "file permissions [C++]"
  - "umask_s function"
  - "files [C++], permission settings for"
ms.assetid: 70898f61-bf2b-4d8d-8291-0ccaa6d33145
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _umask_s
Sets the default file-permission mask. A version of [_umask](../vs140/_umask.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Default permission setting.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The previous value of the permission setting.  
  
## Return Value  
 Returns an error code if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not specify a valid mode or the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|**Return Value**|**Contents of**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|------------|----------------|----------------------|--------------------------------|  
|any|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|not modified|  
|invalid mode|any|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|not modified|  
  
 If one of the above conditions occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function sets the file-permission mask of the current process to the mode specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>*.* The file-permission mask modifies the permission setting of new files created by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If a bit in the mask is 1, the corresponding bit in the file's requested permission value is set to 0 (disallowed). If a bit in the mask is 0, the corresponding bit is left unchanged. The permission setting for a new file is not set until the file is closed for the first time.  
  
 The integer expression <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> contains one or both of the following manifest constants, defined in SYS\STAT.H:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Writing permitted.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Reading permitted.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Reading and writing permitted.  
  
 When both constants are given, they are joined with the bitwise-OR operator ( <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> ). If the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, reading is not allowed (the file is write-only). If the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, writing is not allowed (the file is read-only). For example, if the write bit is set in the mask, any new files will be read-only. Note that with MS-DOS and the Windows operating systems, all files are readable; it is not possible to give write-only permission. Therefore, setting the read bit with <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> has no effect on the file's modes.  
  
 If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is not a combination of one of the manifest constants or incorporates an alternate set of constants, the function will simply ignore those.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<io.h> and \<sys/stat.h> and \<sys/types.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Oldmask = 0x0000**   
## .NET Framework Equivalent  
 [System::IO::File::SetAttributes](https://msdn.microsoft.com/en-us/library/system.io.file.setattributes.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_chmod, _wchmod](../vs140/_chmod--_wchmod.md)   
 [_creat, _wcreat](../vs140/_creat--_wcreat.md)   
 [_mkdir, _wmkdir](../vs140/_mkdir--_wmkdir.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_umask](../vs140/_umask.md)