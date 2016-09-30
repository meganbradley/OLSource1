---
title: "_strset, _strset_l, _wcsset, _wcsset_l, _mbsset, _mbsset_l"
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
  - "_wcsset"
  - "_mbsset"
  - "_strset_l"
  - "_strset"
  - "_wcsset_l"
  - "_mbsset_l"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsset"
  - "_strset_l"
  - "_mbsset"
  - "_strset"
  - "mbsset_l"
  - "strset_l"
  - "_wcsset"
  - "_ftcsset"
  - "wcsset_l"
  - "_tcsset_l"
  - "_mbsset_l"
  - "_wcsset_l"
  - "_fstrset"
  - "_tcsset"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wcsset_l function"
  - "_tcsset function"
  - "wcsset_l function"
  - "_ftcsset function"
  - "characters [C++], setting"
  - "_strset function"
  - "ftcsset function"
  - "strings [C++], setting characters"
  - "mbsset function"
  - "tcsset_l function"
  - "_fstrset function"
  - "mbsset_l function"
  - "strset_l function"
  - "_wcsset function"
  - "_mbsset function"
  - "_mbsset_l function"
  - "tcsset function"
  - "_strset_l function"
  - "fstrset function"
  - "_tcsset_l function"
ms.assetid: c42ded42-2ed9-4f06-a0a9-247ba305473a
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strset, _strset_l, _wcsset, _wcsset_l, _mbsset, _mbsset_l
Sets characters of a string to a character. More secure versions of these functions are available; see [_strset_s, _strset_s_l, _wcsset_s, _wcsset_s_l, _mbsset_s, _mbsset_s_l](../vs140/_strset_s--_strset_s_l--_wcsset_s--_wcsset_s_l--_mbsset_s--_mbsset_s_l.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated string to be set.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Character setting.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the altered string.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function sets all characters (except the terminating null character) of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, converted to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and the data types of the arguments and return values vary accordingly. These functions behave identically otherwise.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue,<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> do not validate their parameters.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions are identical, except that the ones that don't have the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> suffix use the current locale and the ones that do have the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> suffix instead use the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
> [!IMPORTANT]
>  These functions might be vulnerable to buffer overrun threats. Buffer overruns can be used for system attacks because they can cause an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Before: Fill the string with something.**  
**After:  \*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\***   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
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