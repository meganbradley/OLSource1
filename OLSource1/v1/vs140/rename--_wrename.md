---
title: "rename, _wrename"
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
  - "rename"
  - "_wrename"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wrename"
  - "_trename"
  - "Rename"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "trename function"
  - "directories [C++], renaming"
  - "renaming directories"
  - "names [C++], changing file"
  - "_trename function"
  - "rename function"
  - "wrename function"
  - "files [C++], renaming"
  - "_wrename function"
  - "names [C++], changing directory"
  - "renaming files"
ms.assetid: 9f0a6103-26a2-4dda-b14b-79a48946266a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rename, _wrename
Rename a file or directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *oldname*  
 Pointer to old name.  
  
 *newname*  
 Pointer to new name.  
  
## Return Value  
 Each of these functions returns 0 if it is successful. On an error, the function returns a nonzero value and sets <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to one of the following values:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 File or directory specified by *newname* already exists or could not be created (invalid path); or *oldname* is a directory and *newname* specifies a different path.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 File or path specified by *oldname* not found.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Name contains invalid characters.  
  
 For other possible return values, see [_doserrno, _errno, syserrlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The **rename** function renames the file or directory specified by *oldname* to the name given by *newname*. The old name must be the path of an existing file or directory. The new name must not be the name of an existing file or directory. You can use **rename** to move a file from one directory or device to another by giving a different path in the *newname* argument. However, you cannot use **rename** to move a directory. Directories can be renamed, but not moved.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a wide-character version of **_rename**; the arguments to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and **_rename** behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**rename**|**rename**|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**rename**|\<io.h> or \<stdio.h>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::IO::File::Move](https://msdn.microsoft.com/en-us/library/system.io.file.move.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)