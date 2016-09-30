---
title: "iscntrl, iswcntrl, _iscntrl_l, _iswcntrl_l"
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
  - "iscntrl"
  - "_iswcntrl_l"
  - "_iscntrl_l"
  - "iswcntrl"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_istcntrl_l"
  - "_iswcntrl_l"
  - "iswcntrl"
  - "_iscntrl_l"
  - "iscntrl"
  - "_istcntrl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "iscntrl function"
  - "_iscntrl_l function"
  - "_iswcntrl_l function"
  - "_istcntrl function"
  - "istcntrl function"
  - "iswcntrl function"
  - "_istcntrl_l function"
ms.assetid: 616eebf9-aed4-49ba-ba2c-8677c8fe6fb5
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iscntrl, iswcntrl, _iscntrl_l, _iswcntrl_l
Determines whether an integer represents a control character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a particular representation of a control character. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a control character (0x00 – 0x1F or 0x7F). <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a control wide character. Each of these routines returns 0 if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does not satisfy the test condition.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> suffix use the locale parameter that's passed in instead of the current locale. For more information, see [Locale](../vs140/locale.md).  
  
 The behavior of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Char::IsControl](https://msdn.microsoft.com/en-us/library/system.char.iscontrol.aspx)  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)