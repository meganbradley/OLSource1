---
title: "String Manipulation (CRT)"
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
  - "c.strings"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strings [C++], manipulating"
  - "string manipulation"
  - "manipulating strings"
ms.assetid: 6545861a-59e7-408d-9d29-2ec9134fc91a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String Manipulation (CRT)
These routines operate on null-terminated single-byte character, wide-character, and multibyte-character strings. Use the buffer-manipulation routines, described in [Buffer Manipulation](../VS_csharp/buffer-manipulation.md), to work with character arrays that do not end with a null character.  
  
### String-Manipulation Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[strcoll, wcscoll, _mbscoll, _strcoll_l, _wcscoll_l, _mbscoll_l](../VS_csharp/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md), [_stricoll, _wcsicoll, _mbsicoll, _stricoll_l, _wcsicoll_l, _mbsicoll_l](../VS_csharp/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md), [_strncoll, _wcsncoll, _mbsncoll, _strncoll_l, _wcsncoll_l, _mbsncoll_l](../VS_csharp/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md), [_strnicoll, _wcsnicoll, _mbsnicoll, _strnicoll_l, _wcsnicoll_l, _mbsnicoll_l](../VS_csharp/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|Compare two character strings using code page information (`_mbsicoll` and `_mbsnicoll` are case-insensitive)|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[_mbsdec, _mbsdec_l, _strdec, _wcsdec](../VS_csharp/_strdec--_wcsdec--_mbsdec--_mbsdec_l.md)|Move string pointer back one character|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_mbsinc, _mbsinc_l, _strinc, _wcsinc](../VS_csharp/_strinc--_wcsinc--_mbsinc--_mbsinc_l.md)|Advance string pointer by one character|Not applicable.|  
|[_mbsnbcat, _mbsnbcat_l](../VS_csharp/_mbsnbcat--_mbsnbcat_l.md), [_mbsnbcat_s, _mbsnbcat_s_l](../VS_csharp/_mbsnbcat_s--_mbsnbcat_s_l.md)|Append, at most, first `n` bytes of one character string to another|Not applicable.|  
|[_mbsnbcmp, _mbsnbcmp_l](../VS_csharp/_mbsnbcmp--_mbsnbcmp_l.md)|Compare first `n` bytes of two character strings|Not applicable.|  
|[_mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l, _strncnt, _wcsncnt](../VS_csharp/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)|Return number of character bytes within supplied character count|Not applicable.|  
|[_mbsnbcpy, _mbsnbcpy_l](../VS_csharp/_mbsnbcpy--_mbsnbcpy_l.md), [_mbsnbcpy_s, _mbsnbcpy_s_l](../VS_csharp/_mbsnbcpy_s--_mbsnbcpy_s_l.md)|Copy `n` bytes of string|Not applicable.|  
|[_mbsnbicmp, _mbsnbicmp_l](../VS_csharp/_mbsnbicmp--_mbsnbicmp_l.md)|Compare `n` bytes of two character strings, ignoring case|Not applicable.|  
|[_mbsnbset, _mbsnbset_l](../VS_csharp/_mbsnbset--_mbsnbset_l.md)|Set first `n` bytes of character string to specified character|Not applicable.|  
|[_mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l, _strncnt, _wcsncnt](../VS_csharp/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)|Return number of characters within supplied byte count|Not applicable.|  
|[_mbsnextc, _mbsnextc_l, _strnextc, _wcsnextc](../VS_csharp/_strnextc--_wcsnextc--_mbsnextc--_mbsnextc_l.md)|Find next character in string|Not applicable.|  
|[_mbsninc, _mbsninc_l, _strninc, _wcsninc](../VS_csharp/_strninc--_wcsninc--_mbsninc--_mbsninc_l.md)|Advance string pointer by `n` characters|Not applicable.|  
|[_mbsspnp, _mbsspnp_l, _strspnp, _wcsspnp](../VS_csharp/_strspnp--_wcsspnp--_mbsspnp--_mbsspnp_l.md)|Return pointer to first character in given string that is not in another given string|Not applicable.|  
|[_scprintf, _scwprintf](../VS_csharp/_scprintf--_scprintf_l--_scwprintf--_scwprintf_l.md)|Return the number of characters in a formatted string|Not applicable.|  
|[_snscanf, _snwscanf](../VS_csharp/_snscanf--_snscanf_l--_snwscanf--_snwscanf_l.md), [_snscanf_s, _snwscanf_s](../VS_csharp/_snscanf_s--_snscanf_s_l--_snwscanf_s--_snwscanf_s_l.md)|Read formatted data of a specified length from the standard input stream.|Not applicable.|  
|[sscanf, swscanf](../VS_csharp/sscanf--_sscanf_l--swscanf--_swscanf_l.md), [sscanf_s, swscanf_s](../VS_csharp/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)|Read formatted data of a specified length from the standard input stream.|Not applicable.|  
|[sprintf, swprintf](../VS_csharp/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md), [sprintf_s, swprintf_s](../VS_csharp/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md), [_sprintf_p, _swprintf_p](../VS_csharp/_sprintf_p--_sprintf_p_l--_swprintf_p--_swprintf_p_l.md)|Write formatted data to a string|[System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)|  
|[strcat, wcscat, _mbscat](../VS_csharp/strcat--wcscat--_mbscat.md), [strcat_s, wcscat_s, _mbscat_s](../VS_csharp/strcat_s--wcscat_s--_mbscat_s.md)|Append one string to another|[System::String::Concat](https://msdn.microsoft.com/en-us/library/system.string.concat.aspx)|  
|[strchr, wcschr, _mbschr, _mbschr_l](../VS_csharp/strchr--wcschr--_mbschr--_mbschr_l.md)|Find first occurrence of specified character in string|[System::String::IndexOf](https://msdn.microsoft.com/en-us/library/system.string.indexof.aspx)|  
|[strcmp, wcscmp, _mbscmp](../VS_csharp/strcmp--wcscmp--_mbscmp.md)|Compare two strings|[System::String::CompareOrdinal](https://msdn.microsoft.com/en-us/library/system.string.compareordinal.aspx)|  
|[strcoll, wcscoll, _mbscoll, _strcoll_l, _wcscoll_l, _mbscoll_l](../VS_csharp/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md), [_stricoll, _wcsicoll, _mbsicoll, _stricoll_l, _wcsicoll_l, _mbsicoll_l](../VS_csharp/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md), [_strncoll, _wcsncoll, _mbsncoll, _strncoll_l, _wcsncoll_l, _mbsncoll_l](../VS_csharp/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md), [_strnicoll, _wcsnicoll, _mbsnicoll, _strnicoll_l, _wcsnicoll_l, _mbsnicoll_l](../VS_csharp/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|Compare two strings using current locale code page information (`_stricoll`, `_wcsicoll`, `_strnicoll`, and `_wcsnicoll` are case-insensitive)|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[strcpy, wcscpy, _mbscpy](../VS_csharp/strcpy--wcscpy--_mbscpy.md), [strcpy_s, wcscpy_s, _mbscpy_s](../VS_csharp/strcpy_s--wcscpy_s--_mbscpy_s.md)|Copy one string to another|[System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)|  
|[strcspn, wcscspn, _mbscspn, _mbscspn_l](../VS_csharp/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)|Find first occurrence of character from specified character set in string|[System::String::IndexOfAny](https://msdn.microsoft.com/en-us/library/system.string.indexofany.aspx)|  
|[_strdup, _wcsdup, _mbsdup](../VS_csharp/_strdup--_wcsdup--_mbsdup.md), [_strdup_dbg, _wcsdup_dbg](../VS_csharp/_strdup_dbg--_wcsdup_dbg.md)|Duplicate string|[System::String::Clone](https://msdn.microsoft.com/en-us/library/system.string.clone.aspx)|  
|[strerror, _strerror, _wcserror, \__wcserror](../VS_csharp/strerror--_strerror--_wcserror--__wcserror.md), [strerror_s, _strerror_s, _wcserror_s, \__wcserror_s](../VS_csharp/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md)|Map error number to message string|[System::Exception::Message](https://msdn.microsoft.com/en-us/library/system.exception.message.aspx)|  
|[strftime, wcsftime, _strftime_l, _wcsftime_l](../VS_csharp/strftime--wcsftime--_strftime_l--_wcsftime_l.md)|Format date-and-time string|[System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)|  
|[_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l](../VS_csharp/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md)|Compare two strings without regard to case|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[strlen, strlen_l, wcslen, wcslen_l, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l](../VS_csharp/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md), [strnlen, strnlen_l, wcsnlen, wcsnlen_l, _mbsnlen, _mbsnlen_l, _mbstrnlen, _mbstrnlen_l](../VS_csharp/strnlen--strnlen_s--wcsnlen--wcsnlen_s--_mbsnlen--_mbsnlen_l--_mbstrnlen--_mbstrnlen_l.md)|Find length of string|[System::String::Length](https://msdn.microsoft.com/en-us/library/system.string.length.aspx)|  
|[_strlwr, _wcslwr, _mbslwr, _strlwr_l, _wcslwr_l, _mbslwr_l](../VS_csharp/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md), [_strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l](../VS_csharp/_strlwr_s--_strlwr_s_l--_mbslwr_s--_mbslwr_s_l--_wcslwr_s--_wcslwr_s_l.md)|Convert string to lowercase|[System::String::ToLower](https://msdn.microsoft.com/en-us/library/system.string.tolower.aspx)|  
|[strncat, wcsncat, _mbsncat _mbsncat_l](../VS_csharp/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md), [strncat_s, wcsncat_s, _mbsncat_s, _mbsncat_s_l](../VS_csharp/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)|Append characters of string|[System::String::Concat](https://msdn.microsoft.com/en-us/library/system.string.concat.aspx)|  
|[strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../VS_csharp/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|Compare characters of two strings|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[strncpy, wcsncpy, _mbsncpy, _mbsncpy_l](../VS_csharp/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md), [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l](../VS_csharp/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)|Copy characters of one string to another|[System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)|  
|[_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../VS_csharp/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)|Compare characters of two strings without regard to case|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[_strnset, _wcsnset, _mbsnset, _mbsnset_l](../VS_csharp/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)|Set first `n` characters of string to specified character|[System::String::Replace](https://msdn.microsoft.com/en-us/library/system.string.replace.aspx)|  
|[strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l](../VS_csharp/strpbrk--wcspbrk--_mbspbrk--_mbspbrk_l.md)|Find first occurrence of character from one string in another string|[System::String::IndexOfAny](https://msdn.microsoft.com/en-us/library/system.string.indexofany.aspx)|  
|[strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../VS_csharp/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)|Find last occurrence of given character in string|[System::String::LastIndexOf](https://msdn.microsoft.com/en-us/library/system.string.lastindexof.aspx)|  
|[_strrev, _wcsrev, _mbsrev, _mbsrev_l](../VS_csharp/_strrev--_wcsrev--_mbsrev--_mbsrev_l.md)|Reverse string|Not applicable.|  
|[_strset, _wcsset, _mbsset, _mbsset_l](../VS_csharp/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)|Set all characters of string to specified character|Not applicable.|  
|[strspn, wcsspn, _mbsspn, _mbsspn_l](../VS_csharp/strspn--wcsspn--_mbsspn--_mbsspn_l.md)|Find first occurrence in a string of a character not found in another string|Not applicable.|  
|[strstr, wcsstr, _mbsstr, _mbsstr_l](../VS_csharp/strstr--wcsstr--_mbsstr--_mbsstr_l.md)|Find first occurrence of specified string in another string|[System::String::IndexOf](https://msdn.microsoft.com/en-us/library/system.string.indexof.aspx)|  
|[strtok, _strtok_l, wcstok, _wcstok_l, _mbstok, _mbstok_l](../VS_csharp/strtok--_strtok_l--wcstok--_wcstok_l--_mbstok--_mbstok_l.md), [strtok_s, _strtok_s_l, wcstok_s, _wcstok_s_l, _mbstok_s, _mbstok_s_l](../VS_csharp/strtok_s--_strtok_s_l--wcstok_s--_wcstok_s_l--_mbstok_s--_mbstok_s_l.md)|Find next token in string|Not applicable.|  
|[_strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr_l, _wcsupr](../VS_csharp/_strupr--_strupr_l--_mbsupr--_mbsupr_l--_wcsupr_l--_wcsupr.md), [_strupr_s, _strupr_s_l, _mbsupr_s, _mbsupr_s_l, _wcsupr_s, _wcsupr_s_l](../VS_csharp/_strupr_s--_strupr_s_l--_mbsupr_s--_mbsupr_s_l--_wcsupr_s--_wcsupr_s_l.md)|Convert string to uppercase|[System::String::ToUpper](https://msdn.microsoft.com/en-us/library/system.string.toupper.aspx)|  
|[strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../VS_csharp/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)|Transform string into collated form based on locale-specific information|Not applicable.|  
|[vsprintf, vswprintf](../VS_csharp/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md), [vsprintf_s, vswprintf_s](../VS_csharp/vsprintf_s--_vsprintf_s_l--vswprintf_s--_vswprintf_s_l.md), [_vsprintf_p, _vswprintf_p](../VS_csharp/_vsprintf_p--_vsprintf_p_l--_vswprintf_p--_vswprintf_p_l.md)|Write formatted output using a pointer to a list of arguments|[System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)|  
|[vsnprintf, _vsnprintf, _vsnwprintf](../VS_csharp/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md), [vsnprintf_s, _vsnprintf_s, _vsnwprintf_s](../VS_csharp/vsnprintf_s--_vsnprintf_s--_vsnprintf_s_l--_vsnwprintf_s--_vsnwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|[System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)|  
  
## See Also  
 [Run-Time Routines by Category](../VS_csharp/run-time-routines-by-category.md)