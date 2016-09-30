---
title: "time, _time32, _time64"
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
  - "time"
  - "_time64"
  - "_time32"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-time-l1-1-0.dll"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "api-ms-win-core-crt-l2-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "time"
  - "_time64"
  - "time/time"
  - "time/_time32"
  - "time/_time64"
  - "_time32"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "time32 function"
  - "_time32 function"
  - "_time64 function"
  - "time functions"
  - "system time"
  - "time64 function"
ms.assetid: 280e00f2-2b93-4ece-94cd-e048484c6cc7
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# time, _time32, _time64
Get the system time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the storage location for time.  
  
## Return Value  
 Return the time as seconds elapsed since midnight, January 1, 1970, or -1 in the case of an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function returns the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Coordinated Universal Time (UTC), according to the system clock. The return value is stored in the location given by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This parameter may be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, in which case the return value is not stored.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a wrapper for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is, by default, equivalent to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If you need to force the compiler to interpret <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as the old 32-bit <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. This is not recommended because your application may fail after January 18, 2038; the use of this macro is not allowed on 64-bit platforms.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|C: \<time.h>, C++: \<ctime> or \<time.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **OS time:            13:51:23**  
**OS date:            04/25/03**  
**Time in seconds since UTC 1/1/70:   1051303883**  
**UNIX time and date:         Fri Apr 25 13:51:23 2003**  
**Coordinated universal time:      Fri Apr 25 20:51:23 2003**  
**12-hour time:            01:51:23 PM**  
**Plus milliseconds:         552**  
**Zone difference in hours from UTC:   8**  
**Time zone name:            Pacific Standard Time**  
**Daylight savings:         YES**  
**Christmas            Sat Dec 25 12:00:00 1993**  
**Today is Friday, day 25 of April in the year 2003.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [gmtime_s, _gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [localtime_s, _localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)   
 [_utime, _utime32 _utime64, _wutime, _wutime32, _wutime64](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md)