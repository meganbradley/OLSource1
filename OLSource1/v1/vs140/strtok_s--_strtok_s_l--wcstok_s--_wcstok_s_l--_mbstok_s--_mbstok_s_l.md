---
title: "strtok_s, _strtok_s_l, wcstok_s, _wcstok_s_l, _mbstok_s, _mbstok_s_l"
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
  - "_wcstok_s_l"
  - "_mbstok_s_l"
  - "_mbstok_s"
  - "strtok_s"
  - "wcstok_s"
  - "_strtok_s_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcstok_s_l"
  - "_wcstok_s_l"
  - "_tcstok_s"
  - "_mbstok_s_l"
  - "strtok_s"
  - "wcstok_s"
  - "_mbstok_s"
  - "_strtok_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_strtok_s_l function"
  - "_mbstok_s_l function"
  - "strings [C++], searching"
  - "mbstok_s_l function"
  - "wcstok_s_l function"
  - "_wcstok_s_l function"
  - "_tcstok_s function"
  - "_tcstok_s_l function"
  - "strtok_s_l function"
  - "wcstok_s function"
  - "tokens, finding in strings"
  - "mbstok_s function"
  - "_mbstok_s function"
  - "strtok_s function"
ms.assetid: 7696c972-f83b-4617-8c82-95973e9fdb46
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtok_s, _strtok_s_l, wcstok_s, _wcstok_s_l, _mbstok_s, _mbstok_s_l
Finds the next token in a string, by using the current locale or a locale that's passed in. These versions of [strtok, _strtok_l, wcstok, _wcstok_l, _mbstok, _mbstok_l](../vs140/strtok--_strtok_l--wcstok--_wcstok_l--_mbstok--_mbstok_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
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
 Used to store position information between calls to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the next token found in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. They return <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when no more tokens are found. Each call modifies <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> by substituting a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> character for the first delimiter that occurs after the returned token.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Return value|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|----------------|------------------|---------------|------------------|-------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|any|pointer to a null pointer|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|any|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|any|any|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
  
 If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> but context is a pointer to a valid context pointer, there is no error.  
  
## Remarks  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function finds the next token in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The set of characters in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> specifies possible delimiters of the token to be found in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> on the current call. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>are wide-character and multibyte-character versions of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The arguments and return values of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
 This function validates its parameters. If an error condition occurs, as in the Error Conditions table, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
  
 On the first call to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> the function skips leading delimiters and returns a pointer to the first token in <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, terminating the token with a null character. More tokens can be broken out of the remainder of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> by a series of calls to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. Each call to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> modifies <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> by inserting a null character after the token returned by that call. The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> pointer keeps track of which string is being read and where in the string the next token is to be read. To read the next token from <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, call <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> with a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> value for the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> argument, and pass the same <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> parameter. The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> argument causes <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to search for the next token in the modified <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> argument can take any value from one call to the next so that the set of delimiters may vary.  
  
 Since the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> parameter supersedes the static buffers used in <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, it is possible to parse two strings simultaneously in the same thread.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Tokens:**  
 **A**  
 **Another**  
 **string**  
 **string**  
 **of**  
 **parsed**  
 **tokens**  
 **at**  
 **and**  
 **the**  
 **some**  
 **same**  
 **more**  
 **time.**  
 **tokens**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [strcspn, wcscspn, _mbscspn, _mbscspn_l](../vs140/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)