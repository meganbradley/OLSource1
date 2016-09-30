---
title: "localtime_s, _localtime32_s, _localtime64_s"
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
  - "_localtime64_s"
  - "_localtime32_s"
  - "localtime_s"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_localtime32_s"
  - "localtime32_s"
  - "localtime_s"
  - "localtime64_s"
  - "_localtime64_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_localtime64_s function"
  - "localtime32_s function"
  - "_localtime32_s function"
  - "localtime64_s function"
  - "time, converting values"
  - "localtime_s function"
ms.assetid: 842d1dc7-d6f8-41d3-b340-108d4b90df54
caps.latest.revision: 27
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# localtime_s, _localtime32_s, _localtime64_s
Converts a time value and corrects for the local time zone. These are versions of [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the time structure to be filled in.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the stored time.  
  
## Return Value  
 Zero if successful. The return value is an error code if there is a failure. Error codes are defined in Errno.h. For a listing of these errors, see [errno](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Return value|Value in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Invokes invalid parameter handler|  
|-----------|------------|------------------|--------------------|---------------------------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Not modified|Yes|  
|Not <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (points to valid memory)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|All fields set to -1|Yes|  
|Not <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (points to valid memory)|less than 0 or greater than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|All fields set to -1|No|  
  
 In the case of the first two error conditions, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function converts a time stored as a [time_t](../vs140/standard-types.md) value and stores the result in a structure of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> represents the seconds elapsed since midnight (00:00:00), January 1, 1970, UTC. This value is usually obtained from the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> corrects for the local time zone if the user first sets the global environment variable <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is set, three other environment variables (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>) are automatically set as well. If the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> variable is not set, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> attempts to use the time zone information specified in the Date/Time application in Control Panel. If this information cannot be obtained, PST8PDT, which signifies the Pacific time zone, is used by default. See [_tzset](../vs140/_tzset.md) for a description of these variables. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is a Microsoft extension and not part of the ANSI standard definition of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The target environment should try to determine whether daylight saving time is in effect.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> structure, allows dates to be expressed up through 23:59:59, December 31, 3000, coordinated universal time (UTC), whereas <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> represents dates through 23:59:59 January 18, 2038, UTC.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is an inline function which evaluates to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. If you need to force the compiler to interpret <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> as the old 32-bit <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. Doing this will cause <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to evaluate to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. This is not recommended because your application may fail after January 18, 2038, and it is not allowed on 64-bit platforms.  
  
 The fields of the structure type [tm](../vs140/standard-types.md) store the following values, each of which is an <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Seconds after minute (0 – 59).  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Minutes after hour (0 – 59).  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Hours after midnight (0 – 23).  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Day of month (1 – 31).  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Month (0 – 11; January = 0).  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Year (current year minus 1900).  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Day of week (0 – 6; Sunday = 0).  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Day of year (0 – 365; January 1 = 0).  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Positive value if daylight saving time is in effect; 0 if daylight saving time is not in effect; negative value if status of daylight saving time is unknown. If the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> environment variable is set, the C run-time library assumes rules appropriate to the United States for implementing the calculation of daylight saving time (DST).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<time.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
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