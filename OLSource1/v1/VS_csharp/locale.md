---
title: "Locale"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.international"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "localization, locale"
  - "country information"
  - "language information routines"
  - "setlocale function"
  - "locale routines"
ms.assetid: 442f8112-9288-44d7-be3c-15d22652093a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Locale
*Locale* refers to country/region and language settings that you can use to customize your program. Some locale-dependent categories include the display formats for dates and monetary values. For more information, see [Locale Categories](../VS_csharp/locale-categories.md).  
  
 Use the [setlocale](../VS_csharp/setlocale--_wsetlocale.md) function to change or query some or all of the current program or thread locale information while using functions without the `_l` suffix. The functions with the `_l` suffix will use the locale parameter passed in for their locale information during the execution of that specific function only. To create a locale for use with a function with a `_l` suffix, use [_create_locale](../VS_csharp/_create_locale--_wcreate_locale.md). To free this locale, use [_free_locale](../VS_csharp/_free_locale.md). To get the current locale, use [_get_current_locale](../VS_csharp/_get_current_locale.md).  
  
 Use [_configthreadlocale](../VS_csharp/_configthreadlocale.md) to control whether each thread has its own locale, or all threads in a program share the same locale. For more information, see [Locales and Code Pages](../VS_csharp/locales-and-code-pages.md).  
  
 More secure versions of the functions in the following table are available, indicated by the `_s` ("secure") suffix. For more information, see [Security-Enhanced CRT Functions](../VS_csharp/security-features-in-the-crt.md).  
  
### Locale-Dependent Routines  
  
|Routine|Use|`setlocale` category setting dependence|  
|-------------|---------|---------------------------------------------|  
|[atof, _atof_l, _wtof, _wtof_l](../VS_csharp/atof--_atof_l--_wtof--_wtof_l.md)|Convert character to floating-point value|`LC_NUMERIC`|  
|[atoi, _atoi_l, _wtoi, _wtoi_l](../VS_csharp/atoi--_atoi_l--_wtoi--_wtoi_l.md)|Convert character to integer value|`LC_NUMERIC`|  
|[atoi64, _atoi64_l, _wtoi64, _wtoi64_l](../VS_csharp/_atoi64--_atoi64_l--_wtoi64--_wtoi64_l.md)|Convert character to 64-bit integer value|`LC_NUMERIC`|  
|[atol, _atol_l, _wtol, _wtol_l](../VS_csharp/atol--_atol_l--_wtol--_wtol_l.md)|Convert character to long value|`LC_NUMERIC`|  
|[_atodbl, _atoldbl, _atoflt](../VS_csharp/_atodbl--_atodbl_l--_atoldbl--_atoldbl_l--_atoflt--_atoflt_l.md)|Convert character to double-long value|`LC_NUMERIC`|  
|[is Routines](../VS_csharp/is--isw-routines.md)|Test given integer for particular condition.|`LC_CTYPE`|  
|[isleadbyte, _isleadbyte_l](../VS_csharp/isleadbyte--_isleadbyte_l.md)|Test for lead byte|`LC_CTYPE`|  
|[localeconv](../VS_csharp/localeconv.md)|Read appropriate values for formatting numeric quantities|`LC_MONETARY, LC_NUMERIC`|  
|[MB_CUR_MAX](../VS_csharp/mb_cur_max.md)|Maximum length in bytes of any multibyte character in current locale (macro defined in STDLIB.H)|`LC_CTYPE`|  
|[_mbccpy, _mbccpy_l](../VS_csharp/_mbccpy--_mbccpy_l.md),[_mbccpy_s, _mbccpy_s_l](../VS_csharp/_mbccpy_s--_mbccpy_s_l.md)|Copy one multibyte character|`LC_CTYPE`|  
|[_mbclen, mblen, _mblen_l](../VS_csharp/_mbclen--mblen--_mblen_l.md)|Validate and return number of bytes in multibyte character|`LC_CTYPE`|  
|[strlen, strlen_l, wcslen, wcslen_l, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l](../VS_csharp/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md)|For multibyte-character strings: validate each character in string; return string length|`LC_CTYPE`|  
|[mbstowcs, _mbstowcs_l](../VS_csharp/mbstowcs--_mbstowcs_l.md),[mbstowcs_s, _mbstowcs_s_l](../VS_csharp/mbstowcs_s--_mbstowcs_s_l.md)|Convert sequence of multibyte characters to corresponding sequence of wide characters|`LC_CTYPE`|  
|[mbtowc, _mbtowc_l](../VS_csharp/mbtowc--_mbtowc_l.md)|Convert multibyte character to corresponding wide character|`LC_CTYPE`|  
|[printf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md) functions|Write formatted output|`LC_NUMERIC` (determines radix character output)|  
|[scanf](../VS_csharp/scanf--_scanf_l--wscanf--_wscanf_l.md) functions|Read formatted input|`LC_NUMERIC` (determines radix character recognition)|  
|[setlocale, _wsetlocale](../VS_csharp/setlocale--_wsetlocale.md)|Select locale for program|Not applicable|  
|[strcoll, wcscoll, _mbscoll, _strcoll_l, _wcscoll_l, _mbscoll_l](../VS_csharp/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md)|Compare characters of two strings|`LC_COLLATE`|  
|[_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l](../VS_csharp/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md)|Compare two strings without regard to case|`LC_CTYPE`|  
|[_stricoll, _wcsicoll, _mbsicoll, _stricoll_l, _wcsicoll_l, _mbsicoll_l](../VS_csharp/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md)|Compare characters of two strings (case insensitive)|`LC_COLLATE`|  
|[_strncoll, _wcsncoll, _mbsncoll, _strncoll_l, _wcsncoll_l, _mbsncoll_l](../VS_csharp/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|Compare first `n` characters of two strings|`LC_COLLATE`|  
|[_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../VS_csharp/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)|Compare characters of two strings without regard to case.|`LC_CTYPE`|  
|[_strnicoll, _wcsnicoll, _mbsnicoll, _strnicoll_l, _wcsnicoll_l, _mbsnicoll_l](../VS_csharp/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|Compare first `n` characters of two strings (case insensitive)|`LC_COLLATE`|  
|[strftime, wcsftime, _strftime_l, _wcsftime_l](../VS_csharp/strftime--wcsftime--_strftime_l--_wcsftime_l.md)|Format date and time value according to supplied `format` argument|`LC_TIME`|  
|[_strlwr, _wcslwr, _mbslwr, _strlwr_l, _wcslwr_l, _mbslwr_l](../VS_csharp/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md),[_strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l](../VS_csharp/_strlwr_s--_strlwr_s_l--_mbslwr_s--_mbslwr_s_l--_wcslwr_s--_wcslwr_s_l.md)|Convert, in place, each uppercase letter in given string to lowercase|`LC_CTYPE`|  
|[strtod, _strtod_l, wcstod](../VS_csharp/strtod--_strtod_l--wcstod--_wcstod_l.md)|Convert character string to `double` value|`LC_NUMERIC` (determines radix character recognition)|  
|[strtol, wcstol, _strtol_l, _wcstol_l](../VS_csharp/strtol--wcstol--_strtol_l--_wcstol_l.md)|Convert character string to `long`value|`LC_NUMERIC` (determines radix character recognition)|  
|[strtoul, _strtoul_l, wcstoul, _wcstoul_l](../VS_csharp/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)|Convert character string to unsigned long value|`LC_NUMERIC` (determines radix character recognition)|  
|[_strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr_l, _wcsupr](../VS_csharp/_strupr--_strupr_l--_mbsupr--_mbsupr_l--_wcsupr_l--_wcsupr.md),[_strupr_s, _strupr_s_l, _mbsupr_s, _mbsupr_s_l, _wcsupr_s, _wcsupr_s_l](../VS_csharp/_strupr_s--_strupr_s_l--_mbsupr_s--_mbsupr_s_l--_wcsupr_s--_wcsupr_s_l.md)|Convert, in place, each lowercase letter in string to uppercase|`LC_CTYPE`|  
|[strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../VS_csharp/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)|Transform string into collated form according to locale|`LC_COLLATE`|  
|[tolower, _tolower, towlower, _tolower_l, _towlower_l](../VS_csharp/tolower--_tolower--towlower--_tolower_l--_towlower_l.md),[_mbctolower, _mbctolower_l](../VS_csharp/_mbctolower--_mbctolower_l--_mbctoupper--_mbctoupper_l.md)|Convert given character to corresponding lowercase character|`LC_CTYPE`|  
|[toupper _toupper, towupper, _toupper_l, _towupper_l](../VS_csharp/toupper--_toupper--towupper--_toupper_l--_towupper_l.md),[_mbctoupper, _mbctoupper_l](../VS_csharp/_mbctolower--_mbctolower_l--_mbctoupper--_mbctoupper_l.md)|Convert given character to corresponding uppercase letter|`LC_CTYPE`|  
|[wcstombs, _wcstombs_l](../VS_csharp/wcstombs--_wcstombs_l.md),[wcstombs_s, _wcstombs_s_l](../VS_csharp/wcstombs_s--_wcstombs_s_l.md)|Convert sequence of wide characters to corresponding sequence of multibyte characters|`LC_CTYPE`|  
|[wctomb, _wctomb_l](../VS_csharp/wctomb--_wctomb_l.md),[wctomb_s, _wctomb_s_l](../VS_csharp/wctomb_s--_wctomb_s_l.md)|Convert wide character to corresponding multibyte character|`LC_CTYPE`|  
  
> [!NOTE]
>  For multibyte routines, the multibyte code page must be equivalent to the locale set with [setlocale](../VS_csharp/setlocale--_wsetlocale.md). [_setmbcp](../VS_csharp/_setmbcp.md), with an argument of `_MB_CP_LOCALE` makes the multibyte code page the same as the `setlocale` code page.  
  
## See Also  
 [Internationalization](../VS_csharp/internationalization.md)   
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)