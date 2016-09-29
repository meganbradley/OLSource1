---
title: "timespec_get, _timespec32_get, _timespec64_get"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "timespec_get"
  - "_timespec32_get"
  - "_timespec64_get"
apilocation: 
  - "api-ms-win-crt-time-l1-1-0.dll"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "api-ms-win-core-crt-l2-1-0"
apitype: "DLLExport"
f1_keywords: 
  - "timespec_get"
  - "_timespec32_get"
  - "_timespec64_get"
  - "time/timespec_get"
  - "time/_timespec32_get"
  - "time/_timespec64_get"
  - "timespec"
  - "_timespec32"
  - "_timespec64"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "timespec_get function"
  - "_timespec32_get function"
  - "_timespec64_get function"
ms.assetid: ed757258-b4f2-4c1d-a91b-22ea6ffce4ab
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timespec_get, _timespec32_get, _timespec64_get
Sets the interval pointed to by the first argument to the current calendar time, based on the specified time base.  
  
## Syntax  
  
```  
int timespec_get(  
    struct timespec* const time_spec,  
    int const base  
);  
int _timespec32_get(  
    struct _timespec32* const time_spec,  
    int const base  
);  
int _timespec64_get(  
    struct _timespec64* const time_spec,  
    int const base  
);  
  
```  
  
#### Parameters  
 `time_spec`  
 Pointer to a struct that is set to the time in seconds and nanoseconds since the start of the epoch.  
  
 `base`  
 A non-zero implementation-specific value that specifies the time base.  
  
## Return Value  
 The value of `base` if successful, otherwise it returns zero.  
  
## Remarks  
 The `timespec_get` functions set the current time in the struct pointed to by the `time_spec` argument. All versions of this struct have two members, `tv_sec` and `tv_nsec`. The `tv_sec` value is set to the whole number of seconds and `tv_nsec` to the integral number of nanoseconds, rounded to the resolution of the system clock, since the start of the epoch specified by `base`.  
  
 **Microsoft Specific**  
  
 These functions support only `TIME_UTC` as the `base` value. This sets the `time_spec` value to the number of seconds and nanoseconds since the epoch start, Midnight, January 1, 1970, Coordinated Universal Time (UTC). In a `struct _timespec32`, `tv_sec` is a `__time32_t` value. In a `struct _timespec64`, `tv_sec` is a `__time64_t` value. In a `struct timespec`, `tv_sec` is a `time_t` type, which is 32 bits or 64 bits in length depending on whether the preprocessor macro  _USE_32BIT_TIME_T is defined. The `timespec_get` function is an inline function that calls `_timespec32_get` if _USE_32BIT_TIME_T is defined; otherwise it calls `_timespec64_get`.  
  
 **End Microsoft Specific**  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`timespec_get`, `_timespec32_get`, `_timespec64_get`|C: <time.h>, C++: <ctime\> or <time.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## See Also  
 [Time Management](../VS_csharp/time-management.md)   
 [asctime, _wasctime](../VS_csharp/asctime--_wasctime.md)   
 [asctime_s, _wasctime_s](../VS_csharp/asctime_s--_wasctime_s.md)   
 [_ftime, _ftime32, _ftime64](../VS_csharp/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../VS_csharp/gmtime--_gmtime32--_gmtime64.md)   
 [gmtime_s, _gmtime32_s, _gmtime64_s](../VS_csharp/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [localtime, _localtime32, _localtime64](../VS_csharp/localtime--_localtime32--_localtime64.md)   
 [localtime_s, _localtime32_s, _localtime64_s](../VS_csharp/localtime_s--_localtime32_s--_localtime64_s.md)   
 [time, _time32 _time64](../VS_csharp/time--_time32--_time64.md)   
 [_utime, _utime32 _utime64, _wutime, _wutime32, _wutime64](../VS_csharp/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md)