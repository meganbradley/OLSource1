---
title: "clearerr"
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
  - "clearerr"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "clearerr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "error indicator for streams"
  - "resetting stream error indicator"
  - "clearerr function"
ms.assetid: a9711cd4-3335-43d4-a018-87bbac5b3bac
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# clearerr
Resets the error indicator for a stream. A more secure version of this function is available; see [clearerr_s](../vs140/clearerr_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function resets the error indicator and end-of-file indicator for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Error indicators are not automatically cleared; once the error indicator for a specified stream is set, operations on that stream continue to return an error value until <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is called.  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and returns. For more information on <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and error codes, see [errno Constants](../vs140/errno-constants.md).  
  
 A more secure version of this function is available; see [clearerr_s](../vs140/clearerr_s.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>Write error: No error**  
**Will input cause an error? n**  
**No read error**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Error Handling](../vs140/error-handling--crt-.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [_eof](../vs140/_eof.md)   
 [feof](../vs140/feof.md)   
 [ferror](../vs140/ferror.md)   
 [perror, _wperror](../vs140/perror--_wperror.md)