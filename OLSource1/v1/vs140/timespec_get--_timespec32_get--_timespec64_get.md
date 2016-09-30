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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a struct that is set to the time in seconds and nanoseconds since the start of the epoch.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A non-zero implementation-specific value that specifies the time base.  
  
## Return Value  
 The value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if successful, otherwise it returns zero.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions set the current time in the struct pointed to by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument. All versions of this struct have two members, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value is set to the whole number of seconds and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the integral number of nanoseconds, rounded to the resolution of the system clock, since the start of the epoch specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 **Microsoft Specific**  
  
 These functions support only <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value. This sets the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> value to the number of seconds and nanoseconds since the epoch start, Midnight, January 1, 1970, Coordinated Universal Time (UTC). In a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value. In a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value. In a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> type, which is 32 bits or 64 bits in length depending on whether the preprocessor macro  _USE_32BIT_TIME_T is defined. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function is an inline function that calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if _USE_32BIT_TIME_T is defined; otherwise it calls <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 **End Microsoft Specific**  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|C: \<time.h>, C++: \<ctime> or \<time.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [gmtime_s, _gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [localtime_s, _localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)   
 [time, _time32 _time64](../vs140/time--_time32--_time64.md)   
 [_utime, _utime32 _utime64, _wutime, _wutime32, _wutime64](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md)