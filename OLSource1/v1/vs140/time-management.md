---
title: "Time Management"
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
  - "c.memory"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "dates, run-time library members"
  - "time, time management"
  - "date functions"
  - "time functions"
ms.assetid: 93599220-c011-45d5-978f-12182abfdd2f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Time Management
Use these functions to get the current time and convert, adjust, and store it as necessary. The current time is the system time.  
  
 The `_ftime` and `localtime` routines use the `TZ` environment variable. If `TZ` is not set, the run-time library attempts to use the time-zone information specified by the operating system. If this information is unavailable, these functions use the default value of PST8PDT. For more information on `TZ`, see [_tzset](../vs140/_tzset.md); also see [_daylight, timezone, and _tzname](../vs140/_daylight--_dstbias--_timezone--and-_tzname.md).  
  
### Time Routines  
  
|Function|Use|.NET Framework equivalent|  
|--------------|---------|-------------------------------|  
|[asctime, _wasctime](../vs140/asctime--_wasctime.md), [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)|Convert time from type `struct tm` to character string. The versions of these functions with the `_s` suffix are more secure.|[System::DateTime::ToLongDateString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongdatestring.aspx), [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx), [System::DateTime::ToShortDateString](https://msdn.microsoft.com/en-us/library/system.datetime.toshortdatestring.aspx), [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx), [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)|  
|[clock](../vs140/clock.md)|Return elapsed wall-clock time for process.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[ctime, _ctime32, _ctime64, _wctime, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md), [_ctime_s, _ctime32_s, _ctime64_s, _wctime_s, _wctime32_s, _wctime64_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md)|Convert time from type `time_t`, `__time32_t` or `__time64_t` to character string. The versions of these functions with the `_s` suffix are more secure.|[System::DateTime::GetDateTimeFormats](https://msdn.microsoft.com/en-us/library/system.datetime.getdatetimeformats.aspx), [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx), [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx), [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx)|  
|[difftime, _difftime32, _difftime64](../vs140/difftime--_difftime32--_difftime64.md)|Compute difference between two times.|[System::DateTime::Subtract](https://msdn.microsoft.com/en-us/library/system.datetime.subtract.aspx)|  
|[_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md),[_ftime_s, _ftime32_s, _ftime64_s](../vs140/_ftime_s--_ftime32_s--_ftime64_s.md)|Store current system time in variable of type `struct _timeb` or type `struct``__timeb64` The versions of these functions with the `_s` suffix are more secure.|[System::DateTime::Now](https://msdn.microsoft.com/en-us/library/system.datetime.now.aspx)|  
|[_futime, _futime32, _futime64](../vs140/_futime--_futime32--_futime64.md)|Set modification time on open file|[System::IO::File::SetLastAccessTime](https://msdn.microsoft.com/en-us/library/system.io.file.setlastaccesstime.aspx), [System::IO::File::SetLastWriteTime](https://msdn.microsoft.com/en-us/library/system.io.file.setlastwritetime.aspx), [System::IO::File::SetCreationTime](https://msdn.microsoft.com/en-us/library/system.io.file.setcreationtime.aspx)|  
|[gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md), [_gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)|Convert time from type `time_t` to `struct tm` or from type `__time64_t` to `struct tm`.The versions of these functions with the `_s` suffix are more secure.|[System::DateTime::UtcNow](https://msdn.microsoft.com/en-us/library/system.datetime.utcnow.aspx), [System::DateTime::ToUniversalTime](https://msdn.microsoft.com/en-us/library/system.datetime.touniversaltime.aspx)|  
|[localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md), [_localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)|Convert time from type `time_t` to `struct tm` or from type `__time64_t` to `struct tm`with local correction. The versions of these functions with the `_s` suffix are more secure.|[System::DateTime::ToLocalTime](https://msdn.microsoft.com/en-us/library/system.datetime.tolocaltime.aspx)|  
|[_mkgmtime, _mkgmtime32, _mkgmtime64](../vs140/_mkgmtime--_mkgmtime32--_mkgmtime64.md)|Convert time to calendar value in Greenwich Mean Time.|[System::DateTime::ToUniversalTime](https://msdn.microsoft.com/en-us/library/system.datetime.touniversaltime.aspx)|  
|[mktime, _mktime32, _mktime64](../vs140/mktime--_mktime32--_mktime64.md)|Convert time to calendar value.|[System::DateTime::DateTime](Overload:System.DateTime.)|  
|[_strdate, _wstrdate](../vs140/_strdate--_wstrdate.md), [_strdate_s, _wstrdate_s](../vs140/_strdate_s--_wstrdate_s.md)|Return current system date as string. The versions of these functions with the `_s` suffix are more secure.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md)|Format date-and-time string for international use.|[System::DateTime::ToLongDateString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongdatestring.aspx), [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx), [System::DateTime::ToShortDateString](https://msdn.microsoft.com/en-us/library/system.datetime.toshortdatestring.aspx), [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx), [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)|  
|[_strtime, _wstrtime](../vs140/_strtime--_wstrtime.md), [_strtime_s, _wstrtime_s](../vs140/_strtime_s--_wstrtime_s.md)|Return current system time as string. The versions of these functions with the `_s` suffix are more secure.|[System::DateTime::ToLongDateString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongdatestring.aspx), [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx), [System::DateTime::ToShortDateString](https://msdn.microsoft.com/en-us/library/system.datetime.toshortdatestring.aspx), [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx), [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)|  
|[time, _time32, _time64](../vs140/time--_time32--_time64.md)|Get current system time as type `time_t`, `__time32_t` or as type `__time64_t`.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_tzset](../vs140/_tzset.md)|Set external time variables from environment time variable `TZ`.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_utime, _utime32, _utime64, _wutime, _wutime32, _wutime64](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md)|Set modification time for specified file using either current time or time value stored in structure.|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
> [!NOTE]
>  In all versions of Microsoft C/C++ except Microsoft C/C++ version 7.0, and in all versions of Visual C++, the time function returns the current time as the number of seconds elapsed since midnight on January 1, 1970. In Microsoft C/C++ version 7.0, `time` returned the current time as the number of seconds elapsed since midnight on December 31, 1899.  
  
> [!NOTE]
>  In versions of [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] and Microsoft C/C++ before Visual C++ 2005, `time_t` was a `long int` (32 bits) and hence could not be used for dates past 3:14:07 January 19, 2038, UTC. `time_t` is now equivalent to `__time64_t` by default, but defining `_USE_32BIT_TIME_T` changes `time_t` to `__time32_t` and forces many time functions to call versions that take the 32-bit `time_t`. For more information, see [Standard Types](../vs140/standard-types.md) and comments in the documentation for the individual time functions.  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)