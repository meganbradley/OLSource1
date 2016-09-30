---
title: "memchr, wmemchr"
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
  - "wmemchr"
  - "memchr"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "memchr"
  - "wmemchr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "memchr function"
  - "wmemchr function"
ms.assetid: 5a348581-28f1-4256-8434-687245f7fc9f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memchr, wmemchr
Find characters in a buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Character to look for.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of characters to check.  
  
## Return Value  
 If successful, returns a pointer to the first location of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Otherwise it returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> look for the first occurrence of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the first <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> bytes of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. It stops when it finds <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or when it has checked the first <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bytes.  
  
 In C, these functions take a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pointer for the first argument. In C++, two overloads are available. The overload taking a pointer to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> returns a pointer to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>; the version that takes a pointer to non-<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> returns a pointer to non-<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The macro _CONST_CORRECT_OVERLOADS is defined if both the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and non-<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> versions of these functions are available. If you require the non-<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> behavior for both C++ overloadsin C++, define the symbol _CONST_RETURN.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<memory.h> or \<string.h>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For more information about compatibility, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [_memccpy](../vs140/_memccpy.md)   
 [memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)   
 [memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md)   
 [memset, wmemset](../vs140/memset--wmemset.md)   
 [strchr, wcschr, _mbschr, _mbschr_l](../vs140/strchr--wcschr--_mbschr--_mbschr_l.md)