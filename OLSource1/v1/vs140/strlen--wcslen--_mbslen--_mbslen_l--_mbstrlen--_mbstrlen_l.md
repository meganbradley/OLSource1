---
title: "strlen, wcslen, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l"
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
  - "_mbslen"
  - "_mbslen_l"
  - "_mbstrlen"
  - "wcslen"
  - "_mbstrlen_l"
  - "strlen"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbstrlen"
  - "wcslen"
  - "_tcslen"
  - "_ftcslen"
  - "strlen"
  - "_mbslen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcslen function"
  - "string length, getting"
  - "ftcslen function"
  - "lengths, strings"
  - "mbstrlen_l function"
  - "_mbslen_l function"
  - "_tcslen function"
  - "mbslen_l function"
  - "mbslen function"
  - "_mbstrlen function"
  - "strings [C++], getting length"
  - "mbstrlen function"
  - "_mbstrlen_l function"
  - "_ftcslen function"
  - "tcslen function"
  - "strlen function"
  - "_mbslen function"
ms.assetid: 16462f2a-1e0f-4eb3-be55-bf1c83f374c2
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strlen, wcslen, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l
Gets the length of a string, by using the current locale or a specified locale. More secure versions of these functions are available; see [strnlen, wcsnlen, _mbsnlen, _mbsnlen_l, _mbstrnlen, _mbstrnlen_l](../vs140/strnlen--strnlen_s--wcsnlen--wcsnlen_s--_mbsnlen--_mbsnlen_l--_mbstrnlen--_mbstrnlen_l.md)  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Null-terminated string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these functions returns the number of characters in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, excluding the terminal <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. No return value is reserved to indicate an error, except for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the string contains an invalid multibyte character.  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interprets the string as a single-byte character string, so its return value is always equal to the number of bytes, even if the string contains multibyte characters. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>; the argument of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character string and the count of characters is in wide (two-byte) characters. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> behave identically otherwise.  
  
 **Security Note** These functions incur a potential threat brought about by a buffer overrun problem. Buffer overrun problems are a frequent method of system attack, resulting in an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> return the number of multibyte characters in a multibyte-character string but they do not test for multibyte-character validity. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> test for multibyte-character validity and recognize multibyte-character sequences. If the string passed to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> contains an invalid multibyte character for the code page, the function returns -1 and sets <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Length of 'Count.' : 6**  
**Length of 'Count.' : 6**  
**Length of 'ABCァD' : 5**  
**Length of 'ABCァD' : 5**  
**Bytes in 'ABCァD' : 6**   
## .NET Framework Equivalent  
 [System::String::Length](https://msdn.microsoft.com/en-us/library/system.string.length.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [Locale](../vs140/locale.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)