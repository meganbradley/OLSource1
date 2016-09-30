---
title: "isspace, iswspace, _isspace_l, _iswspace_l"
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
  - "iswspace"
  - "_isspace_l"
  - "_iswspace_l"
  - "isspace"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "iswspace"
  - "_istspace"
  - "isspace"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "iswspace function"
  - "isspace function"
  - "_iswspace_l function"
  - "_isspace_l function"
  - "iswspace_l function"
  - "isspace_l function"
  - "_istspace function"
  - "istspace function"
ms.assetid: b851e0c0-36bb-4dac-a1a3-533540939035
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isspace, iswspace, _isspace_l, _iswspace_l
Determines whether an integer represents a space character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a particular representation of a space character. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a white-space character (0x09 – 0x0D or 0x20). The result of the test condition for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function depends on the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions that do not have the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> suffix use the current locale for any locale-dependent behavior; the versions that do have the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> suffix are identical except that they use the locale that's passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a wide character that corresponds to a standard white-space character.  
  
 The behavior of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|**_** <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|[_ismbcspace](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Char::IsWhiteSpace](https://msdn.microsoft.com/en-us/library/system.char.iswhitespace.aspx)  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)