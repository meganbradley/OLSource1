---
title: "isblank, iswblank, _isblank_l, _iswblank_l"
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
  - "isblank"
  - "_isblank_l"
  - "iswblank"
  - "_iswblank_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_iswblank_l"
  - "isblank"
  - "_istblank_l"
  - "_istblank"
  - "_isblank_l"
  - "iswblank"
dev_langs: 
  - "C++"
ms.assetid: 33ce96c0-f387-411a-8283-c3d2a69e56bd
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isblank, iswblank, _isblank_l, _iswblank_l
Determines whether an integer represents a blank character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a particular representation of a space or horizontal tab character, or is one of a locale-specific set of characters that are used to separate words within a line of text. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a space character (0x20) or horizontal tab character (0x09). The result of the test condition for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions depends on the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> category setting of the locale; for more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions that do not have the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> suffix use the current locale for any locale-dependent behavior; the versions that do have the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> suffix are identical except that they use the locale that's passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a wide character that corresponds to a standard space or horizontal tab character.  
  
 The behavior of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|[_ismbcblank](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[_ismbcblank_l](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Char::IsWhiteSpace](https://msdn.microsoft.com/en-us/library/system.char.iswhitespace.aspx)  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)