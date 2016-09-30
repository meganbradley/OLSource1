---
title: "strtok, _strtok_l, wcstok, _wcstok_l, _mbstok, _mbstok_l"
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
  - "_mbstok_l"
  - "_mbstok"
  - "wcstok"
  - "_mbstok"
  - "strtok"
  - "_wcstok_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbstok"
  - "strtok"
  - "_tcstok"
  - "wcstok"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbstok_l function"
  - "strings [C++], searching"
  - "tcstok function"
  - "_tcstok function"
  - "_strtok_l function"
  - "strtok function"
  - "mbstok function"
  - "wcstok_l function"
  - "_mbstok function"
  - "tcstok_l function"
  - "tokens, finding in strings"
  - "_mbstok_l function"
  - "wcstok function"
  - "_wcstok_l function"
  - "_tcstok_l function"
  - "strtok_l function"
ms.assetid: 904cb734-f0d7-4d77-ba81-4791ddf461ae
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtok, _strtok_l, wcstok, _wcstok_l, _mbstok, _mbstok_l
Finds the next token in a string, by using the current locale or a specified locale that's passed in. More secure versions of these functions are available; see [strtok_s, _strtok_s_l, wcstok_s, _wcstok_s_l, _mbstok_s, _mbstok_s_l](../vs140/strtok_s--_strtok_s_l--wcstok_s--_wcstok_s_l--_mbstok_s--_mbstok_s_l.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 String containing token or tokens.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Set of delimiter characters.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the next token found in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. They return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when no more tokens are found. Each call modifies <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> by substituting a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> character for the first delimiter that occurs after the returned token.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function finds the next token in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The set of characters in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> specifies possible delimiters of the token to be found in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> on the current call. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
> [!IMPORTANT]
>  These functions incur a potential threat brought about by a buffer overrun problem. Buffer overrun problems are a frequent method of system attack, resulting in an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 On the first call to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the function skips leading delimiters and returns a pointer to the first token in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, terminating the token with a null character. More tokens can be broken out of the remainder of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> by a series of calls to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Each call to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>modifies <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> by inserting a null character after the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> returned by that call. To read the next token from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, call <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> with a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value for the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument causes <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to search for the next token in the modified <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> argument can take any value from one call to the next so that the set of delimiters may vary.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
> [!NOTE]
>  Each function uses a thread-local static variable for parsing the string into tokens. Therefore, multiple threads can simultaneously call these functions without undesirable effects. However, within a single thread, interleaving calls to one of these functions is highly likely to produce data corruption and inaccurate results. When parsing different strings, finish parsing one string before starting to parse the next. Also, be aware of the potential for danger when calling one of these functions from within a loop where another function is called. If the other function ends up using one of these functions, an interleaved sequence of calls will result, triggering data corruption.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Tokens:**  
 **A**  
 **string**  
 **of**  
 **tokens**  
 **and**  
 **some**  
 **more**  
 **tokens**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [strcspn, wcscspn, _mbscspn, _mbscspn_l](../vs140/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)