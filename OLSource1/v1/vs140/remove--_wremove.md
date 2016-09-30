---
title: "remove, _wremove"
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
  - "_wremove"
  - "remove"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "remove"
  - "_wremove"
  - "_tremove"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tremove function"
  - "_wremove function"
  - "files [C++], deleting"
  - "_tremove function"
  - "files [C++], removing"
  - "wremove function"
  - "remove function"
ms.assetid: b6345ec3-3289-4645-93a4-28b9e478cc19
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# remove, _wremove
Delete a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *path*  
 Path of file to be removed.  
  
## Return Value  
 Each of these functions returns 0 if the file is successfully deleted. Otherwise, it returns -1 and sets <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> either to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to indicate that the path specifies a read-only file or the file is open, or to **ENOENT** to indicate that the filename or path was not found or that the path specifies a directory.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these and other return codes.  
  
## Remarks  
 The **remove** function deletes the file specified by *path.* <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a wide-character version of **_remove**; the *path* argument to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and **_remove** behave identically otherwise. All handles to a file must be closed before it can be deleted.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|**remove**|**remove**|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**remove**|\<stdio.h> or \<io.h>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_remove.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::IO::File::Delete](https://msdn.microsoft.com/en-us/library/system.io.file.delete.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_unlink, _wunlink](../vs140/_unlink--_wunlink.md)