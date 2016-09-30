---
title: "isxdigit, iswxdigit, _isxdigit_l, _iswxdigit_l"
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
  - "_iswxdigit_l"
  - "iswxdigit"
  - "isxdigit"
  - "_isxdigit_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "iswxdigit"
  - "isxdigit"
  - "_istxdigit"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "isxdigit function"
  - "istxdigit function"
  - "_iswxdigit_l function"
  - "_istxdigit function"
  - "_isxdigit_l function"
  - "iswxdigit_l function"
  - "isxdigit_l function"
  - "hexadecimal characters"
  - "iswxdigit function"
ms.assetid: c8bc5146-0b58-4e3f-bee3-f2318dd0f829
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isxdigit, iswxdigit, _isxdigit_l, _iswxdigit_l
Determines whether an integer represents a character that is a hexadecimal digit.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a particular representation of a hexadecimal digit. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a hexadecimal digit (A – F, a – f, or 0 – 9). <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a wide character that corresponds to a hexadecimal digit character. Each of these routines returns 0 if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does not satisfy the test condition.  
  
 For the "C" locale, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function does not support Unicode full-width hexadecimal characters.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suffix use the locale that's passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
 The behavior of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Char::IsNumber](https://msdn.microsoft.com/en-us/library/system.char.isnumber.aspx)  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)