---
title: "isascii, __isascii, iswascii"
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
  - "iswascii"
  - "__isascii"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "ntdll.dll"
  - "api-ms-win-crt-string-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "iswascii"
  - "istascii"
  - "__isascii"
  - "_istascii"
  - "isascii"
  - "ctype/isascii"
  - "ctype/__isascii"
  - "corecrt_wctype/iswascii"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__isascii function"
  - "_isascii function"
  - "isascii function"
  - "_istascii function"
  - "istascii function"
  - "iswascii function"
ms.assetid: ba4325ad-7cb3-4fb9-b096-58906d67971a
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# isascii, __isascii, iswascii
Determines whether a particular character is an ASCII character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to test.  
  
## Return Value  
 Each of these routines returns nonzero if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a particular representation of an ASCII character. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an ASCII character (in the range 0x00 – 0x7F). <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a nonzero value if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a wide-character representation of an ASCII character. Each of these routines returns 0 if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not satisfy the test condition.  
  
## Remarks  
 Both <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are implemented as macros unless the preprocessor macro _CTYPE_DISABLE_MACROS is defined.  
  
 For backward compatibility, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is implemented as a macro only if [__STDC\_\_](../vs140/predefined-macros.md) is not defined or is defined as 0; otherwise it is undefined.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|C: \<ctype.h>\<br />\<br /> C++: \<cctype> or \<ctype.h>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|C: \<wctype.h>, \<ctype.h>, or \<wchar.h>\<br />\<br /> C++: \<cwctype>, \<cctype>, \<wctype.h>, \<ctype.h>, or \<wchar.h>|  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> functions are Microsoft specific. For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)