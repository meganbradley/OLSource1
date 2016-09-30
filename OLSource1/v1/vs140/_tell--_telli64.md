---
title: "_tell, _telli64"
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
  - "_telli64"
  - "_tell"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "tell"
  - "telli64"
  - "_telli64"
  - "_tell"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tell function"
  - "file pointers [C++], getting"
  - "_tell function"
  - "file pointers [C++]"
  - "telli64 function"
  - "_telli64 function"
ms.assetid: 1500e8f9-8fec-4253-9eec-ec66125dfc9b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _tell, _telli64
Get the position of the file pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 File descriptor referring to open file.  
  
## Return Value  
 The current position of the file pointer. On devices incapable of seeking, the return value is undefined.  
  
 A return value of –1L indicates an error. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is an invalid file descriptor, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and return -1L.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on this, and other, return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function gets the current position of the file pointer (if any) associated with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument. The position is expressed as the number of bytes from the beginning of the file. For the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function, this value is expressed as a 64-bit integer.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<io.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_tell.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [ftell, _ftelli64](../vs140/ftell--_ftelli64.md)   
 [_lseek, _lseeki64](../vs140/_lseek--_lseeki64.md)