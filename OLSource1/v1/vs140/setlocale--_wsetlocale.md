---
title: "setlocale, _wsetlocale"
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
  - "_wsetlocale"
  - "setlocale"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wsetlocale"
  - "_tsetlocale"
  - "setlocale"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wsetlocale function"
  - "setlocale function"
  - "tsetlocale function"
  - "locales, defining"
  - "_tsetlocale function"
  - "defining locales"
  - "_wsetlocale function"
ms.assetid: 3ffb684e-5990-4202-9553-b5339af9520d
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setlocale, _wsetlocale
Sets or retrieves the run-time locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Category affected by locale.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Locale specifier.  
  
## Return Value  
 If a valid <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are given, returns a pointer to the string associated with the specified <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not valid, returns a null pointer and the current locale settings of the program are not changed.  
  
 For example, the call  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 sets all categories, returning only the string  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 You can copy the string returned by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to restore that part of the program's locale information. Global or thread local storage is used for the string returned by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Later calls to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> overwrite the string, which invalidates string pointers returned by earlier calls.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function to set, change, or query some or all of the current program locale information specified by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> refers to the locality (country/region and language) for which you can customize certain aspects of your program. Some locale-dependent categories include the formatting of dates and the display format for monetary values. If you set <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to the default string for a language that has multiple forms supported on your computer, you should check the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> return value to see which language is in effect. For example, if you set <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to "chinese" the return value could be either "chinese-simplified" or "chinese-traditional".  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> argument and return value of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument specifies the parts of a program's locale information that are affected. The macros used for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and the parts of the program they affect are as follows:  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 All categories in the following list.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> functions.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The character-handling functions (except <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, which are unaffected).  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Monetary-formatting information returned by the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> function.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Decimal-point character for the formatted output routines (such as <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>), for the data-conversion routines, and for the non-monetary formatting information returned by <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. In addition to the decimal-point character, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> also sets the thousands separator and the grouping control string returned by [localeconv](../vs140/localeconv.md).  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> functions.  
  
 This function validates the category parameter. If the category parameter is not one of the values given in the previous table, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function sets <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> argument is a pointer to a string that specifies the locale. For information about the format of the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> argument, see [Locale Names, Language and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md). If <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> points to an empty string, the locale is the implementation-defined native environment. A value of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> specifies the minimal ANSI conforming environment for C translation. The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> locale assumes that all <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> data types are 1 byte and that their value is always less than 256.  
  
 At program startup, the equivalent of the following statement is executed:  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
 The <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> argument can take a locale name, a language string, a language string and country/region code, a code page, or a language string, country/region code, and code page. The set of available locale names, languages, country/region codes, and code pages includes all those supported by the Windows NLS API except code pages that require more than two bytes per character, such as UTF-7 and UTF-8. If you provide a code page value of UTF-7 or UTF-8, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> will fail, returning NULL. The set of locale names supported by <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> are described in [Locale Names, Language and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md). The set of language and country/region strings supported by <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> are listed in [Language Strings](../vs140/language-strings.md) and [Country/Region Strings](../vs140/country-region-strings.md). We recommend the locale name form for performance and for maintainability of locale strings embedded in code or serialized to storage. The locale name strings are less likely to be changed by an operating system update than the language and country/region name form.  
  
 A null pointer that's passed as the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> argument tells <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to query instead of to set the international environment. If the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> argument is a null pointer, the program's current locale setting is not changed. Instead, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> returns a pointer to the string that's associated with the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> of the thread's current locale. If the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, the function returns a string that indicates the current setting of each category, separated by semicolons. For example, the sequence of calls  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
 returns  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
 which is the string that's associated with the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> category.  
  
 The following examples pertain to the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> category. Either of the strings ".OCP" and ".ACP" can be used instead of a code page number to specify use of the user-default OEM code page and user-default ANSI code page, respectively.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Sets the locale to the default, which is the user-default ANSI code page obtained from the operating system.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Explicitly sets the locale to the current OEM code page obtained from the operating system.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Sets the locale to the ANSI code page obtained from the operating system.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Sets the locale to the locale name that's indicated by *\<localename>*.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Sets the locale to the language and country/region indicated by *\<language>* and *\<country>*, together with the default code page obtained from the host operating system.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Sets the locale to the language, country/region, and code page indicated by the *\<language>*, *\<country>*, and *\<code_page>* strings. You can use various combinations of language, country/region, and code page. For example, this call sets the locale to French Canada with code page 1252:  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
 This call sets the locale to French Canada with the default ANSI code page:  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
 This call sets the locale to French Canada with the default OEM code page:  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 Sets the locale to the language that's indicated by *\<language>*, and uses the default country/region for the specified language and the user-default ANSI code page for that country/region as obtained from the host operating system. For example, the following calls to <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> are functionally equivalent:  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
  
 We recommend the first form for performance and maintainability.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Sets the code page to the value indicated by *\<code_page>*, together with the default country/region and language (as defined by the host operating system) for the specified code page.  
  
 The category must be either <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> to effect a change of code page. For example, if the default country/region and language of the host operating system are "United States" and "English," the following two calls to <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> are functionally equivalent:  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
 For more information, see the [setlocale](../vs140/setlocale.md) pragma directive in the [Preprocessor Reference](../vs140/c-c---preprocessor-reference.md).  
  
 The function [_configthreadlocale](../vs140/_configthreadlocale.md) is used to control whether <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> affects the locale of all threads in a program or only the locale of the calling thread.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|\<locale.h>|  
|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|\<locale.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The thread locale is now set to en-US.**  
**The time in en-US locale is: 'Wednesday, May 12, 2004'**  
**The thread locale is now set to de-DE.**  
**The time in de-DE locale is: 'Mittwoch, 12. Mai 2004'**   
## .NET Framework Equivalent  
 [System::Globalization::CultureInfo Class](https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.aspx)  
  
## See Also  
 [Locale Names, Language and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md)   
 [_configthreadlocale](../vs140/_configthreadlocale.md)   
 [_create_locale, _wcreate_locale](../vs140/_create_locale--_wcreate_locale.md)   
 [Locale](../vs140/locale.md)   
 [localeconv](../vs140/localeconv.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [strlen, strlen_l, wcslen, wcslen_l, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)