---
title: "_swab"
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
  - "_swab"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_swab"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_swab function"
  - "swapping bytes"
  - "swab function"
  - "bytes, swapping"
ms.assetid: 017142f2-050c-4f6a-8b49-6b094f58ec94
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _swab
Swaps bytes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Data to be copied and swapped.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Storage location for swapped data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of bytes to be copied and swapped.  
  
## Remarks  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is even, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function copies <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, swaps each pair of adjacent bytes, and stores the result at <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is odd, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> copies and swaps the first <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> bytes of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is typically used to prepare binary data for transfer to a machine that uses a different byte order.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Before: BADCFEHGJILKNMPORQTSVUXWZY**  
 **..........................**  
**After:  BADCFEHGJILKNMPORQTSVUXWZY**  
 **ABCDEFGHIJKLMNOPQRSTUVWXYZ**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)