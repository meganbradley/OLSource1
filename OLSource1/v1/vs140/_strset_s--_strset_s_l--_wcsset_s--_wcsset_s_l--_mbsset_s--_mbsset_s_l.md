---
title: "_strset_s, _strset_s_l, _wcsset_s, _wcsset_s_l, _mbsset_s, _mbsset_s_l"
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
  - "_wcsset_s"
  - "_wcsset_s_l"
  - "_strset_s"
  - "_mbsset_s_l"
  - "_strset_s_l"
  - "_mbsset_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wcsset_s_l"
  - "strset_s"
  - "_mbsset_s"
  - "mbsset_s"
  - "_strset_s"
  - "_mbsset_s_l"
  - "strset_s_l"
  - "_wcsset_s"
  - "mbsset_s_l"
  - "wcsset_s_l"
  - "wcsset_s"
  - "_strset_s_l"
  - "_tcsset_s_l"
  - "_tcsset_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsset_s_l function"
  - "wcsset_s function"
  - "_mbsset_s function"
  - "tcsset_s function"
  - "strset_s_l function"
  - "characters [C++], setting"
  - "_wcsset_s_l function"
  - "_strset_s function"
  - "strset_s function"
  - "wcsset_s_l function"
  - "strings [C++], setting characters"
  - "_strset_s_l function"
  - "_mbsset_s_l function"
  - "_wcsset_s function"
  - "tcsset_s_l function"
  - "_tcsset_s_l function"
  - "_tcsset_s function"
  - "mbsset_s function"
ms.assetid: dceb2909-6b41-4792-acb7-888e45bb8b35
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strset_s, _strset_s_l, _wcsset_s, _wcsset_s_l, _mbsset_s, _mbsset_s_l
Sets characters of a string to a character. These versions of [_strset, _wcsset, _wcsset_l, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated string to be set.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> buffer.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Character setting.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Zero if successful, otherwise an error code.  
  
 These functions validate their arguments. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a null pointer, or the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument is less than or equal to 0, or the block passed in is not null-terminated, then the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function sets all the characters of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (converted to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>), except the terminating null character. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The data types of the arguments and return values vary accordingly. These functions behave identically otherwise.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Before: Fill the string with something.**  
**After:  \*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\***   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md)   
 [memset, wmemset](../vs140/memset--wmemset.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [_strnset, _wcsnset, _mbsnset, _mbsnset_l](../vs140/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)