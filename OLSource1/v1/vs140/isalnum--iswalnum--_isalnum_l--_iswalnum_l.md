---
title: "isalnum, iswalnum, _isalnum_l, _iswalnum_l"
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
  - "_iswalnum_l"
  - "_isalnum_l"
  - "iswalnum"
  - "isalnum"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_istalnum_l"
  - "_iswalnum_l"
  - "iswalnum"
  - "_isalnum_l"
  - "isalnum"
  - "_istalnum"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_istalnum function"
  - "_ismbcalnum_l function"
  - "iswalnum function"
  - "isalnum function"
  - "istalnum function"
  - "_isalnum_l function"
  - "_istalnum_l function"
  - "_iswalnum_l function"
ms.assetid: 0dc51306-ade8-4944-af27-e4176fc89093
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isalnum, iswalnum, _isalnum_l, _iswalnum_l
Determines whether an integer represents an alphanumeric character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a particular representation of an alphanumeric character. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a nonzero value if either <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is nonzero for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, that is, if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is within the ranges A – Z, a – z, or 0 – 9. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns a nonzero value if either <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is nonzero for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Each of these routines returns 0 if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> does not satisfy the test condition.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> suffix use the locale parameter that's passed in instead of the current locale. For more information, see [Locale](../vs140/locale.md).  
  
 The behavior of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[_ismbcalnum](../vs140/_ismbcalnum--_ismbcalnum_l--_ismbcalpha--_ismbcalpha_l--_ismbcdigit--_ismbcdigit_l.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Char::IsLetterOrDigit](https://msdn.microsoft.com/en-us/library/system.char.isletterordigit.aspx)  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)