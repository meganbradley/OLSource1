---
title: "_create_locale, _wcreate_locale"
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
  - "_create_locale"
  - "__create_locale"
  - "_wcreate_locale"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "create_locale"
  - "_create_locale"
  - "__create_locale"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "locales, creating"
  - "_create_locale function"
  - "create_locale function"
  - "__create_locale function"
ms.assetid: ca362464-9f4a-4ec6-ab03-316c55c5be81
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _create_locale, _wcreate_locale
Creates a locale object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Category.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Locale specifier.  
  
## Return Value  
 If a valid <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are given, returns the specified locale settings as a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. The current locale settings of the program are not changed.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function allows you to create an object that represents certain region-specific settings, for use in locale-specific versions of many CRT functions (functions with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> suffix). The behavior is similar to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, except that instead of applying the specified locale settings to the current environment, the settings are saved in a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure that is returned. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure should be freed using [_free_locale](../vs140/_free_locale.md) when it is no longer needed.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> behave identically otherwise.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument specifies the parts of the locale-specific behavior that are affected. The flags used for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and the parts of the program they affect are as shown in the following table.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 All categories, as listed below.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> functions.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The character-handling functions (except <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, which are unaffected).  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Monetary-formatting information returned by the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Decimal-point character for the formatted output routines (such as <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>), for the data-conversion routines, and for the non-monetary formatting information returned by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. In addition to the decimal-point character, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> sets the thousands separator and the grouping control string returned by [localeconv](../vs140/localeconv.md).  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> functions.  
  
 This function validates the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameters. If the category parameter is not one of the values given in the previous table or if <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, the function returns <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> argument is a pointer to a string that specifies the locale. For information about the format of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> argument, see [Locale Names, Language and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md).  
  
 The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> argument can take a locale name, a language string, a language string and country/region code, a code page, or a language string, country/region code, and code page. The set of available locale names, languages, country/region codes, and code pages includes all that are supported by the Windows NLS API except the code pages that require more than two bytes per character—for example, UTF-7 and UTF-8. If you provide a code page like UTF-7 or UTF-8, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> will fail and return NULL. The set of locale names supported by <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> are described in [Locale Names, Language and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md). The set of language and country/region strings supported by <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> are listed in [Language Strings](../vs140/language-strings.md) and [Country/Region Strings](../vs140/country-region-strings.md).  
  
 For more information about locale settings, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md).  
  
 The previous name of this function, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> (with two leading underscores), has been deprecated.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<locale.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<locale.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Globalization::CultureInfo Class](https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.aspx)  
  
## See Also  
 [Locale Names, Languages and Country/Region Strings](../vs140/locale-names--languages--and-country-region-strings.md)   
 [Language Strings](../vs140/language-strings.md)   
 [Country/Region Strings](../vs140/country-region-strings.md)   
 [_free_locale](../vs140/_free_locale.md)   
 [_configthreadlocale](../vs140/_configthreadlocale.md)   
 [setlocale](../vs140/setlocale.md)   
 [Locale](../vs140/locale.md)   
 [localeconv](../vs140/localeconv.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [strlen, strlen_l, wcslen, wcslen_l, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)