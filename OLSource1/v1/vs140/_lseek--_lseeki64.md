---
title: "_lseek, _lseeki64"
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
  - "_lseeki64"
  - "_lseek"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_lseeki64"
  - "_lseek"
  - "lseeki64"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "lseek function"
  - "_lseek function"
  - "_lseeki64 function"
  - "lseeki64 function"
  - "file pointers [C++], moving"
  - "seek file pointers"
ms.assetid: aba8a768-d40e-48c3-b38e-473dbd782f93
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _lseek, _lseeki64
Moves a file pointer to the specified location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 File descriptor referring to an open file.  
  
 *offset*  
 Number of bytes from *origin*.  
  
 *origin*  
 Initial position.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the offset, in bytes, of the new position from the beginning of the file. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the offset in a 64-bit integer. The function returns –1L to indicate an error. If passed an invalid parameter, such as a bad file descriptor, or the value for *origin* is invalid or the position specified by *offset* is before the beginning of the file, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and return -1L. On devices incapable of seeking (such as terminals and printers), the return value is undefined.  
  
 For more information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function moves the file pointer associated with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to a new location that is *offset* bytes from *origin*. The next operation on the file occurs at the new location. The *origin* argument must be one of the following constants, which are defined in Stdio.h.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Beginning of the file.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Current position of the file pointer.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 End of file.  
  
 You can use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to reposition the pointer anywhere in a file or beyond the end of the file.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<io.h>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<io.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_lseek.c_input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [fseek, _fseeki64](../vs140/fseek--_fseeki64.md)   
 [_tell, _telli64](../vs140/_tell--_telli64.md)