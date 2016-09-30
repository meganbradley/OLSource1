---
title: "_mbclen, mblen, _mblen_l"
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
  - "_mbclen"
  - "mblen"
  - "_mblen_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mblen"
  - "ftclen"
  - "_mbclen"
  - "tclen"
  - "_ftclen"
  - "_tclen"
  - "mbclen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tclen function"
  - "_mblen_l function"
  - "_tclen function"
  - "mblen_l function"
  - "_mbclen function"
  - "mbclen function"
  - "mblen function"
ms.assetid: d5eb92a0-b7a3-464a-aaf7-9890a8e3ed70
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbclen, mblen, _mblen_l
Gets the length and determines the validity of a multibyte character.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Multibyte character.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Address of a multibyte-character byte sequence.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of bytes to check.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns 1 or 2, according to whether the multibyte character <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is 1 or 2 bytes long. There is no error return for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns the length, in bytes, of the multibyte character. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or it points to the wide-character null character, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns 0. If the object that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> points to does not form a valid multibyte character within the first <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> characters, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> returns –1.  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function returns the length, in bytes, of the multibyte character <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> does not point to the lead byte of a multibyte character as determined by an implicit call to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the result of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is unpredictable.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> returns the length in bytes of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if it is a valid multibyte character and determines multibyte-character validity associated with the code page. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> examines <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or fewer bytes contained in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, but not more than <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> bytes.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Maps to macro or inline function|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Maps to macro or inline function|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbccpy, _mbccpy_l](../vs140/_mbccpy--_mbccpy_l.md)   
 [strlen, strlen_l, wcslen, wcslen_l, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md)