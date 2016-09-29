---
title: "Security-Enhanced Versions of CRT Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "security [CRT]"
  - "security-enhanced CRT"
  - "CRT, security enhancements"
ms.assetid: f87e5a01-4cb2-4379-9e8f-d4693828c55a
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Security-Enhanced Versions of CRT Functions
More secure versions of run-time library routines are available. For further information concerning Security Enhancements in the CRT, see [Security-Enhanced CRT Functions](../VS_csharp/security-features-in-the-crt.md).  
  
 **Secure Functions**  
  
|CRT Function|Security enhanced function|Use|  
|------------------|--------------------------------|---------|  
|[_access, _waccess](../VS_csharp/_access--_waccess.md)|[_access_s, _waccess_s](../VS_csharp/_access_s--_waccess_s.md)|Determine file-access permission|  
|[_alloca](../VS_csharp/_alloca.md)|[_malloca](../VS_csharp/_malloca.md)|Allocate memory on the stack|  
|[asctime, _wasctime](../VS_csharp/asctime--_wasctime.md)|[asctime_s, _wasctime_s](../VS_csharp/asctime_s--_wasctime_s.md)|Convert time from type `struct tm` to character string|  
|[bsearch](../VS_csharp/bsearch.md)|[bsearch_s](../VS_csharp/bsearch_s.md)|Perform a binary search of a sorted array|  
|Obsolete function|[_cgets_s, _cgetws_s](../VS_csharp/_cgets_s--_cgetws_s.md)|Get a character string from the console|  
|[_chsize](../VS_csharp/_chsize.md)|[_chsize_s](../VS_csharp/_chsize_s.md)|Change the size of a file|  
|[clearerr](../VS_csharp/clearerr.md)|[clearerr_s](../VS_csharp/clearerr_s.md)|Reset the error indicator for a stream|  
|[_control87, _controlfp, _control87_2](../VS_csharp/_control87--_controlfp--__control87_2.md)|[_controlfp_s](../VS_csharp/_controlfp_s.md)|Get and set the floating-point control word|  
|[_cprintf, _cwprintf](../VS_csharp/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)|[_cprintf_s, _cwprintf_s](../VS_csharp/_cprintf_s--_cprintf_s_l--_cwprintf_s--_cwprintf_s_l.md)|Format and print to the console|  
|[_cscanf, _cwscanf](../VS_csharp/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md)|[_cscanf_s, _cwscanf_s](../VS_csharp/_cscanf_s--_cscanf_s_l--_cwscanf_s--_cwscanf_s_l.md)|Read formatted data from the console|  
|[_ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../VS_csharp/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)|[_ctime_s, _ctime32_s, _ctime64_s, _wctime_s, _wctime32_s, _wctime64_s](../VS_csharp/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md)|Convert time from type `time_t`, `__time32_t` or `__time64_t` to character string|  
|[_ecvt](../VS_csharp/_ecvt.md)|[_ecvt_s](../VS_csharp/_ecvt_s.md)|Convert a `double` number to a string|  
|[_fcvt](../VS_csharp/_fcvt.md)|[_fcvt_s](../VS_csharp/_fcvt_s.md)|Converts a floating-point number to a string|  
|[fopen, _wfopen](../VS_csharp/fopen--_wfopen.md)|[fopen_s, _wfopen_s](../VS_csharp/fopen_s--_wfopen_s.md)|Open a file|  
|[fprintf, fwprintf](../VS_csharp/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)|[fprintf_s, fwprintf_s](../VS_csharp/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)|Print formatted data to a stream|  
|[fread](../VS_csharp/fread.md)|[fread_s](../VS_csharp/fread_s.md)|Read from a file|  
|[_fread_nolock](../VS_csharp/_fread_nolock.md)|[_fread_nolock_s](../VS_csharp/_fread_nolock_s.md)|Read from a file without using a multi-thread write lock|  
|[freopen, _wfreopen](../VS_csharp/freopen--_wfreopen.md)|[freopen_s, _wfreopen_s](../VS_csharp/freopen_s--_wfreopen_s.md)|Reopen the file|  
|[fscanf, fwscanf](../VS_csharp/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)|[fscanf_s, fwscanf_s](../VS_csharp/fscanf_s--_fscanf_s_l--fwscanf_s--_fwscanf_s_l.md)|Read formatted data from a stream|  
|[_ftime, _ftime32, _ftime64](../VS_csharp/_ftime--_ftime32--_ftime64.md)|[_ftime_s, _ftime32_s, _ftime64_s](../VS_csharp/_ftime_s--_ftime32_s--_ftime64_s.md)|Get the current time|  
|[_gcvt](../VS_csharp/_gcvt.md)|[_gcvt_s](../VS_csharp/_gcvt_s.md)|Convert a floating-point value to a string, and store it in a buffer|  
|[getenv, _wgetenv](../VS_csharp/getenv--_wgetenv.md)|[getenv_s, _wgetenv_s](../VS_csharp/getenv_s--_wgetenv_s.md)|Get a value from the current environment.|  
|Obsolete function|[gets_s, _getws_s](../VS_csharp/gets_s--_getws_s.md)|Get a line from the `stdin` stream|  
|[_gmtime32, _gmtime64](../VS_csharp/gmtime--_gmtime32--_gmtime64.md)|[_gmtime32_s, _gmtime64_s](../VS_csharp/gmtime_s--_gmtime32_s--_gmtime64_s.md)|Convert time from type `time_t` to `struct``tm` or from type `__time64_t` to `struct tm`|  
|[_itoa, _i64toa, _ui64toa, _itow, _i64tow, _ui64tow](../VS_csharp/_itoa--_i64toa--_ui64toa--_itow--_i64tow--_ui64tow.md)|[_itoa_s, _i64toa_s, _ui64toa_s, _itow_s, _i64tow_s, _ui64tow_s](../VS_csharp/_itoa_s--_i64toa_s--_ui64toa_s--_itow_s--_i64tow_s--_ui64tow_s.md)|Convert an integer to a string|  
|[_lfind](../VS_csharp/_lfind.md)|[_lfind_s](../VS_csharp/_lfind_s.md)|Perform a linear search for the specified key|  
|[_localtime32, _localtime64](../VS_csharp/localtime--_localtime32--_localtime64.md)|[_localtime32_s, _localtime64_s](../VS_csharp/localtime_s--_localtime32_s--_localtime64_s.md)|Convert time from type `time_t` to `struct tm` or from type `__time64_t` to `struct tm`with local correction|  
|[_lsearch](../VS_csharp/_lsearch.md)|[_lsearch_s](../VS_csharp/_lsearch_s.md)|Perform a linear search for a value; adds to end of list if not found|  
|[_ltoa, _ltow](../VS_csharp/_ltoa--_ltow.md)|[_ltoa_s, _ltow_s](../VS_csharp/_ltoa_s--_ltow_s.md)|Convert a long integer to a string|  
|[_makepath, _wmakepath](../VS_csharp/_makepath--_wmakepath.md)|[_makepath_s, _wmakepath_s](../VS_csharp/_makepath_s--_wmakepath_s.md)|Create a path name from components|  
|[_mbccpy, _mbccpy_l](../VS_csharp/_mbccpy--_mbccpy_l.md)|[_mbccpy_s, _mbccpy_s_l](../VS_csharp/_mbccpy_s--_mbccpy_s_l.md)|Copy a multibyte character from one string to another string|  
|[_mbsnbcat, _mbsnbcat_l](../VS_csharp/_mbsnbcat--_mbsnbcat_l.md)|[_mbsnbcat_s, _mbsnbcat_s_l](../VS_csharp/_mbsnbcat_s--_mbsnbcat_s_l.md)|Append, at most, the first `n` bytes of one multibyte character string to another|  
|[_mbsnbcpy, _mbsnbcpy_l](../VS_csharp/_mbsnbcpy--_mbsnbcpy_l.md)|[_mbsnbcpy_s, _mbsnbcpy_s_l](../VS_csharp/_mbsnbcpy_s--_mbsnbcpy_s_l.md)|Copy `n` bytes of a string to a destination string|  
|[_mbsnbset, _mbsnbset_l](../VS_csharp/_mbsnbset--_mbsnbset_l.md)|[_mbsnbset_s, _mbsnbset_s_l](../VS_csharp/_mbsnbset_s--_mbsnbset_s_l.md)|Set the first `n` bytes of a string to a specified character|  
|[mbsrtowcs](../VS_csharp/mbsrtowcs.md)|[mbsrtowcs_s](../VS_csharp/mbsrtowcs_s.md)|Convert a multibyte character string to a corresponding wide character string|  
|[mbstowcs, _mbstowcs_l](../VS_csharp/mbstowcs--_mbstowcs_l.md)|[mbstowcs_s, _mbstowcs_s_l](../VS_csharp/mbstowcs_s--_mbstowcs_s_l.md)|Convert a sequence of multibyte characters to a corresponding sequence of wide characters|  
|[memcpy, wmemcpy](../VS_csharp/memcpy--wmemcpy.md)|[memcpy_s, wmemcpy_s](../VS_csharp/memcpy_s--wmemcpy_s.md)|Copy characters between buffers|  
|[memmove, wmemmove](../VS_csharp/memmove--wmemmove.md)|[memmove_s, wmemmove_s](../VS_csharp/memmove_s--wmemmove_s.md)|Move one buffer to another|  
|[_mktemp, _wmktemp\_](../VS_csharp/_mktemp--_wmktemp.md)|[_mktemp_s, _wmktemp_s](../VS_csharp/_mktemp_s--_wmktemp_s.md)|Create a unique filename|  
|[printf, wprintf](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md)|[printf_s, wprintf_s](../VS_csharp/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)|Print formatted output to the standard output stream|  
|[putenv, _wputenv](../VS_csharp/_putenv--_wputenv.md)|[putenv_s, _wputenv_s](../VS_csharp/_putenv_s--_wputenv_s.md)|Create, modify, or remove environment variables|  
|[qsort](../VS_csharp/qsort.md)|[qsort_s](../VS_csharp/qsort_s.md)|Perform a quick sort|  
|[rand](../VS_csharp/rand.md)|[rand_s](../VS_csharp/rand_s.md)|Generate a pseudorandom number|  
|[scanf, wscanf](../VS_csharp/scanf--_scanf_l--wscanf--_wscanf_l.md)|[scanf_s, wscanf_s](../VS_csharp/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)|Read formatted data from the standard input stream|  
|[_searchenv, _wsearchenv](../VS_csharp/_searchenv--_wsearchenv.md)|[_searchenv_s, _wsearchenv_s](../VS_csharp/_searchenv_s--_wsearchenv_s.md)|Search for a file using environment paths|  
|[_snprintf, _snwprintf](../VS_csharp/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md)|[_snprintf_s, _snwprintf_s](../VS_csharp/_snprintf_s--_snprintf_s_l--_snwprintf_s--_snwprintf_s_l.md)|Write formatted data to a string|  
|[_snscanf, _snwscanf](../VS_csharp/_snscanf--_snscanf_l--_snwscanf--_snwscanf_l.md)|[_snscanf_s, _snwscanf_s](../VS_csharp/_snscanf_s--_snscanf_s_l--_snwscanf_s--_snwscanf_s_l.md)|Read formatted data of a specified length from a string.|  
|[_sopen, _wsopen](../VS_csharp/_sopen--_wsopen.md)|[_sopen_s, _wsopen_s](../VS_csharp/_sopen_s--_wsopen_s.md)|Open a file for sharing|  
|[splitpath, _wsplitpath](../VS_csharp/_splitpath--_wsplitpath.md)|[_splitpath_s, _wsplitpath_s](../VS_csharp/_splitpath_s--_wsplitpath_s.md)|Break a path name into components|  
|[sprintf, swprintf](../VS_csharp/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)|[sprintf_s, swprintf_s](../VS_csharp/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)|Write formatted data to a string|  
|[sscanf, swscanf](../VS_csharp/sscanf--_sscanf_l--swscanf--_swscanf_l.md)|[sscanf_s, swscanf_s](../VS_csharp/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)|Read formatted data from a string|  
|[strcat, wcscat, _mbscat](../VS_csharp/strcat--wcscat--_mbscat.md)|[strcat_s, wcscat_s, _mbscat_s](../VS_csharp/strcat_s--wcscat_s--_mbscat_s.md)|Append a string|  
|[strcpy, wcscpy, _mbscpy](../VS_csharp/strcpy--wcscpy--_mbscpy.md)|[strcpy_s, wcscpy_s, _mbscpy_s](../VS_csharp/strcpy_s--wcscpy_s--_mbscpy_s.md)|Copy a string|  
|[_strdate, _wstrdate](../VS_csharp/_strdate--_wstrdate.md)|[_strdate_s, _wstrdate_s](../VS_csharp/_strdate_s--_wstrdate_s.md)|Return current system date as string|  
|[strerror, _strerror, _wcserror, \__wcserror](../VS_csharp/strerror--_strerror--_wcserror--__wcserror.md)|[strerror_s, _strerror_s, _wcserror_s, \__wcserror_s](../VS_csharp/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md)|Get a system error message (`strerror`, `_wcserror`) or print a user-supplied error message (`_strerror`, `__wcserror`)|  
|[_strlwr, _strlwr_l, _mbslwr, _mbslwr_l, _wcslwr, _wcslwr_l](../VS_csharp/_strlwr--_wcslwr--_mbslwr--_strlwr_l--_wcslwr_l--_mbslwr_l.md)|[_strlwr_s, _strlwr_s_l, _mbslwr_s, _mbslwr_s_l, _wcslwr_s, _wcslwr_s_l](../VS_csharp/_strlwr_s--_strlwr_s_l--_mbslwr_s--_mbslwr_s_l--_wcslwr_s--_wcslwr_s_l.md)|Convert a string to lowercase|  
|[strncat, wcsncat, _mbsncat, _mbsncat_l](../VS_csharp/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)|[strncat_s, wcsncat_s, _mbsncat_s, _mbsncat_s_l](../VS_csharp/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)|Append characters to a string|  
|[strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../VS_csharp/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)|[strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l](../VS_csharp/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)|Copy characters of one string to another|  
|[_strnset, _strnset_l, _wcsnset, _wcsnset_l, _mbsnset, _mbsnset_l](../VS_csharp/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)|[_strnset_s, _strnset_s_l, _wcsnset_s, _wcsnset_s_l, _mbsnset_s, _mbsnset_s_l](../VS_csharp/_strnset_s--_strnset_s_l--_wcsnset_s--_wcsnset_s_l--_mbsnset_s--_mbsnset_s_l.md)|Set the first n characters of a string to the specified character|  
|[_strset, _strset_l, _wcsset, _wcsset_l, _mbsset, _mbsset_l](../VS_csharp/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)|[_strset_s, _strset_s_l, _wcsset_s, _wcsset_s_l, _mbsset_s, _mbsset_s_l](../VS_csharp/_strset_s--_strset_s_l--_wcsset_s--_wcsset_s_l--_mbsset_s--_mbsset_s_l.md)|Set all the characters of a string to the specified character|  
|[_strtime, _wstrtime](../VS_csharp/_strtime--_wstrtime.md)|[_strtime_s, _wstrtime_s](../VS_csharp/_strtime_s--_wstrtime_s.md)|Return current system time as string|  
|[strtok, _strtok_l, wcstok, _wcstok_l, _mbstok, _mbstok_l](../VS_csharp/strtok--_strtok_l--wcstok--_wcstok_l--_mbstok--_mbstok_l.md)|[strtok_s, _strtok_s_l, wcstok_s, _wcstok_s_l, _mbstok_s, _mbstok_s_l](../VS_csharp/strtok_s--_strtok_s_l--wcstok_s--_wcstok_s_l--_mbstok_s--_mbstok_s_l.md)|Find the next token in a string, using the current locale or a locale passed in|  
|[_strupr, _strupr_l, _mbsupr, _mbsupr_l, _wcsupr, _wcsupr_l](../VS_csharp/_strupr--_strupr_l--_mbsupr--_mbsupr_l--_wcsupr_l--_wcsupr.md)|[_strupr_s, _strupr_s_l, _mbsupr_s, _mbsupr_s_l, _wcsupr_s, _wcsupr_s_l](../VS_csharp/_strupr_s--_strupr_s_l--_mbsupr_s--_mbsupr_s_l--_wcsupr_s--_wcsupr_s_l.md)|Convert a string to uppercase|  
|[tmpfile](../VS_csharp/tmpfile.md)|[tmpfile_s](../VS_csharp/tmpfile_s.md)|Create a temporary file|  
|[tmpnam, _wtmpnam](../VS_csharp/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)|[tmpnam_s, _wtmpnam_s](../VS_csharp/tmpnam_s--_wtmpnam_s.md)|Generate names you can use to create temporary files|  
|[_ultoa, _ultow](../VS_csharp/_ultoa--_ultow.md)|[_ultoa_s, _ultow_s](../VS_csharp/_ultoa_s--_ultow_s.md)|Convert an unsigned long integer to a string|  
|[_umask](../VS_csharp/_umask.md)|[_umask_s](../VS_csharp/_umask_s.md)|Set the default file-permission mask|  
|[_vcprintf, _vcwprintf](../VS_csharp/_vcprintf--_vcprintf_l--_vcwprintf--_vcwprintf_l.md)|[_vcprintf_s, _vcwprintf_s](../VS_csharp/_vcprintf_s--_vcprintf_s_l--_vcwprintf_s--_vcwprintf_s_l.md)|Write formatted output to the console using a pointer to a list of arguments|  
|[vfprintf, vfwprintf](../VS_csharp/vfprintf--_vfprintf_l--vfwprintf--_vfwprintf_l.md)|[vfprintf_s, vfwprintf_s](../VS_csharp/vfprintf_s--_vfprintf_s_l--vfwprintf_s--_vfwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vfscanf, vfwscanf](../VS_csharp/vfscanf--vfwscanf.md)|[vfscanf_s, vfwscanf_s](../VS_csharp/vfscanf_s--vfwscanf_s.md)|Read formatted data from a stream|  
|[vprintf, vwprintf](../VS_csharp/vprintf--_vprintf_l--vwprintf--_vwprintf_l.md)|[vprintf_s, vwprintf_s](../VS_csharp/vprintf_s--_vprintf_s_l--vwprintf_s--_vwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vscanf, vwscanf](../VS_csharp/vscanf--vwscanf.md)|[vscanf_s, vwscanf_s](../VS_csharp/vscanf_s--vwscanf_s.md)|Read formatted data from the standard input stream|  
|[vsnprintf, _vsnprintf, _vsnwprintf](../VS_csharp/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md)|[vsnprintf_s, _vsnprintf_s, _vsnwprintf_s](../VS_csharp/vsnprintf_s--_vsnprintf_s--_vsnprintf_s_l--_vsnwprintf_s--_vsnwprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vsprintf, vswprintf](../VS_csharp/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md)|[vsprintf_s, vswprintf_s](../VS_csharp/vsprintf_s--_vsprintf_s_l--vswprintf_s--_vswprintf_s_l.md)|Write formatted output using a pointer to a list of arguments|  
|[vsscanf, vswscanf](../VS_csharp/vsscanf--vswscanf.md)|[vsscanf_s, vswscanf_s](../VS_csharp/vsscanf_s--vswscanf_s.md)|Read formatted data from a string|  
|[wcrtomb](../VS_csharp/wcrtomb.md)|[wcrtomb_s](../VS_csharp/wcrtomb_s.md)|Convert a wide character into its multibyte character representation|  
|[wcsrtombs](../VS_csharp/wcsrtombs.md)|[wcsrtombs_s](../VS_csharp/wcsrtombs_s.md)|Convert a wide character string to its multibyte character string representation|  
|[wcstombs, _wcstombs_l](../VS_csharp/wcstombs--_wcstombs_l.md)|[wcstombs_s, _wcstombs_s_l](../VS_csharp/wcstombs_s--_wcstombs_s_l.md)|Convert a sequence of wide characters to a corresponding sequence of multibyte characters|  
|[wctomb, _wctomb_l](../VS_csharp/wctomb--_wctomb_l.md)|[wctomb_s, _wctomb_s_l](../VS_csharp/wctomb_s--_wctomb_s_l.md)|Convert a wide character to the corresponding multibyte character|  
  
## See Also  
 [C Run-Time Libraries](../VS_csharp/crt-library-features.md)