---
title: "isgraph, iswgraph, _isgraph_l, _iswgraph_l"
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
  - "isgraph"
  - "iswgraph"
  - "_iswgraph_l"
  - "_isgraph_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_isgraph_l"
  - "_iswgraph_l"
  - "_ismbcgraph_l"
  - "Isgraph"
  - "_istgraph_l"
  - "_istgraph"
  - "iswgraph"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "isgraph function"
  - "_istgraph_l function"
  - "istgraph function"
  - "_isgraph_l function"
  - "iswgraph function"
  - "_iswgraph_l function"
  - "_istgraph function"
  - "_ismbcgraph_l function"
ms.assetid: 531a5f34-4302-4d0a-8a4f-b7ea150ad941
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isgraph, iswgraph, _isgraph_l, _iswgraph_l
Determines whether an integer represents a graphical character.  
  
## Syntax  
  
```  
int isgraph(  
   int c   
);  
int iswgraph(  
   wint_t c   
);  
int _isgraph_l(  
   int c,  
   _locale_t locale  
);  
int _iswgraph_l(  
   wint_t c,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `c`  
 Integer to test.  
  
## Return Value  
 Each of these routines returns nonzero if `c` is a particular representation of a printable character other than a space. `isgraph` returns a nonzero value if `c` is a printable character other than a space. `iswgraph` returns a nonzero value if `c` is a printable wide character other than a wide character space. Each of these routines returns 0 if `c` does not satisfy the test condition.  
  
 The versions of these functions that have the `_l` suffix use the locale that's passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../VS_csharp/locale.md).  
  
 The behavior of `isgraph` and `_isgraph_l` is undefined if `c` is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and `c` is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_istgraph`|`isgraph`|[_ismbcgraph](../VS_csharp/_ismbcgraph--_ismbcgraph_l--_ismbcprint--_ismbcprint_l--_ismbcpunct--_ismbcpunct_l--_ismbcblank--_ismbcblank_l--_ismbcspace--_ismbcspace_l.md)|`iswgraph`|  
|`_istgraph_l`|`_isgraph_l`|[_ismbcgraph_l](../VS_csharp/_ismbcgraph--_ismbcgraph_l--_ismbcprint--_ismbcprint_l--_ismbcpunct--_ismbcpunct_l--_ismbcblank--_ismbcblank_l--_ismbcspace--_ismbcspace_l.md)|`_iswgraph_l`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`isgraph`|<ctype.h>|  
|`iswgraph`|<ctype.h> or <wchar.h>|  
|`_isgraph_l`|<ctype.h>|  
|`_iswgraph_l`|<ctype.h> or <wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Character Classification](../VS_csharp/character-classification.md)   
 [Locale](../VS_csharp/locale.md)   
 [is, isw Routines](../VS_csharp/is--isw-routines.md)