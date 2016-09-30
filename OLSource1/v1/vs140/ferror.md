---
title: "ferror"
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
  - "ferror"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ferror"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ferror function"
  - "streams, testing for errors"
  - "errors [C++], testing for stream"
ms.assetid: 528a34bc-f2aa-4c3f-b89a-5b148e6864f7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ferror
Tests for an error on a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 If no error has occurred on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns 0. Otherwise, it returns a nonzero value. If stream is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and returns 0.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> routine (implemented both as a function and as a macro) tests for a reading or writing error on the file associated with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If an error has occurred, the error indicator for the stream remains set until the stream is closed or rewound, or until <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is called against it.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [feof](../vs140/feof.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Error Handling](../vs140/error-handling--crt-.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [clearerr](../vs140/clearerr.md)   
 [_eof](../vs140/_eof.md)   
 [feof](../vs140/feof.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [perror, _wperror](../vs140/perror--_wperror.md)