---
title: "_ismbblead, _ismbblead_l"
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
  - "_ismbblead_l"
  - "_ismbblead"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ismbblead_l"
  - "istlead"
  - "_ismbblead"
  - "_ismbblead_l"
  - "ismbblead"
  - "_istlead"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbblead_l function"
  - "ismbblead function"
  - "_ismbblead function"
  - "istlead function"
  - "ismbblead_l function"
  - "_istlead function"
ms.assetid: 2abc6f75-ed5c-472e-bfd0-e905a1835ccf
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ismbblead, _ismbblead_l
Tests a character to determine whether it is a lead byte of a multibyte character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Integer to be tested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a nonzero value if the integer <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the first byte of a multibyte character.  
  
## Remarks  
 Multibyte characters consist of a lead byte followed by a trailing byte. Lead bytes are distinguished by being in a particular range for a given character set. For example, in code page 932 only, lead bytes range from 0x81 – 0x9F and 0xE0 – 0xFC.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses the current locale for locale-dependent behavior. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Always returns false|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Always returns false|  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<mbctype.h> or \<mbstring.h>|\<ctype.h>,* \<limits.h>, \<stdlib.h>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<mbctype.h> or \<mbstring.h>|\<ctype.h>,* \<limits.h>, \<stdlib.h>|  
  
 \* For manifest constants for the test conditions.  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)