---
title: "_ftime_s, _ftime32_s, _ftime64_s"
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
  - "_ftime_s"
  - "_ftime64_s"
  - "_ftime32_s"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ftime_s"
  - "_ftime64_s"
  - "ftime_s"
  - "_ftime32_s"
  - "ftime32_s"
  - "ftime64_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ftime32_s function"
  - "ftime_s function"
  - "_ftime64_s function"
  - "current time"
  - "ftime64_s function"
  - "time, getting current"
  - "_ftime_s function"
  - "_ftime32_s function"
ms.assetid: d03080d9-a520-45be-aa65-504bdb197e8b
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ftime_s, _ftime32_s, _ftime64_s
Gets the current time. These are versions of [_ftime, _ftime32, _ftime64](../VS_csharp/_ftime--_ftime32--_ftime64.md) with security enhancements as described in [Security Enhancements in the CRT](../VS_csharp/security-features-in-the-crt.md).  
  
## Syntax  
  
```  
errno_t _ftime_s(   
   struct _timeb *timeptr   
);  
errno_t _ftime32_s(   
   struct __timeb32 *timeptr   
);  
errno_t _ftime64_s(   
   struct __timeb64 *timeptr   
);  
```  
  
#### Parameters  
 `timeptr`  
 Pointer to a `_timeb,``__timeb32`, or `__timeb64` structure.  
  
## Return Value  
 Zero if successful, an error code on failure. If `timeptr` is `NULL`, the return value is `EINVAL`.  
  
## Remarks  
 The `_ftime_s` function gets the current local time and stores it in the structure pointed to by `timeptr`*.* The `_timeb,``__timeb32`,and`__timeb64` structures are defined in SYS\Timeb.h. They contain four fields, which are listed in the following table.  
  
 `dstflag`  
 Nonzero if daylight savings time is currently in effect for the local time zone. (See [_tzset](../VS_csharp/_tzset.md) for an explanation of how daylight savings time is determined.)  
  
 `millitm`  
 Fraction of a second in milliseconds.  
  
 `time`  
 Time in seconds since midnight (00:00:00), January 1, 1970, coordinated universal time (UTC).  
  
 `timezone`  
 Difference in minutes, moving westward, between UTC and local time. The value of `timezone` is set from the value of the global variable `_timezone` (see `_tzset`).  
  
 `_ftime64_s`, which uses the `__timeb64` structure, allows file-creation dates to be expressed up through 23:59:59, December 31, 3000, UTC; whereas `_ftime32_s` only represents dates through 23:59:59 January 18, 2038, UTC. Midnight, January 1, 1970, is the lower bound of the date range for all these functions.  
  
 `_ftime_s` is equivalent to `_ftime64_s` and `_timeb` contains a 64-bit time. This is true unless _`USE_32BIT_TIME_T` is defined, in which case the old behavior is in effect; \_`ftime_s` uses a 32-bit time and `_timeb` contains a 32-bit time.  
  
 `_ftime_s` validates its parameters. If passed a null pointer as `timeptr`, the function invokes the invalid parameter handler, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, the function sets `errno` to `EINVAL`.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`_ftime_s`|<sys/types.h> and <sys/timeb.h>|  
|`_ftime32_s`|<sys/types.h> and <sys/timeb.h>|  
|`_ftime64_s`|<sys/types.h> and <sys/timeb.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../VS_csharp/crt-library-features.md).  
  
## Example  
  
```  
// crt_ftime64_s.c  
// This program uses _ftime64_s to obtain the current  
// time and then stores this time in timebuffer.  
  
#include <stdio.h>  
#include <sys/timeb.h>  
#include <time.h>  
  
int main( void )  
{  
   struct _timeb timebuffer;  
   char timeline[26];  
   errno_t err;  
   time_t time1;  
   unsigned short millitm1;  
   short timezone1;  
   short dstflag1;  
  
   _ftime64_s( &timebuffer );  
  
    time1 = timebuffer.time;  
    millitm1 = timebuffer.millitm;  
    timezone1 = timebuffer.timezone;  
    dstflag1 = timebuffer.dstflag;  
  
   printf( "Seconds since midnight, January 1, 1970 (UTC): %I64d\n",   
   time1);  
   printf( "Milliseconds: %d\n", millitm1);  
   printf( "Minutes between UTC and local time: %d\n", timezone1);  
   printf( "Daylight savings time flag (1 means Daylight time is in "  
           "effect): %d\n", dstflag1);   
  
   err = ctime_s( timeline, 26, & ( timebuffer.time ) );  
   if (err)  
   {  
       printf("Invalid argument to ctime_s. ");  
   }  
   printf( "The time is %.19s.%hu %s", timeline, timebuffer.millitm,  
           &timeline[20] );  
}  
```  
  
 **Seconds since midnight, January 1, 1970 (UTC): 1051553334**  
**Milliseconds: 230**  
**Minutes between UTC and local time: 480**  
**Daylight savings time flag (1 means Daylight time is in effect): 1**  
**The time is Mon Apr 28 11:08:54.230 2003**   
## .NET Framework Equivalent  
 [System::DateTime::Now](https://msdn.microsoft.com/en-us/library/system.datetime.now.aspx)  
  
## See Also  
 [Time Management](../VS_csharp/time-management.md)   
 [asctime, _wasctime](../VS_csharp/asctime--_wasctime.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../VS_csharp/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [gmtime, _gmtime32, _gmtime64](../VS_csharp/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../VS_csharp/localtime--_localtime32--_localtime64.md)   
 [time, _time32, _time64](../VS_csharp/time--_time32--_time64.md)