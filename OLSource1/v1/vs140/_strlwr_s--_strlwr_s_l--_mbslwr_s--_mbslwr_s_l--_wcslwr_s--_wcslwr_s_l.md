---
title: "_strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l"
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
  - "_strlwr_s_l"
  - "_mbslwr_s_l"
  - "_mbslwr_s"
  - "_wcslwr_s"
  - "_strlwr_s"
  - "_wcslwr_s_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_strlwr_s_l"
  - "_strlwr_s"
  - "mbslwr_s_l"
  - "strlwr_s_l"
  - "_wcslwr_s"
  - "strlwr_s"
  - "mbslwr_s"
  - "_wcslwr_s_l"
  - "wcslwr_s_l"
  - "_tcslwr_s"
  - "_tcslwr_s_l"
  - "_mbslwr_s_l"
  - "wcslwr_s"
  - "_mbslwr_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tcslwr_s function"
  - "wcslwr_s function"
  - "_mbslwr_s function"
  - "_wcslwr_s function"
  - "strlwr_s_l function"
  - "mbslwr_s_l function"
  - "_strlwr_s function"
  - "string conversion [C++], case"
  - "strlwr_s function"
  - "wcslwr_s_l function"
  - "_tcslwr_s_l function"
  - "mbslwr_s function"
  - "strings [C++], case"
  - "_wcslwr_s_l function"
  - "converting case, CRT functions"
  - "_strlwr_s_l function"
  - "_mbslwr_s_l function"
  - "case, converting"
  - "tcslwr_s function"
  - "tcslwr_s_l function"
  - "strings [C++], converting case"
ms.assetid: 4883d31b-bdac-4049-83a1-91dfdeceee79
caps.latest.revision: 44
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l
Converts a string to lowercase, by using the current locale or a locale object that's passed in. These versions of [_strlwr, _wcslwr](../vs140/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated string to convert to lowercase.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Size of the buffer.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Zero if successful; a non-zero error code on failure.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not a valid null-terminated string, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the functions return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is less than the length of the string, the functions also return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function converts, in place, any uppercase letters in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to lowercase. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a multi-byte character version of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Mixed: The String to End All Strings!**  
**Lower: the string to end all strings!**  
**Upper: THE STRING TO END ALL STRINGS!**   
## .NET Framework Equivalent  
 [System::String::ToLower](https://msdn.microsoft.com/en-us/library/system.string.tolower.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_strupr_s, _strupr_s_l, _mbsupr_s, _mbsupr_s_l, _wcsupr_s, _wcsupr_s_l](../vs140/_strupr_s--_strupr_s_l--_mbsupr_s--_mbsupr_s_l--_wcsupr_s--_wcsupr_s_l.md)