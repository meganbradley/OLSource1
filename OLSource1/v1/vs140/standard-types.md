---
title: "Standard Types"
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
  - "__time64_t"
  - "_diskfree_t"
  - "_CRT_DUMP_CLIENT"
  - "_fsize_t"
  - "__timeb64"
  - "File"
  - "__utimeb64"
  - "jmp_buf"
  - "__finddata64_t"
  - "_wfinddata_t"
  - "_finddata_t"
  - "utimbuf64"
  - "wint_t"
  - "wctrans_t"
  - "wctype_t"
  - "_HFILE"
  - "_secerr_handler_func"
  - "clock_t"
  - "fpos_t"
  - "_dev_t"
  - "time64_t"
  - "wfinddata64_t"
  - "stat64"
  - "ldiv_t"
  - "_EXCEPTION_POINTERS"
  - "terminate_function"
  - "size_t"
  - "timeb64"
  - "tm"
  - "_HEAPINFO"
  - "unexpected_function"
  - "_CrtMemState"
  - "_se_translator_function"
  - "sig_atomic_t"
  - "_CRT_REPORT_HOOK"
  - "_complex"
  - "_w_finddatai64_t"
  - "_timeb"
  - "_onexit_t"
  - "_RTC_ErrorNumber"
  - "lconv"
  - "_PNH"
  - "_off_t"
  - "ptrdiff_t"
  - "time_t"
  - "_FPIEEE_RECORD"
  - "_exception"
  - "__w_finddata64_t"
  - "__stat64"
  - "_utimbuf"
  - "__utimbuf64"
  - "div_t"
  - "_CRT_ALLOC_HOOK"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__timeb64 type"
  - "tm type"
  - "clock_t type"
  - "intptr_t type"
  - "diskfree_t type"
  - "wctype_t type"
  - "CRT_DUMP_CLIENT type"
  - "sig_atomic_t type"
  - "_PNH type"
  - "time_t type"
  - "wfinddata_t type"
  - "timeb64"
  - "CRT, standard types"
  - "wint_t type"
  - "_RTC_ErrorNumber type"
  - "_diskfree_t type"
  - "_dev_t type"
  - "_wfinddata_t type"
  - "HFILE type"
  - "__utimbuf64 type"
  - "div_t type"
  - "_onexit_t type"
  - "_secerr_handler_func type"
  - "FPIEEE_RECORD type"
  - "HEAPINFO type"
  - "PNH type"
  - "_CRT_ALLOC_HOOK type"
  - "_se_translater_function type"
  - "va_list type"
  - "wctrans_t type"
  - "secerr_handler_func type"
  - "_locale_t type"
  - "timeb type"
  - "lconv type"
  - "utimbuf type"
  - "dev_t type"
  - "unexpected_function typedef"
  - "_complex type"
  - "_off_t type"
  - "off_t type"
  - "RTC_ErrorNumber type"
  - "_FPIEEE_RECORD type"
  - "exception type"
  - "_CRT_REPORT_HOOK type"
  - "_HEAPINFO type"
  - "ldiv_t type"
  - "terminate_function type"
  - "uintptr_t type"
  - "_CRT_DUMP_CLIENT type"
  - "_utimbuf type"
  - "wfinddatai64_t type"
  - "fpos_t type"
  - "wchar_t type"
  - "CRT_ALLOC_HOOK type"
  - "_HFILE type"
  - "__time64_t type"
  - "_timeb type"
  - "CrtMemState type"
  - "__finddata64_t type"
  - "_exception type"
  - "stat type"
  - "onexit_t type"
  - "FILE constant"
  - "_stat type"
  - "finddata_t type"
  - "__wfinddata64_t type"
  - "ptrdiff_t type"
  - "complex types"
  - "_wfinddatai64_t type"
  - "_EXCEPTION_POINTERS type"
  - "jmp_buf type"
  - "se_translater_function type"
  - "size_t type"
  - "EXCEPTION_POINTERS type"
  - "__stat64 type"
  - "_fsize_t type"
  - "CRT_REPORT_HOOK type"
  - "_finddata_t type"
ms.assetid: 23312dd2-4a6a-4d70-9b48-2a5d0d8c9f28
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Standard Types
The Microsoft run-time library defines the following standard types and typedefs.  
  
### Fixed-width integral types (stdint.h)  
  
|Name|Equivalent built-in type|  
|----------|-------------------------------|  
|int8_t, uint8_t|signed char, unsigned char|  
|int16_t, int16_t|short, unsigned short|  
|int32_t, uint32_t|int, unsigned int|  
|int64_t, int64_t|long long, unsigned long long|  
|int_least8_t, uint_least8_t|signed char, unsigned char|  
|int_least16_t, uint_least16_t|short, unsigned short|  
|int_least32_t, uint_least32_t|int, unsigned int|  
|int_least64_t, uint_least64_t|long long, unsigned long long|  
|int_fast8_t, uint_fast8_t|signed char, unsigned char|  
|int_fast16_t, uint_fast16_t|int, unsigned int|  
|int_fast32_t, uint_fast32_t|int, unsigned int|  
|int_fast64_t, uint_fast64_t|long long, unsigned long long|  
|intmax_t, uintmax_t|long long, unsigned long long|  
  
|Type|Description|Declared in|  
|----------|-----------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> (long)|Stores time values; used by [clock](../vs140/clock.md).|TIME.H|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure|Stores real and imaginary parts of complex numbers; used by [_cabs](../vs140/_cabs.md).|MATH.H|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A type define for the user-defined hook function. Used in [_CrtSetAllocHook](../vs140/_crtsetallochook.md).|CRTDBG.H|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>,\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A type define for a call-back function that will get called in [_CrtMemDumpAllObjectsSince](../vs140/_crtmemdumpallobjectssince.md).|CRTDBG.H|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure|Provides information about the current state of the C run-time debug heap.|CRTDBG.H|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>,\<br />\<br /> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>,\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|A type define for a call-back function that will get called in [_CrtDbgReport](../vs140/_crtdbgreport--_crtdbgreportw.md).\<br />\<br /> The parameters for this function are: report type, output message and the return value from the call-back function.|CRTDBG.H|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> short or unsigned integer|Represents device handles.|SYS\TYPES.H|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure|Contains information about a disk drive. Used by [_getdiskfree](../vs140/_getdiskfree.md)**.**|DOS.H and DIRECT.H|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structures|Store values returned by [div](../vs140/div.md), [ldiv](../vs140/ldiv--lldiv.md), and [lldiv](../vs140/ldiv--lldiv.md), respectively.|STDLIB.H|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> integer|Used for a function return type or parameter that deals with the error codes of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|STDDEF.H,\<br />\<br /> CRTDEFS.H|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> structure|Stores error information for [_matherr](../vs140/_matherr.md).|MATH.H|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Contains an exception record. See [EXCEPTION_POINTERS](http://msdn.microsoft.com/library/windows/desktop/ms679331) for more information.|FPIEEE.H|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> structure|Stores information about current state of stream; used in all stream I/O operations.|STDIO.H|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structures|Store file-attribute information returned by [_findfirst, _wfindfirst, and related functions](../vs140/9bb46d1a-b946-47de-845a-a0b109a33ead.md) and [_findnext, _wfindnext and related functions](../vs140/75d97188-5add-4698-a46c-4c492378f0f8.md). See [_find, _wfind Functions](../vs140/filename-search-functions.md) for information on structure members.|IO.H, WCHAR.H|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> structure|Contains information pertaining to IEEE floating-point exception; passed to user-defined trap handler by [_fpieee_flt](../vs140/_fpieee_flt.md).|FPIEEE.H|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> (long integer, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or structure, depending on the target platform)|Used by [fgetpos](../vs140/fgetpos.md) and [fsetpos](../vs140/fsetpos.md) to record information for uniquely specifying every position within a file.|STDIO.H|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (unsigned long integer)|Used to represent the size of a file.|IO.H,\<br />\<br /> WCHAR.H|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> structure|Contains information about next heap entry for [_heapwalk](../vs140/_heapwalk.md).|MALLOC.H|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> (void *)|An operating system file handle.|CRTDBG.H|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|The type of value that's returned by the [imaxdiv](../vs140/imaxdiv.md) function, containing both the quotient and the remainder.|inttypes.h|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> (unsigned short)|For returning status information.|WCHAR.H|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|A signed integer type capable of representing any value of any signed integer type.|stdint.h|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> (long integer or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, depending on the target platform)|Stores a pointer (or HANDLE) on both Win32 and Win64 platforms.|STDDEF.H and other include files|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> array|Used by [setjmp](../vs140/setjmp.md) and [longjmp](../vs140/longjmp.md) to save and restore program environment.|SETJMP.H|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> structure|Contains formatting rules for numeric values in different countries/regions. Used by [localeconv](../vs140/localeconv.md).|LOCALE.H|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>,\<br />\<br /> <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>,\<br />\<br /> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> (long double or an unsigned char array)|Use to represent a long double value.|STDLIB.H|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> structure|Stores current locale values; used in all locale specific C run-time libraries.|CRTDEF.H|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Tracks the state of a multibyte character conversion.|WCHAR.H|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> long integer|Represents file-offset value.|WCHAR.H, SYS\TYPES.H|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>,\<br />\<br /> <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> pointer|Returned by [_onexit, _onexit_m](../vs140/_onexit--_onexit_m.md).|STDLIB.H|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder> pointer to function|Type of argument to [_set_new_handler](../vs140/_set_new_handler.md).|NEW.H|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder> (long integer or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, depending on the target platform)|Result of subtraction of two pointers.|CRTDEFS.H|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>,\<br />\<br /> <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|A type define for a call-back function that is called when a pure virtual function is called. Used by [_set_purecall_handler, _set_purecall_handler_m](../vs140/_get_purecall_handler--_set_purecall_handler.md). A <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> function should have a void return type.|STDLIB.H|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder> type define|A type define for a function that will handle run-time error checks. Used in [_RTC_SetErrorFunc](../vs140/_rtc_seterrorfunc.md).|RTCAPI.H|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder> type define|A type define for a function that will handle run-time error checks. Used in [_RTC_SetErrorFuncW](../vs140/_rtc_seterrorfuncw.md).|RTCAPI.H|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder> enumeration|Defines error conditions for [_RTC_GetErrDesc](../vs140/_rtc_geterrdesc.md) and [_RTC_SetErrorType](../vs140/_rtc_seterrortype.md).|RTCAPI.H|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|A type define for a call-back function that translates an exception. The first parameter is the exception code and the second parameter is the exception record. Used by [_set_se_translator](../vs140/_set_se_translator.md).|EH.H|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder> integer|Type of object that can be modified as atomic entity, even in presence of asynchronous interrupts; used with [signal](../vs140/signal.md).|SIGNAL.H|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder> (unsigned __int64 or unsigned integer, depending on the target platform)|Result of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> operator.|CRTDEFS.H and other include files|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder> structure|Contains file-status information returned by [_stat](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md) and [_fstat](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md).|SYS\STAT.H|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder> structure|Contains file-status information returned by [_fstat64](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md) and [_stat64](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md), and [_wstat64](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md).|SYS\STAT.H|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder> structure|Contains file-status information returned by [_fstati64](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md), [_stati64](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md), and [_wstati64](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md).|SYS\STAT.H|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder> type define|A type define for a call-back function that is called when [terminate](../vs140/terminate--crt-.md) is called. Used by [set_terminate](../vs140/set_terminate--crt-.md).|EH.H|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder> (__int64 or long integer)|Represents time values in [mktime](../vs140/mktime--_mktime32--_mktime64.md), [time](../vs140/time--_time32--_time64.md), [ctime](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md), [ctime_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md), [_wctime](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md) and [gmtime](../vs140/gmtime--_gmtime32--_gmtime64.md). The number of seconds since January 1, 1970, 0:00 UTC. If _USE_32BIT_TIME_T is defined, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is a long integer. If not defined, it is a 64-bit integer.|TIME.H,\<br />\<br /> SYS\STAT.H,\<br />\<br /> SYS\TIMEB.H|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder> (long integer)|Represents time values in [_mktime32](../vs140/mktime--_mktime32--_mktime64.md), [ctime32](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md), [_ctime32_s, _wctime32_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md), [_gmtime32](../vs140/gmtime--_gmtime32--_gmtime64.md) and [_localtime32](../vs140/localtime--_localtime32--_localtime64.md).|CRTDEFS.H, SYS\STAT.H,\<br />\<br /> SYS\TIMEB.H|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>)|Represents time values in [_mktime64](../vs140/mktime--_mktime32--_mktime64.md), [_ctime64, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md), [ctime64_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md), [_gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md), [_localtime64](../vs140/localtime--_localtime32--_localtime64.md) and [_time64](../vs140/time--_time32--_time64.md).|TIME.H,\<br />\<br /> SYS\STAT.H,\<br />\<br /> SYS\TIMEB.H|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder> structure|Used by [_ftime](../vs140/_ftime--_ftime32--_ftime64.md) and [_ftime_s](../vs140/_ftime_s--_ftime32_s--_ftime64_s.md) to store current system time.|SYS\TIMEB.H|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder> structure|Used by [_ftime32](../vs140/_ftime--_ftime32--_ftime64.md) and [_ftime32_s](../vs140/_ftime_s--_ftime32_s--_ftime64_s.md) to store current system time.|SYS\TIMEB.H|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder> structure|Used by [_ftime64](../vs140/_ftime--_ftime32--_ftime64.md) and [_ftime64_s](../vs140/_ftime_s--_ftime32_s--_ftime64_s.md) to store current system time.|SYS\TIMEB.H|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder> structure|Used by [asctime, _wasctime](../vs140/asctime--_wasctime.md), [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md), [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md), [_gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md), [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md), [_localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md), [mktime, _mktime32, _mktime64](../vs140/mktime--_mktime32--_mktime64.md) and [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) to store and retrieve time information.|TIME.H|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|An unsigned integer type capable of representing any value of any unsigned integer type.|stdint.h|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder> (long integer or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, depending on the target platform)|An unsigned integer or unsigned __int64 version of <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.|STDDEF.H and other include files|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|A type define for a call-back function that is called when [unexpected](../vs140/unexpected--crt-.md) is called. Used by [set_unexpected](../vs140/set_unexpected--crt-.md).|EH.H|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder> structure|Stores file access and modification times used by [_utime, _wutime](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md) and [_futime](../vs140/_futime--_futime32--_futime64.md) to change file-modification dates.|SYS\UTIME.H|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder> structure|Stores file access and modification times used by [_utime32, _wutime32](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md) and [_futime32](../vs140/_futime--_futime32--_futime64.md) to change file-modification dates.|SYS\UTIME.H|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder> structure|Used by [_utime64, _wutime64](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md) and [_futime64](../vs140/_futime--_futime32--_futime64.md) to store the current time.|SYS\UTIME.H|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder> structure|Used to hold information needed by [va_arg](../vs140/va_arg--va_copy--va_end--va_start.md) and [va_end](../vs140/va_arg--va_copy--va_end--va_start.md) macros. Called function declares variable of type <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> that can be passed as argument to another function.|STDARG.H,\<br />\<br /> CRTDEFS.H|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder> wide character|Useful for writing portable programs for international markets.|STDDEF.H, STDLIB.H,\<br />\<br /> CRTDEFS.H,\<br />\<br /> SYS\STAT.H|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder> integer|Represents locale-specific character mappings.|WCTYPE.H|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder> integer|Can represent all characters of any language character set.|WCHAR.H,\<br />\<br /> CRTDEFS.H|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder> integer|Type of data object that can hold any wide character or wide end-of-file value.|WCHAR.H,\<br />\<br /> CRTDEFS.H|  
  
## See Also  
 [C Run-Time Library Reference](../vs140/c-run-time-library-reference.md)