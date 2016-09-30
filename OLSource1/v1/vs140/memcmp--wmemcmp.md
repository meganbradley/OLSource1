---
title: "memcmp, wmemcmp"
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
  - "memcmp"
  - "wmemcmp"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "memcmp"
  - "wmemcmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wmemcmp function"
  - "memcmp function"
ms.assetid: 0c21c3e3-8ee4-40e5-add1-eb26d225fd8d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memcmp, wmemcmp
Compares characters in two buffers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 First buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Second buffer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of characters to compare. (Compares bytes for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, wide characters for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Return Value  
 The return value indicates the relationship between the buffers.  
  
|Return value|Relationship of first <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> characters of buf1 and buf2|  
|------------------|---------------------------------------------------------------|  
|< 0|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> less than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|0|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> identical to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|> 0|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> greater than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
  
## Remarks  
 Compares the first <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and returns a value that indicates their relationship. The sign of a non-zero return value is the sign of the difference between the first differing pair of values in the buffers. The values are interpreted as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<memory.h> or \<string.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time library](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [_memccpy](../vs140/_memccpy.md)   
 [memchr, wmemchr](../vs140/memchr--wmemchr.md)   
 [memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md)   
 [memset, wmemset](../vs140/memset--wmemset.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)