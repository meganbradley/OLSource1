---
title: "rewind"
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
  - "rewind"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "rewind"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "rewind function"
  - "repositioning file pointers"
  - "file pointers [C++], repositioning"
  - "file pointers [C++]"
ms.assetid: 1a460ce1-28d8-4b5e-83a6-633dca29c28a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rewind
Repositions the file pointer to the beginning of a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to **FILE** structure.  
  
## Remarks  
 The **rewind** function repositions the file pointer associated with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to the beginning of the file. A call to **rewind** is similar to  
  
 **(void) fseek(** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>**, 0L,** <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **);**  
  
 However, unlike <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, **rewind** clears the error indicators for the stream as well as the end-of-file indicator. Also, unlike <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, **rewind** does not return a value to indicate whether the pointer was successfully moved.  
  
 To clear the keyboard buffer, use **rewind** with the stream <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which is associated with the keyboard by default.  
  
 If stream is a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**rewind**|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)