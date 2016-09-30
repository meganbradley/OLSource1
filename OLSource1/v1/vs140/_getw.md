---
title: "_getw"
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
  - "_getw"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_getw"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_getw function"
  - "integers, getting from streams"
  - "getw function"
ms.assetid: ef75facc-b84e-470f-9f5f-8746c90822a0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _getw
Gets an integer from a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the integer value read. A return value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> indicates either an error or end of file. However, because the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value is also a legitimate integer value, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to verify an end-of-file or error condition. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function reads the next binary value of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> from the file associated with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and increments the associated file pointer (if there is one) to point to the next unread character. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> does not assume any special alignment of items in the stream. Problems with porting can occur with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> because the size of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> type and the ordering of bytes within the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> type differ across systems.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<stdio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_getw.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_putw](../vs140/_putw.md)