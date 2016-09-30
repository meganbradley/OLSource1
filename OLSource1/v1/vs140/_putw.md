---
title: "_putw"
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
  - "_putw"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_putw"
  - "putw"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "integers, writing to streams"
  - "putw function"
  - "streams, writing integers to"
  - "_putw function"
ms.assetid: 83d63644-249d-4a39-87e5-3b7aa313968d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _putw
Writes an integer to a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *binint*  
 Binary integer to be output.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the **FILE** structure.  
  
## Return Value  
 Returns the value written. A return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> might indicate an error. Because <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is also a legitimate integer value, use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to verify an error. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function writes a binary value of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to the current position of *stream.* <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> does not affect the alignment of items in the stream nor does it assume any special alignment. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is primarily for compatibility with previous libraries. Portability problems might occur with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> because the size of an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the ordering of bytes within an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> differ across systems.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_getw](../vs140/_getw.md)