---
title: "strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l"
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
  - "_mbsncpy_s_l"
  - "wcsncpy_s"
  - "_strncpy_s_l"
  - "strncpy_s"
  - "_mbsncpy_s"
  - "_wcsncpy_s_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcsncpy_s"
  - "_wcsncpy_s_l"
  - "strncpy_s"
  - "_strncpy_s_l"
  - "wcsncpy_s"
  - "_tcsncpy_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wcsncpy_s_l function"
  - "_mbsnbcpy_s function"
  - "_tcsncpy_s_l function"
  - "mbsncpy_s function"
  - "strncpy_s_l function"
  - "_strncpy_s_l function"
  - "strncpy_s function"
  - "mbsncpy_s_l function"
  - "wcsncpy_s function"
  - "copying strings"
  - "strings [C++], copying"
  - "_mbsnbcpy_s_l function"
  - "_tcsncpy_s function"
  - "wcsncpy_s_l function"
ms.assetid: a971c800-94d1-4d88-92f3-a2fe236a4546
caps.latest.revision: 49
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l
Copies characters of one string to another.  These versions of [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Destination string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The size of the destination string, in characters.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Source string.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Number of characters to be copied, or [_TRUNCATE](../vs140/_truncate.md).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Zero if successful, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if truncation occurred, otherwise an error code.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|---------------|------------------------|-----------------|------------------|---------------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|not modified|  
|any|any|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>[0] set to 0|  
|any|0|any|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|not modified|  
|not <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|too small|any|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>[0] set to 0|  
  
## Remarks  
 These functions try to copy the first <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is the lesser of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and the length of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. If those <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> characters will fit within <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> (whose size is given as <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>) and still leave room for a null terminator, then those characters are copied and a terminating null is appended; otherwise, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>[0] is set to the null character and the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 There is an exception to the above paragraph. If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, then as much of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> as will fit into <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is copied while still leaving room for the terminating null which is always appended.  
  
 For example,  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 means that we are asking <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to copy five characters into a buffer five bytes long; this would leave no space for the null terminator, hence <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> zeroes out the string and calls the invalid parameter handler.  
  
 If truncation behavior is needed, use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or (<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> – 1):  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
 Note that unlike <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is greater than the length of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, the destination string is NOT padded with null characters up to length <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 The behavior of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is undefined if the source and destination strings overlap.  
  
 If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is 0, the invalid parameter handler is invoked. If execution is allowed to continue, the function returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>do vary accordingly. These six functions behave identically otherwise.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  _strncpy_s_l, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> have no locale dependence and are provided just for <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and are not intended to be called directly.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Copying 4 chars of 'howdy' to 10-byte buffer dest**  
 **new contents of dest: 'howd'**  
**Copying 5 chars of 'howdy' to 10-byte buffer dest**  
 **new contents of dest: 'howdy'**  
**Copying 6 chars of 'howdy' to 10-byte buffer dest**  
 **new contents of dest: 'howdy'**  
**Destination buffer too small:**  
**Copying 10 chars of 'Hi there!!' to 10-byte buffer dest**  
**Invalid parameter handler invoked: (L"Buffer is too small" && 0)**  
 **new contents of dest: ''**  
**Truncation examples:**  
**Copying 'How do you do?' to 10-byte buffer dest with truncation semantics**  
 **new contents of dest: 'How do yo'**  
 **truncation did occur**  
**Copying 'Howdy.' to 10-byte buffer dest with truncation semantics**  
 **new contents of dest: 'Howdy.'**  
 **truncation did not occur**  
**Secure template overload example:**  
**Invalid parameter handler invoked: (L"Buffer is too small" && 0)**  
 **new contents of dest: ''**   
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Original string:**  
 **'dogs like cats'**  
**After strncpy (no null-termination):**  
 **'mice like cats'**  
**After strncpy into middle of string:**  
 **'mice love cats'**  
**After strncpy_s (with null-termination):**  
 **'mice'**   
## .NET Framework Equivalent  
 [System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsnbcpy, _mbsnbcpy_l](../vs140/_mbsnbcpy--_mbsnbcpy_l.md)   
 [strcat_s, wcscat_s, _mbscat_s](../vs140/strcat_s--wcscat_s--_mbscat_s.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md)   
 [strncat_s, _strncat_s_l, wcsncat_s, _wcsncat_s_l, _mbsncat_s, _mbsncat_s_l](../vs140/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)