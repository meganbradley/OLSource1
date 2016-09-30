---
title: "strncat_s, _strncat_s_l, wcsncat_s, _wcsncat_s_l, _mbsncat_s, _mbsncat_s_l"
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
  - "_wcsncat_s_l"
  - "wcsncat_s"
  - "_mbsncat_s_l"
  - "_mbsncat_s"
  - "strncat_s"
  - "_strncat_s_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strncat_s_l"
  - "_mbsncat_s_l"
  - "_tcsncat_s"
  - "wcsncat_s"
  - "wcsncat_s_l"
  - "strncat_s"
  - "_mbsncat_s"
  - "_tcsncat_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "concatenating strings"
  - "_mbsncat_s function"
  - "mbsncat_s_l function"
  - "_tcsncat_s function"
  - "_mbsncat_s_l function"
  - "strncat_s function"
  - "strings [C++], appending"
  - "strncat_s_l function"
  - "string concatenation [C++]"
  - "_tcsncat_s_l function"
  - "wcsncat_s function"
  - "appending strings"
  - "wcsncat_s_l function"
  - "mbsncat_s function"
ms.assetid: de77eca2-4d9c-4e66-abf2-a95fefc21e5a
caps.latest.revision: 44
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strncat_s, _strncat_s_l, wcsncat_s, _wcsncat_s_l, _mbsncat_s, _mbsncat_s_l
Appends characters to a string. These versions of [strncat, _strncat_l, wcsncat, wcsncat_l, _mbsncat _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated destination string.  
  
 [in]<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Size of the destination buffer.  
  
 [in]<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Null-terminated source string.  
  
 [in]<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Number of characters to append, or [_TRUNCATE](../vs140/_truncate.md).  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns 0 if successful, an error code on failure.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|----------------------|------------------------|-----------------|------------------|----------------------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or unterminated|any|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|not modified|  
|any|any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|not modified|  
|any|0, or too small|any|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|not modified|  
  
## Remarks  
 These functions try to append the first <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to the end of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is the lesser of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and the length of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. If appending those <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> characters will fit within <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (whose size is given as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) and still leave room for a null terminator, then those characters are appended, starting at the original terminating null of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and a new terminating null is appended; otherwise, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>[0] is set to the null character and the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 There is an exception to the above paragraph. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is [_TRUNCATE](../vs140/_truncate.md) then as much of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> as will fit is appended to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> while still leaving room to append a terminating null.  
  
 For example,  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 means that we are asking <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to append three characters to two characters in a buffer five characters long; this would leave no space for the null terminator, hence <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> zeroes out the string and calls the invalid parameter handler.  
  
 If truncation behavior is needed, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or adjust the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter accordingly:  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 or  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 In all cases, the resulting string is terminated with a null character. If copying takes place between strings that overlap, the behavior is undefined.  
  
 If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, or is <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the function returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> without modifying its parameters.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. The string arguments and return value of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> have no locale dependence; they are only provided for <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Appending 4 chars of 'there' to 10-byte buffer dest**  
 **old contents of dest: 'hi '**  
 **new contents of dest: 'hi ther'**  
**Appending 5 chars of 'there' to 10-byte buffer dest**  
 **old contents of dest: 'hi '**  
 **new contents of dest: 'hi there'**  
**Appending 6 chars of 'there' to 10-byte buffer dest**  
 **old contents of dest: 'hi '**  
 **new contents of dest: 'hi there'**  
**Destination buffer too small:**  
**Appending 4 chars of 'there' to 10-byte buffer dest**  
 **old contents of dest: 'hello '**  
**Invalid parameter handler invoked: (L"Buffer is too small" && 0)**  
 **new contents of dest: ''**  
**Truncation examples:**  
**Appending 'there' to 10-byte buffer dest with truncation semantics**  
 **old contents of dest: 'hello '**  
 **new contents of dest: 'hello the'**  
 **truncation did occur**  
**Appending '!' to 10-byte buffer dest with truncation semantics**  
 **old contents of dest: 'hello '**  
 **new contents of dest: 'hello !'**  
 **truncation did not occur**  
**Secure template overload example:**  
**Invalid parameter handler invoked: (L"Buffer is too small" && 0)**  
 **new contents of dest: ''**   
## .NET Framework Equivalent  
 [System::String::Concat](https://msdn.microsoft.com/en-us/library/system.string.concat.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)