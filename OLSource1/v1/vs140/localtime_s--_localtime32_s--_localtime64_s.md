---
title: "localtime_s, _localtime32_s, _localtime64_s"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - _localtime64_s
  - _localtime32_s
  - localtime_s
apilocation: 
  - msvcr120.dll
  - msvcr110_clr0400.dll
  - msvcr90.dll
  - msvcr80.dll
  - msvcrt.dll
  - msvcr110.dll
  - msvcr100.dll
apitype: DLLExport
f1_keywords: 
  - _localtime32_s
  - localtime32_s
  - localtime_s
  - localtime64_s
  - _localtime64_s
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - _localtime64_s function
  - localtime32_s function
  - _localtime32_s function
  - localtime64_s function
  - time, converting values
  - localtime_s function
ms.assetid: 842d1dc7-d6f8-41d3-b340-108d4b90df54
caps.latest.revision: 27
translation.priority.mt: 
  - de-de
  - ja-jp
---
# localtime_s, _localtime32_s, _localtime64_s
Converts a time value and corrects for the local time zone. These are versions of [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
```  
errno_t localtime_s(  
   struct tm* _tm,  
   const time_t *time   
);  
errno_t _localtime32_s(  
   struct tm* _tm,  
   const time32_t *time   
);  
errno_t _localtime64_s(  
   struct tm* _tm,  
   const _time64_t *time   
);  
```  
  
#### Parameters  
 `_tm`  
 Pointer to the time structure to be filled in.  
  
 `time`  
 Pointer to the stored time.  
  
## Return Value  
 Zero if successful. The return value is an error code if there is a failure. Error codes are defined in Errno.h. For a listing of these errors, see [errno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
### Error Conditions  
  
|`_tm`|`time`|Return value|Value in `_tm`|Invokes invalid parameter handler|  
|-----------|------------|------------------|--------------------|---------------------------------------|  
|`NULL`|any|`EINVAL`|Not modified|Yes|  
|Not `NULL` (points to valid memory)|`NULL`|`EINVAL`|All fields set to -1|Yes|  
|Not `NULL` (points to valid memory)|less than 0 or greater than `_MAX__TIME64_T`|`EINVAL`|All fields set to -1|No|  
  
 In the case of the first two error conditions, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set `errno` to `EINVAL` and return `EINVAL`.  
  
## Remarks  
 The `_localtime32_s` function converts a time stored as a [time_t](../vs140/standard-types.md) value and stores the result in a structure of type `tm`. The `long` value `timer` represents the seconds elapsed since midnight (00:00:00), January 1, 1970, UTC. This value is usually obtained from the `time` function.  
  
 `_localtime32_s` corrects for the local time zone if the user first sets the global environment variable `TZ`. When `TZ` is set, three other environment variables (`_timezone`, `_daylight`, and `_tzname`) are automatically set as well. If the `TZ` variable is not set, `localtime32_s` attempts to use the time zone information specified in the Date/Time application in Control Panel. If this information cannot be obtained, PST8PDT, which signifies the Pacific time zone, is used by default. See [_tzset](../vs140/_tzset.md) for a description of these variables. `TZ` is a Microsoft extension and not part of the ANSI standard definition of `localtime`.  
  
> [!NOTE]
>  The target environment should try to determine whether daylight saving time is in effect.  
  
 `_localtime64_s`, which uses the `__time64_t` structure, allows dates to be expressed up through 23:59:59, December 31, 3000, coordinated universal time (UTC), whereas `_localtime32_s` represents dates through 23:59:59 January 18, 2038, UTC.  
  
 `localtime_s` is an inline function which evaluates to `_localtime64_s`, and `time_t` is equivalent to `__time64_t`. If you need to force the compiler to interpret `time_t` as the old 32-bit `time_t`, you can define `_USE_32BIT_TIME_T`. Doing this will cause `localtime_s` to evaluate to `_localtime32_s`. This is not recommended because your application may fail after January 18, 2038, and it is not allowed on 64-bit platforms.  
  
 The fields of the structure type [tm](../vs140/standard-types.md) store the following values, each of which is an `int`.  
  
 `tm_sec`  
 Seconds after minute (0 – 59).  
  
 `tm_min`  
 Minutes after hour (0 – 59).  
  
 `tm_hour`  
 Hours after midnight (0 – 23).  
  
 `tm_mday`  
 Day of month (1 – 31).  
  
 `tm_mon`  
 Month (0 – 11; January = 0).  
  
 `tm_year`  
 Year (current year minus 1900).  
  
 `tm_wday`  
 Day of week (0 – 6; Sunday = 0).  
  
 `tm_yday`  
 Day of year (0 – 365; January 1 = 0).  
  
 `tm_isdst`  
 Positive value if daylight saving time is in effect; 0 if daylight saving time is not in effect; negative value if status of daylight saving time is unknown. If the `TZ` environment variable is set, the C run-time library assumes rules appropriate to the United States for implementing the calculation of daylight saving time (DST).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`localtime_s`|<time.h>|  
|`_localtime32_s`|<time.h>|  
|`_localtime64_s`|<time.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
```  
// crt_localtime_s.c  
/* This program uses _time64 to get the current time   
 * and then uses _localtime64_s() to convert this time to a structure   
 * representing the local time. The program converts the result   
 * from a 24-hour clock to a 12-hour clock and determines the   
 * proper extension (AM or PM).  
 */  
  
#include <stdio.h>  
#include <string.h>  
#include <time.h>  
  
int main( void )  
{  
        struct tm newtime;  
        char am_pm[] = "AM";  
        __time64_t long_time;  
        char timebuf[26];  
        errno_t err;  
  
        // Get time as 64-bit integer.  
        _time64( &long_time );   
        // Convert to local time.  
        err = _localtime64_s( &newtime, &long_time );   
        if (err)  
        {  
            printf("Invalid argument to _localtime64_s.");  
            exit(1);  
        }  
        if( newtime.tm_hour > 12 )        // Set up extension.   
                strcpy_s( am_pm, sizeof(am_pm), "PM" );  
        if( newtime.tm_hour > 12 )        // Convert from 24-hour   
                newtime.tm_hour -= 12;    // to 12-hour clock.   
        if( newtime.tm_hour == 0 )        // Set hour to 12 if midnight.  
                newtime.tm_hour = 12;  
  
        // Convert to an ASCII representation.   
        err = asctime_s(timebuf, 26, &newtime);  
        if (err)  
        {  
           printf("Invalid argument to asctime_s.");  
           exit(1);  
        }  
        printf( "%.19s %s\n", timebuf, am_pm );  
}  
```  
  
## Sample Output  
  
```  
Fri Apr 25 01:19:27 PM  
```  
  
## .NET Framework Equivalent  
 [System::DateTime::ToLocalTime](https://msdn.microsoft.com/en-us/library/system.datetime.tolocaltime.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime_s, _gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)   
 [_tzset](../vs140/_tzset.md)