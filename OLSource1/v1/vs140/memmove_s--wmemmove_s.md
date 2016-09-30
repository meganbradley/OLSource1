---
title: "memmove_s, wmemmove_s"
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
  - "wmemmove_s"
  - "memmove_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wmemmove_s"
  - "memmove_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wmemmove_s function"
  - "memmove_s function"
ms.assetid: a17619e4-1307-4bb0-98c6-77f8c68dab2d
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memmove_s, wmemmove_s
Moves one buffer to another. These are versions of [memmove, wmemmove](../vs140/memmove--wmemmove.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Destination object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of the destination buffer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Source object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Number of bytes (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) or characters (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) to copy.  
  
## Return Value  
 Zero if successful; an error code on failure  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|------------|------------------------|-----------|------------------|------------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|not modified|  
|any|any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|not modified|  
|any|< <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|not modified|  
  
## Remarks  
 Copies <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> bytes of characters from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>*.* If some regions of the source area and the destination overlap, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> ensures that the original source bytes in the overlapping region are copied before being overwritten.  
  
 If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a null pointer, or if the destination string is too small, these functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions return <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Buffer::BlockCopy](https://msdn.microsoft.com/en-us/library/system.buffer.blockcopy.aspx)  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [_memccpy](../vs140/_memccpy.md)   
 [memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md)   
 [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, \__mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)