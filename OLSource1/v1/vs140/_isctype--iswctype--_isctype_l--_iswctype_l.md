---
title: "_isctype, iswctype, _isctype_l, _iswctype_l"
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
  - "_isctype_l"
  - "iswctype"
  - "_iswctype_l"
  - "_isctype"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "iswctype"
  - "_isctype"
  - "_isctype_l"
  - "_iswctype"
  - "isctype"
  - "iswctype_l"
  - "isctype_l"
  - "_iswctype_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "isctype_l function"
  - "iswctype_l function"
  - "iswctype function"
  - "_isctype function"
  - "_isctype_l function"
  - "_iswctype_l function"
  - "isctype function"
  - "_iswctype function"
ms.assetid: cf7509b7-12fc-4d95-8140-ad2eb98173d3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _isctype, iswctype, _isctype_l, _iswctype_l
Tests <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for the property specified by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> argument. For each valid value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, there is an equivalent wide-character classification routine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Integer to test.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Property to test for. This is normally retrieved using ctype or [wctype](../vs140/wctype.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use for any locale-dependent tests.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> return a nonzero value if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has the property specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the current locale or 0 if it does not. The versions of these functions with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> suffix are identical except that they use the locale passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
 The behavior of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)