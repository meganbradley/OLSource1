---
title: "_umask"
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
  - "_umask"
apilocation: 
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_umask"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "masks, file-permission-setting"
  - "_umask function"
  - "masks"
  - "umask function"
  - "file permissions [C++]"
  - "files [C++], permission settings for"
ms.assetid: 5e9a13ba-5321-4536-8721-6afb6f4c8483
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _umask
Sets the default file-permission mask. A more secure version of this function is available; see [_umask_s](../vs140/_umask_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Default permission setting.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the previous value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function sets the file-permission mask of the current process to the mode specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>*.* The file-permission mask modifies the permission setting of new files created by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If a bit in the mask is 1, the corresponding bit in the file's requested permission value is set to 0 (disallowed). If a bit in the mask is 0, the corresponding bit is left unchanged. The permission setting for a new file is not set until the file is closed for the first time.  
  
 The integer expression <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> contains one or both of the following manifest constants, defined in SYS\STAT.H:  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Writing permitted.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Reading permitted.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Reading and writing permitted.  
  
 When both constants are given, they are joined with the bitwise-OR operator ( <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> ). If the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, reading is not allowed (the file is write-only). If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, writing is not allowed (the file is read-only). For example, if the write bit is set in the mask, any new files will be read-only. Note that with MS-DOS and the Windows operating systems, all files are readable; it is not possible to give write-only permission. Therefore, setting the read bit with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> has no effect on the file's modes.  
  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is not a combination of one of the manifest constants or incorporates an alternate set of constants, the function will simply ignore those.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<io.h>, \<sys/stat.h>, \<sys/types.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
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