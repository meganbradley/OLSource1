---
title: "isupper, _isupper_l, iswupper, _iswupper_l"
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
  - "isupper"
  - "iswupper"
  - "_iswupper_l"
  - "_isupper_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "isupper"
  - "_istupper"
  - "iswupper"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "istupper function"
  - "iswupper function"
  - "isupper_l function"
  - "_isupper_l function"
  - "iswupper_l function"
  - "_istupper function"
  - "_iswupper_l function"
  - "isupper function"
ms.assetid: da2bcc9f-241c-48c0-9a0e-ad273827e16a
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isupper, _isupper_l, iswupper, _iswupper_l
Determines whether an integer represents an uppercase character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a particular representation of an uppercase letter. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is an uppercase character (A – Z). <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a wide character that corresponds to an uppercase letter, or if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is one of an implementation-defined set of wide characters for which none of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is nonzero. Each of these routines returns 0 if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> does not satisfy the test condition.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> suffix use the locale that's passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
 The behavior of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[_ismbcupper](../vs140/_ismbclower--_ismbclower_l--_ismbcupper--_ismbcupper_l.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[_ismbcupper_l](../vs140/_ismbclower--_ismbclower_l--_ismbcupper--_ismbcupper_l.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<ctype.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Char::IsUpper](https://msdn.microsoft.com/en-us/library/system.char.isupper.aspx)  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)