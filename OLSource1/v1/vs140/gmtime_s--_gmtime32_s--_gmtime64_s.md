---
title: "gmtime_s, _gmtime32_s, _gmtime64_s"
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
  - "_gmtime32_s"
  - "gmtime_s"
  - "_gmtime64_s"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_gmtime_s"
  - "gmtime64_s"
  - "gmtime32_s"
  - "_gmtime64_s"
  - "gmtime_s"
  - "_gmtime32_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "gmtime_s function"
  - "gmtime32_s function"
  - "time functions"
  - "gmtime64_s function"
  - "_gmtime64_s function"
  - "time structure conversion"
  - "_gmtime_s function"
  - "_gmtime32_s function"
ms.assetid: 261c7df0-2b0c-44ba-ba61-cb83efaec60f
caps.latest.revision: 31
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# gmtime_s, _gmtime32_s, _gmtime64_s
Converts a time value to a structure. These are versions of [_gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure. The fields of the returned structure hold the evaluated value of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument in UTC rather than in local time.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to stored time. The time is represented as seconds elapsed since midnight (00:00:00), January 1, 1970, coordinated universal time (UTC).  
  
## Return Value  
 Zero if successful. The return value is an error code if there is a failure. Error codes are defined in Errno.h; for a listing of these errors, see [errno](../vs140/errno-constants.md).  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Return|Value in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|-----------|------------|------------|--------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Not modified.|  
|Not <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (points to valid memory)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|All fields set to -1.|  
|Not <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|< 0|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|All fields set to -1.|  
  
 In the case of the first two error conditions, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function breaks down the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value and stores it in a structure of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, defined in Time.h. The address of the structure is passed in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is usually obtained from a call to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function.  
  
> [!NOTE]
>  The target environment should try to determine whether daylight savings time is in effect. The C run-time library assumes the United States rules for implementing the calculation of daylight saving time .  
  
 Each of the structure fields is of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, as shown in the following table.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Seconds after minute (0 – 59).  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Minutes after hour (0 – 59).  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Hours since midnight (0 – 23).  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Day of month (1 – 31).  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Month (0 – 11; January = 0).  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Year (current year minus 1900).  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Day of week (0 – 6; Sunday = 0).  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Day of year (0 – 365; January 1 = 0).  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Always 0 for <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> structure, allows dates to be expressed up through 23:59:59, December 31, 3000, UTC; whereas <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> only represent dates through 23:59:59 January 18, 2038, UTC. Midnight, January 1, 1970, is the lower bound of the date range for both these functions.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is an inline function which evaluates to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If you need to force the compiler to interpret <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> as the old 32-bit <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Doing this will cause <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to be in-lined to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. This is not recommended because your application may fail after January 18, 2038, and it is not allowed on 64-bit platforms.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<time.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Coordinated universal time is Fri Apr 25 20:12:33 2003**   
## .NET Framework Equivalent  
  
-   [System::DateTime::UtcNow](https://msdn.microsoft.com/en-us/library/system.datetime.utcnow.aspx)  
  
-   [System::DateTime::ToUniversalTime](https://msdn.microsoft.com/en-us/library/system.datetime.touniversaltime.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime_s, _localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)   
 [_mkgmtime, _mkgmtime32, _mkgmtime64](../vs140/_mkgmtime--_mkgmtime32--_mkgmtime64.md)   
 [mktime, _mktime32, _mktime64](../vs140/mktime--_mktime32--_mktime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)