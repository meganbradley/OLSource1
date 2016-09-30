---
title: "ispunct, iswpunct, _ispunct_l, _iswpunct_l"
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
  - "ispunct"
  - "_iswpunct_l"
  - "iswpunct"
  - "_ispunct_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "iswpunct"
  - "_istpunct"
  - "ispunct"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_istpunct function"
  - "_ispunct_l function"
  - "iswpunct function"
  - "ispunct function"
  - "istpunct function"
  - "ispunct_l function"
  - "_iswpunct_l function"
  - "iswpunct_l function"
ms.assetid: 94403240-85c8-40a4-9c2b-e3e95c729c76
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ispunct, iswpunct, _ispunct_l, _iswpunct_l
Determines whether an integer represents a punctuation character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a particular representation of a punctuation character. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a nonzero value for any printable character that is not a space character or a character for which <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is nonzero. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a nonzero value for any printable wide character that is neither the space wide character nor a wide character for which <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is nonzero. Each of these routines returns 0 if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does not satisfy the test condition.  
  
 The result of the test condition for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function depends on the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions that do not have the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> suffix use the current locale for any locale-dependent behavior; the versions that do have the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> suffix are identical except that they use the locale that's passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 The behavior of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is undefined if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not EOF or in the range 0 through 0xFF, inclusive. When a debug CRT library is used and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not one of these values, the functions raise an assertion.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|**_** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|[_ismbcpunct](../vs140/8e0a5f47-ba64-4411-92a3-3c525d16e3be.md)|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<ctype.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<ctype.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)