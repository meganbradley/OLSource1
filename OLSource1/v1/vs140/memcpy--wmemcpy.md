---
title: "memcpy, wmemcpy"
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
  - "memcpy"
  - "wmemcpy"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wmemcpy"
  - "memcpy"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wmemcpy function"
  - "memcpy function"
ms.assetid: 34abb90b-bffb-46dc-a2f3-a5e9940839d6
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memcpy, wmemcpy
Copies bytes between buffers. More secure versions of these functions are available; see [memcpy_s, wmemcpy_s](../vs140/memcpy_s--wmemcpy_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 New buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Buffer to copy from.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of characters to copy.  
  
## Return Value  
 The value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> copies <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> copies <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> wide characters (two bytes). If the source and destination overlap, the behavior of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is undefined. Use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to handle overlapping regions.  
  
> [!IMPORTANT]
>  Make sure that the destination buffer is the same size or larger than the source buffer. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
> [!IMPORTANT]
>  Because so many buffer overruns, and thus potential security exploits, have been traced to improper usage of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, this function is listed among the “banned” functions by the Security Development Lifecycle (SDL).  You may observe that some VC++ library classes continue to use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  Furthermore, you may observe that the VC++ compiler optimizer sometimes emits calls to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  The Visual C++ product is developed in accordance with the SDL process, and thus usage of this banned function has been closely evaluated.  In the case of library use of it, the calls have been carefully scrutinized to ensure that buffer overruns will not be allowed through these calls.  In the case of the compiler, sometimes certain code patterns are recognized as identical to the pattern of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and are thus replaced with a call to the function.  In such cases, the use of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is no more unsafe than the original instructions would have been; they have simply been optimized to a call to the performance-tuned <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function.  Just as the use of “safe” CRT functions doesn’t guarantee safety (they just make it harder to be unsafe), the use of “banned” functions doesn’t guarantee danger (they just require greater scrutiny to ensure safety).  
>   
>  Because <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> usage by the VC++ compiler and libraries has been so carefully scrutinized, these calls are permitted within code that is otherwise compliant with SDL.  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> calls introduced in application source code are only compliant with the SDL when that use has been reviewed by security experts.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> functions will only be deprecated if the constant <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is defined prior to the inclusion statement in order for the functions to be deprecated, such as in the example below:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 or  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<memory.h> or \<string.h>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See [memmove](../vs140/memmove--wmemmove.md) for a sample of how to use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [_memccpy](../vs140/_memccpy.md)   
 [memchr, wmemchr](../vs140/memchr--wmemchr.md)   
 [memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)   
 [memmove, wmemmove](../vs140/memmove--wmemmove.md)   
 [memset, wmemset](../vs140/memset--wmemset.md)   
 [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)