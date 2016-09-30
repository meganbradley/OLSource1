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
These routines operate on null-terminated single-byte character, wide-character, and multibyte-character strings. Use the buffer-manipulation routines, described in [Buffer Manipulation](../vs140/buffer-manipulation.md), to work with character arrays that do not end with a null character.  
  
### String-Manipulation Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[strcoll, wcscoll, _mbscoll, _strcoll_l, _wcscoll_l, _mbscoll_l](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md), [_stricoll, _wcsicoll, _mbsicoll, _stricoll_l, _wcsicoll_l, _mbsicoll_l](../vs140/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md), [_strncoll, _wcsncoll, _mbsncoll, _strncoll_l, _wcsncoll_l, _mbsncoll_l](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md), [_strnicoll, _wcsnicoll, _mbsnicoll, _strnicoll_l, _wcsnicoll_l, _mbsnicoll_l](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|Compare two character strings using code page information (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are case-insensitive)|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[_mbsdec, _mbsdec_l, _strdec, _wcsdec](../vs140/_strdec--_wcsdec--_mbsdec--_mbsdec_l.md)|Move string pointer back one character|Not applicable. To call the standard C function, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_mbsinc, _mbsinc_l, _strinc, _wcsinc](../vs140/_strinc--_wcsinc--_mbsinc--_mbsinc_l.md)|Advance string pointer by one character|Not applicable.|  
|[_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md), [_mbsnbcat_s, _mbsnbcat_s_l](../vs140/_mbsnbcat_s--_mbsnbcat_s_l.md)|Append, at most, first <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> bytes of one character string to another|Not applicable.|  
|[_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)|Compare first <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> bytes of two character strings|Not applicable.|  
|[_mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l, _strncnt, _wcsncnt](../vs140/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)|Return number of character bytes within supplied character count|Not applicable.|  
|[_mbsnbcpy, _mbsnbcpy_l](../vs140/_mbsnbcpy--_mbsnbcpy_l.md), [_mbsnbcpy_s, _mbsnbcpy_s_l](../vs140/_mbsnbcpy_s--_mbsnbcpy_s_l.md)|Copy <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> bytes of string|Not applicable.|  
|[_mbsnbicmp, _mbsnbicmp_l](../vs140/_mbsnbicmp--_mbsnbicmp_l.md)|Compare <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> bytes of two character strings, ignoring case|Not applicable.|  
|[_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md)|Set first <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bytes of character string to specified character|Not applicable.|  
|[_mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l, _strncnt, _wcsncnt](../vs140/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)|Return number of characters within supplied byte count|Not applicable.|  
|[_mbsnextc, _mbsnextc_l, _strnextc, _wcsnextc](../vs140/_strnextc--_wcsnextc--_mbsnextc--_mbsnextc_l.md)|Find next character in string|Not applicable.|  
|[_mbsninc, _mbsninc_l, _strninc, _wcsninc](../vs140/_strninc--_wcsninc--_mbsninc--_mbsninc_l.md)|Advance string pointer by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> characters|Not applicable.|  
|[_mbsspnp, _mbsspnp_l, _strspnp, _wcsspnp](../vs140/_strspnp--_wcsspnp--_mbsspnp--_mbsspnp_l.md)|Return pointer to first character in given string that is not in another given string|Not applicable.|  
|[_scprintf, _scwprintf](../vs140/_scprintf--_scprintf_l--_scwprintf--_scwprintf_l.md)|Return the number of characters in a formatted string|Not applicable.|  
|[_snscanf, _snwscanf](../vs140/_snscanf--_snscanf_l--_snwscanf--_snwscanf_l.md), [_snscanf_s, _snwscanf_s](../vs140/_snscanf_s--_snscanf_s_l--_snwscanf_s--_snwscanf_s_l.md)|Read formatted data of a specified length from the standard input stream.|Not applicable.|  
|[sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md), [sscanf_s, swscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)|Read formatted data of a specified length from the standard input stream.|Not applicable.|  
|[sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md), [sprintf_s, swprintf_s](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md), [_sprintf_p, _swprintf_p](../vs140/_sprintf_p--_sprintf_p_l--_swprintf_p--_swprintf_p_l.md)|Write formatted data to a string|[System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)|  
|[strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md), [strcat_s, wcscat_s, _mbscat_s](../vs140/strcat_s--wcscat_s--_mbscat_s.md)|Append one string to another|[System::String::Concat](https://msdn.microsoft.com/en-us/library/system.string.concat.aspx)|  
|[strchr, wcschr, _mbschr, _mbschr_l](../vs140/strchr--wcschr--_mbschr--_mbschr_l.md)|Find first occurrence of specified character in string|[System::String::IndexOf](https://msdn.microsoft.com/en-us/library/system.string.indexof.aspx)|  
|[strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)|Compare two strings|[System::String::CompareOrdinal](https://msdn.microsoft.com/en-us/library/system.string.compareordinal.aspx)|  
|[strcoll, wcscoll, _mbscoll, _strcoll_l, _wcscoll_l, _mbscoll_l](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md), [_stricoll, _wcsicoll, _mbsicoll, _stricoll_l, _wcsicoll_l, _mbsicoll_l](../vs140/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md), [_strncoll, _wcsncoll, _mbsncoll, _strncoll_l, _wcsncoll_l, _mbsncoll_l](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md), [_strnicoll, _wcsnicoll, _mbsnicoll, _strnicoll_l, _wcsnicoll_l, _mbsnicoll_l](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|Compare two strings using current locale code page information (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are case-insensitive)|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md), [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md)|Copy one string to another|[System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)|  
|[strcspn, wcscspn, _mbscspn, _mbscspn_l](../vs140/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)|Find first occurrence of character from specified character set in string|[System::String::IndexOfAny](https://msdn.microsoft.com/en-us/library/system.string.indexofany.aspx)|  
|[_strdup, _wcsdup, _mbsdup](../vs140/_strdup--_wcsdup--_mbsdup.md), [_strdup_dbg, _wcsdup_dbg](../vs140/_strdup_dbg--_wcsdup_dbg.md)|Duplicate string|[System::String::Clone](https://msdn.microsoft.com/en-us/library/system.string.clone.aspx)|  
|[strerror, _strerror, _wcserror, \__wcserror](../vs140/strerror--_strerror--_wcserror--__wcserror.md), [strerror_s, _strerror_s, _wcserror_s, \__wcserror_s](../vs140/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md)|Map error number to message string|[System::Exception::Message](https://msdn.microsoft.com/en-us/library/system.exception.message.aspx)|  
|[strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md)|Format date-and-time string|[System::Convert::ToString](https://msdn.microsoft.com/en-us/library/system.convert.tostring.aspx)|  
|[_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l](../vs140/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md)|Compare two strings without regard to case|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[strlen, strlen_l, wcslen, wcslen_l, _mbslen, _mbslen_l, _mbstrlen, _mbstrlen_l](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md), [strnlen, strnlen_l, wcsnlen, wcsnlen_l, _mbsnlen, _mbsnlen_l, _mbstrnlen, _mbstrnlen_l](../vs140/strnlen--strnlen_s--wcsnlen--wcsnlen_s--_mbsnlen--_mbsnlen_l--_mbstrnlen--_mbstrnlen_l.md)|Find length of string|[System::String::Length](https://msdn.microsoft.com/en-us/library/system.string.length.aspx)|  
|[_strlwr, _wcslwr, _mbslwr, _strlwr_l, _wcslwr_l, _mbslwr_l](../vs140/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md), [_strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l](../vs140/_strlwr_s--_strlwr_s_l--_mbslwr_s--_mbslwr_s_l--_wcslwr_s--_wcslwr_s_l.md)|Convert string to lowercase|[System::String::ToLower](https://msdn.microsoft.com/en-us/library/system.string.tolower.aspx)|  
|[strncat, wcsncat, _mbsncat _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md), [strncat_s, wcsncat_s, _mbsncat_s, _mbsncat_s_l](../vs140/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)|Append characters of string|[System::String::Concat](https://msdn.microsoft.com/en-us/library/system.string.concat.aspx)|  
|[strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|Compare characters of two strings|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[strncpy, wcsncpy, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md), [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)|Copy characters of one string to another|[System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)|  
|[_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)|Compare characters of two strings without regard to case|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)|  
|[_strnset, _wcsnset, _mbsnset, _mbsnset_l](../vs140/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)|Set first <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> characters of string to specified character|[System::String::Replace](https://msdn.microsoft.com/en-us/library/system.string.replace.aspx)|  
|[strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l](../vs140/strpbrk--wcspbrk--_mbspbrk--_mbspbrk_l.md)|Find first occurrence of character from one string in another string|[System::String::IndexOfAny](https://msdn.microsoft.com/en-us/library/system.string.indexofany.aspx)|  
|[strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)|Find last occurrence of given character in string|[System::String::LastIndexOf](https://msdn.microsoft.com/en-us/library/system.string.lastindexof.aspx)|  
|[_strrev, _wcsrev, _mbsrev, _mbsrev_l](../vs140/_strrev--_wcsrev--_mbsrev--_mbsrev_l.md)|Reverse string|Not applicable.|  
|[_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)|Set all characters of string to specified character|Not applicable.|  
|[strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)|Find first occurrence in a string of a character not found in another string|Not applicable.|  
|[strstr, wcsstr, _mbsstr, _mbsstr_l](../vs140/strstr--wcsstr--_mbsstr--_mbsstr_l.md)|Find first occurrence of specified string in another string|[System::String::IndexOf](https://msdn.microsoft.com/en-us/library/system.string.indexof.aspx)|  
|[strtok, _strtok_l, wcstok, _wcstok_l, _mbstok, _mbstok_l](../vs140/strtok--_strtok_l--wcstok--_wcstok_l--_mbstok--_mbstok_l.md), [strtok_s, _strtok_s_l, wcstok_s, _wcstok_s_l, _mbstok_s, _mbstok_s_l](../vs140/strtok_s--_strtok_s_l--wcstok_s--_wcstok_s_l--_mbstok_s--_mbstok_s_l.md)|Find next token in string|Not applicable.|  
|[_strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr_l, _wcsupr](../vs140/_strupr--_strupr_l--_mbsupr--_mbsupr_l--_wcsupr_l--_wcsupr.md), [_strupr_s, _strupr_s_l, _mbsupr_s, _mbsupr_s_l, _wcsupr_s, _wcsupr_s_l](../vs140/_strupr_s--_strupr_s_l--_mbsupr_s--_mbsupr_s_l--_wcsupr_s--_wcsupr_s_l.md)|Convert string to uppercase|[System::String::ToUpper](https://msdn.microsoft.com/en-us/library/system.string.toupper.aspx)|  
|[strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)|Transform string into collated form based on locale-specific information|Not applicable.|  
|[vsprintf, vswprintf](../vs140/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md), [vsprintf_s, vswprintf_s](../vs140/vsprintf_s--_vsprintf_s_l--vswprintf_s--_vswprintf_s_l.md), [_vsprintf_p, _vswprintf_p](../vs140/_vsprintf_p--_vsprintf_p_l--_vswprintf_p--_vswprintf_p_l.md)|Write formatted output using a pointer to a list of arguments|[System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)|  
|[vsnprintf, _vsnprintf, _vsnwprintf](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md), [vsnprintf_s, _vsnprintf_s, _vsnwprintf_s](../vs140/vsnprintf_s--_vsnprintf_s--_vsnprintf_s_l--_vsnwprintf_s--_vsnwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|[System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)|  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)