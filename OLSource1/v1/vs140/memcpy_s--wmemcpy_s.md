---
title: "memcpy_s, wmemcpy_s"
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
  - "memcpy_s"
  - "wmemcpy_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wmemcpy_s"
  - "memcpy_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memcpy_s function"
  - "wmemcpy_s function"
ms.assetid: 5504e20a-83d9-4063-91fc-3f55f7dabe99
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# memcpy_s, wmemcpy_s
Copies bytes between buffers. These are versions of [memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 New buffer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Size of the destination buffer, in bytes for memcpy_s and wide characters (wchar_t) for wmemcpy_s.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Buffer to copy from.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of characters to copy.  
  
## Return Value  
 Zero if successful; an error code on failure.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|------------|----------------|-----------|------------------|------------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|not modified|  
|any|any|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is zeroed out|  
|any|< <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is zeroed out|  
  
## Remarks  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> copies <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> copies <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> wide characters (two bytes). If the source and destination overlap, the behavior of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is undefined. Use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to handle overlapping regions.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a null pointer, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is smaller than <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<memory.h> or \<string.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0 1 4 9 16 25 36 49 64 81**    
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [_memccpy](../vs140/_memccpy.md)   
 [memchr, wmemchr](../vs140/memchr--wmemchr.md)   
 [memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)   
 [memmove, wmemmove](../vs140/memmove--wmemmove.md)   
 [memset, wmemset](../vs140/memset--wmemset.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, \__mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)