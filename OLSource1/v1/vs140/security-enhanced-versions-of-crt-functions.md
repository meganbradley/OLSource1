---
title: "Security-Enhanced Versions of CRT Functions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - security [CRT]
  - security-enhanced CRT
  - CRT, security enhancements
ms.assetid: f87e5a01-4cb2-4379-9e8f-d4693828c55a
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Security-Enhanced Versions of CRT Functions
More secure versions of run-time library routines are available. For further information concerning Security Enhancements in the CRT, see [Security-Enhanced CRT Functions](../vs140/security-features-in-the-crt.md).  
  
 **Secure Functions**  
  
|CRT Function|Security enhanced function|Use|  
|------------------|--------------------------------|---------|  
|[_access, _waccess](../vs140/_access--_waccess.md)|[_access_s, _waccess_s](../vs140/_access_s--_waccess_s.md)|Determine file-access permission|  
|[_alloca](../vs140/_alloca.md)|[_malloca](../vs140/_malloca.md)|Allocate memory on the stack|  
|[asctime, _wasctime](../vs140/asctime--_wasctime.md)|[asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)|Convert time from type `struct tm` to character string|  
|[bsearch](../vs140/bsearch.md)|[bsearch_s](../vs140/bsearch_s.md)|Perform a binary search of a sorted array|  
|Obsolete function|[_cgets_s, _cgetws_s](../vs140/_cgets_s--_cgetws_s.md)|Get a character string from the console|  
|[_chsize](../vs140/_chsize.md)|[_chsize_s](../vs140/_chsize_s.md)|Change the size of a file|  
|[clearerr](../vs140/clearerr.md)|[clearerr_s](../vs140/clearerr_s.md)|Reset the error indicator for a stream|  
|[_control87, _controlfp, _control87_2](../vs140/_control87--_controlfp--__control87_2.md)|[_controlfp_s](../vs140/_controlfp_s.md)|Get and set the floating-point control word|  
|[_cprintf, _cwprintf](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)|[_cprintf_s, _cwprintf_s](../vs140/_cprintf_s--_cprintf_s_l--_cwprintf_s--_cwprintf_s_l.md)|Format and print to the console|  
|[_cscanf, _cwscanf](../vs140/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md)|[_cscanf_s, _cwscanf_s](../vs140/_cscanf_s--_cscanf_s_l--_cwscanf_s--_cwscanf_s_l.md)|Read formatted data from the console|  
|[_ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)|[_ctime_s, _ctime32_s, _ctime64_s, _wctime_s, _wctime32_s, _wctime64_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md)|Convert time from type `time_t`, `__time32_t` or `__time64_t` to character string|  
|[_ecvt](../vs140/_ecvt.md)|[_ecvt_s](../vs140/_ecvt_s.md)|Convert a `double` number to a string|  
|[_fcvt](../vs140/_fcvt.md)|[_fcvt_s](../vs140/_fcvt_s.md)|Converts a floating-point number to a string|  
|[fopen, _wfopen](../vs140/fopen--_wfopen.md)|[fopen_s, _wfopen_s](../vs140/fopen_s--_wfopen_s.md)|Open a file|  
|[fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)|[fprintf_s, fwprintf_s](../vs140/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)|Print formatted data to a stream|  
|[fread](../vs140/fread.md)|[fread_s](../vs140/fread_s.md)|Read from a file|  
|[_fread_nolock](../vs140/_fread_nolock.md)|[_fread_nolock_s](../vs140/_fread_nolock_s.md)|Read from a file without using a multi-thread write lock|  
|[freopen, _wfreopen](../vs140/freopen--_wfreopen.md)|[freopen_s, _wfreopen_s](../vs140/freopen_s--_wfreopen_s.md)|Reopen the file|  
|[fscanf, fwscanf](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)|[fscanf_s, fwscanf_s](../vs140/fscanf_s--_fscanf_s_l--fwscanf_s--_fwscanf_s_l.md)|Read formatted data from a stream|  
|[_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)|[_ftime_s, _ftime32_s, _ftime64_s](../vs140/_ftime_s--_ftime32_s--_ftime64_s.md)|Get the current time|  
|[_gcvt](../vs140/_gcvt.md)|[_gcvt_s](../vs140/_gcvt_s.md)|Convert a floating-point value to a string, and store it in a buffer|  
|[getenv, _wgetenv](../vs140/getenv--_wgetenv.md)|[getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md)|Get a value from the current environment.|  
|Obsolete function|[gets_s, _getws_s](../vs140/gets_s--_getws_s.md)|Get a line from the `stdin` stream|  
|[_gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)|[_gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)|Convert time from type `time_t` to `struct``tm` or from type `__time64_t` to `struct tm`|  
|[_itoa, _i64toa, _ui64toa, _itow, _i64tow, _ui64tow](../vs140/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md)|[_itoa_s, _i64toa_s, _ui64toa_s, _itow_s, _i64tow_s, _ui64tow_s](../vs140/_itoa_s--_i64toa_s--_ui64toa_s--_itow_s--_i64tow_s--_ui64tow_s.md)|Convert an integer to a string|  
|[_lfind](../vs140/_lfind.md)|[_lfind_s](../vs140/_lfind_s.md)|Perform a linear search for the specified key|  
|[_localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)|[_localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)|Convert time from type `time_t` to `struct tm` or from type `__time64_t` to `struct tm`with local correction|  
|[_lsearch](../vs140/_lsearch.md)|[_lsearch_s](../vs140/_lsearch_s.md)|Perform a linear search for a value; adds to end of list if not found|  
|[_ltoa, _ltow](../vs140/_ltoa--_ltow.md)|[_ltoa_s, _ltow_s](../vs140/_ltoa_s--_ltow_s.md)|Convert a long integer to a string|  
|[_makepath, _wmakepath](../vs140/_makepath--_wmakepath.md)|[_makepath_s, _wmakepath_s](../vs140/_makepath_s--_wmakepath_s.md)|Create a path name from components|  
|[_mbccpy, _mbccpy_l](../vs140/_mbccpy--_mbccpy_l.md)|[_mbccpy_s, _mbccpy_s_l](../vs140/_mbccpy_s--_mbccpy_s_l.md)|Copy a multibyte character from one string to another string|  
|[_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)|[_mbsnbcat_s, _mbsnbcat_s_l](../vs140/_mbsnbcat_s--_mbsnbcat_s_l.md)|Append, at most, the first `n` bytes of one multibyte character string to another|  
|[_mbsnbcpy, _mbsnbcpy_l](../vs140/_mbsnbcpy--_mbsnbcpy_l.md)|[_mbsnbcpy_s, _mbsnbcpy_s_l](../vs140/_mbsnbcpy_s--_mbsnbcpy_s_l.md)|Copy `n` bytes of a string to a destination string|  
|[_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md)|[_mbsnbset_s, _mbsnbset_s_l](../vs140/_mbsnbset_s--_mbsnbset_s_l.md)|Set the first `n` bytes of a string to a specified character|  
|[mbsrtowcs](../vs140/mbsrtowcs.md)|[mbsrtowcs_s](../vs140/mbsrtowcs_s.md)|Convert a multibyte character string to a corresponding wide character string|  
|[mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)|[mbstowcs_s, _mbstowcs_s_l](../vs140/mbstowcs_s--_mbstowcs_s_l.md)|Convert a sequence of multibyte characters to a corresponding sequence of wide characters|  
|[memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md)|[memcpy_s, wmemcpy_s](../vs140/memcpy_s--wmemcpy_s.md)|Copy characters between buffers|  
|[memmove, wmemmove](../vs140/memmove--wmemmove.md)|[memmove_s, wmemmove_s](../vs140/memmove_s--wmemmove_s.md)|Move one buffer to another|  
|[_mktemp, _wmktemp\_](../vs140/_mktemp--_wmktemp.md)|[_mktemp_s, _wmktemp_s](../vs140/_mktemp_s--_wmktemp_s.md)|Create a unique filename|  
|[printf, wprintf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)|[printf_s, wprintf_s](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)|Print formatted output to the standard output stream|  
|[putenv, _wputenv](../vs140/_putenv--_wputenv.md)|[putenv_s, _wputenv_s](../vs140/_putenv_s--_wputenv_s.md)|Create, modify, or remove environment variables|  
|[qsort](../vs140/qsort.md)|[qsort_s](../vs140/qsort_s.md)|Perform a quick sort|  
|[rand](../vs140/rand.md)|[rand_s](../vs140/rand_s.md)|Generate a pseudorandom number|  
|[scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)|[scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)|Read formatted data from the standard input stream|  
|[_searchenv, _wsearchenv](../vs140/_searchenv--_wsearchenv.md)|[_searchenv_s, _wsearchenv_s](../vs140/_searchenv_s--_wsearchenv_s.md)|Search for a file using environment paths|  
|[_snprintf, _snwprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md)|[_snprintf_s, _snwprintf_s](../vs140/_snprintf_s--_snprintf_s_l--_snwprintf_s--_snwprintf_s_l.md)|Write formatted data to a string|  
|[_snscanf, _snwscanf](../vs140/_snscanf--_snscanf_l--_snwscanf--_snwscanf_l.md)|[_snscanf_s, _snwscanf_s](../vs140/_snscanf_s--_snscanf_s_l--_snwscanf_s--_snwscanf_s_l.md)|Read formatted data of a specified length from a string.|  
|[_sopen, _wsopen](../vs140/_sopen--_wsopen.md)|[_sopen_s, _wsopen_s](../vs140/_sopen_s--_wsopen_s.md)|Open a file for sharing|  
|[splitpath, _wsplitpath](../vs140/_splitpath--_wsplitpath.md)|[_splitpath_s, _wsplitpath_s](../vs140/_splitpath_s--_wsplitpath_s.md)|Break a path name into components|  
|[sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)|[sprintf_s, swprintf_s](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)|Write formatted data to a string|  
|[sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)|[sscanf_s, swscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)|Read formatted data from a string|  
|[strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)|[strcat_s, wcscat_s, _mbscat_s](../vs140/strcat_s--wcscat_s--_mbscat_s.md)|Append a string|  
|[strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)|[strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md)|Copy a string|  
|[_strdate, _wstrdate](../vs140/_strdate--_wstrdate.md)|[_strdate_s, _wstrdate_s](../vs140/_strdate_s--_wstrdate_s.md)|Return current system date as string|  
|[strerror, _strerror, _wcserror, \__wcserror](../vs140/strerror--_strerror--_wcserror--__wcserror.md)|[strerror_s, _strerror_s, _wcserror_s, \__wcserror_s](../vs140/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md)|Get a system error message (`strerror`, `_wcserror`) or print a user-supplied error message (`_strerror`, `__wcserror`)|  
|[_strlwr, _strlwr_l, _mbslwr, _mbslwr_l, _wcslwr, _wcslwr_l](../vs140/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md)|[_strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l](../vs140/_strlwr_s--_strlwr_s_l--_mbslwr_s--_mbslwr_s_l--_wcslwr_s--_wcslwr_s_l.md)|Convert a string to lowercase|  
|[strncat, wcsncat, _mbsncat, _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)|[strncat_s, wcsncat_s, _mbsncat_s, _mbsncat_s_l](../vs140/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)|Append characters to a string|  
|[strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)|[strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)|Copy characters of one string to another|  
|[_strnset, _strnset_l, _wcsnset, _wcsnset_l, _mbsnset, _mbsnset_l](../vs140/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)|[_strnset_s, _strnset_s_l, _wcsnset_s, _wcsnset_s_l, _mbsnset_s, _mbsnset_s_l](../vs140/_strnset_s--_strnset_s_l--_wcsnset_s--_wcsnset_s_l--_mbsnset_s--_mbsnset_s_l.md)|Set the first n characters of a string to the specified character|  
|[_strset, _strset_l, _wcsset, _wcsset_l, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)|[_strset_s, _strset_s_l, _wcsset_s, _wcsset_s_l, _mbsset_s, _mbsset_s_l](../vs140/_strset_s--_strset_s_l--_wcsset_s--_wcsset_s_l--_mbsset_s--_mbsset_s_l.md)|Set all the characters of a string to the specified character|  
|[_strtime, _wstrtime](../vs140/_strtime--_wstrtime.md)|[_strtime_s, _wstrtime_s](../vs140/_strtime_s--_wstrtime_s.md)|Return current system time as string|  
|[strtok, _strtok_l, wcstok, _wcstok_l, _mbstok, _mbstok_l](../vs140/strtok--_strtok_l--wcstok--_wcstok_l--_mbstok--_mbstok_l.md)|[strtok_s, _strtok_s_l, wcstok_s, _wcstok_s_l, _mbstok_s, _mbstok_s_l](../vs140/strtok_s--_strtok_s_l--wcstok_s--_wcstok_s_l--_mbstok_s--_mbstok_s_l.md)|Find the next token in a string, using the current locale or a locale passed in|  
|[_strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr, _wcsupr_l](../vs140/_strupr--_strupr_l--_mbsupr--_mbsupr_l--_wcsupr_l--_wcsupr.md)|[_strupr_s, _strupr_s_l, _mbsupr_s, _mbsupr_s_l, _wcsupr_s, _wcsupr_s_l](../vs140/_strupr_s--_strupr_s_l--_mbsupr_s--_mbsupr_s_l--_wcsupr_s--_wcsupr_s_l.md)|Convert a string to uppercase|  
|[tmpfile](../vs140/tmpfile.md)|[tmpfile_s](../vs140/tmpfile_s.md)|Create a temporary file|  
|[tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)|[tmpnam_s, _wtmpnam_s](../vs140/tmpnam_s--_wtmpnam_s.md)|Generate names you can use to create temporary files|  
|[_ultoa, _ultow](../vs140/_ultoa--_ultow.md)|[_ultoa_s, _ultow_s](../vs140/_ultoa_s--_ultow_s.md)|Convert an unsigned long integer to a string|  
|[_umask](../vs140/_umask.md)|[_umask_s](../vs140/_umask_s.md)|Set the default file-permission mask|  
|[_vcprintf, _vcwprintf](../vs140/_vcprintf--_vcprintf_l--_vcwprintf--_vcwprintf_l.md)|[_vcprintf_s, _vcwprintf_s](../vs140/_vcprintf_s--_vcprintf_s_l--_vcwprintf_s--_vcwprintf_s_l.md)|Write formatted output to the console using a pointer to a list of arguments|  
|[vfprintf, vfwprintf](../vs140/vfprintf--_vfprintf_l--vfwprintf--_vfwprintf_l.md)|[vfprintf_s, vfwprintf_s](../vs140/vfprintf_s--_vfprintf_s_l--vfwprintf_s--_vfwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vfscanf, vfwscanf](../vs140/vfscanf--vfwscanf.md)|[vfscanf_s, vfwscanf_s](../vs140/vfscanf_s--vfwscanf_s.md)|Read formatted data from a stream|  
|[vprintf, vwprintf](../vs140/vprintf--_vprintf_l--vwprintf--_vwprintf_l.md)|[vprintf_s, vwprintf_s](../vs140/vprintf_s--_vprintf_s_l--vwprintf_s--_vwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vscanf, vwscanf](../vs140/vscanf--vwscanf.md)|[vscanf_s, vwscanf_s](../vs140/vscanf_s--vwscanf_s.md)|Read formatted data from the standard input stream|  
|[vsnprintf, _vsnprintf, _vsnwprintf](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md)|[vsnprintf_s, _vsnprintf_s, _vsnwprintf_s](../vs140/vsnprintf_s--_vsnprintf_s--_vsnprintf_s_l--_vsnwprintf_s--_vsnwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vsprintf, vswprintf](../vs140/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md)|[vsprintf_s, vswprintf_s](../vs140/vsprintf_s--_vsprintf_s_l--vswprintf_s--_vswprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vsscanf, vswscanf](../vs140/vsscanf--vswscanf.md)|[vsscanf_s, vswscanf_s](../vs140/vsscanf_s--vswscanf_s.md)|Read formatted data from a string|  
|[wcrtomb](../vs140/wcrtomb.md)|[wcrtomb_s](../vs140/wcrtomb_s.md)|Convert a wide character into its multibyte character representation|  
|[wcsrtombs](../vs140/wcsrtombs.md)|[wcsrtombs_s](../vs140/wcsrtombs_s.md)|Convert a wide character string to its multibyte character string representation|  
|[wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)|[wcstombs_s, _wcstombs_s_l](../vs140/wcstombs_s--_wcstombs_s_l.md)|Convert a sequence of wide characters to a corresponding sequence of multibyte characters|  
|[wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)|[wctomb_s, _wctomb_s_l](../vs140/wctomb_s--_wctomb_s_l.md)|Convert a wide character to the corresponding multibyte character|  
  
## See Also  
 [C Run-Time Libraries](../vs140/crt-library-features.md)