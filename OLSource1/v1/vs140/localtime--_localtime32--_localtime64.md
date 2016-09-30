---
title: "localtime, _localtime32, _localtime64"
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
  - "_localtime64"
  - "_localtime32"
  - "localtime"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "localtime64"
  - "_localtime64"
  - "localtime32"
  - "localtime"
  - "_localtime32"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "localtime32 function"
  - "_localtime32 function"
  - "_localtime64 function"
  - "localtime64 function"
  - "localtime function"
  - "time, converting values"
ms.assetid: 4260ec3d-43ee-4538-b998-402a282bb9b8
caps.latest.revision: 30
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# localtime, _localtime32, _localtime64
Convert a time value and correct for the local time zone. More secure versions of these functions are available; see [_localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to stored time.  
  
## Return Value  
 Return a pointer to the structure result, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the date passed to the function is:  
  
-   Before midnight, January 1, 1970.  
  
-   After 03:14:07, January 19, 2038, UTC (using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
-   After 23:59:59, December 31, 3000, UTC (using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure, allows dates to be expressed up through 23:59:59, December 31, 3000, coordinated universal time (UTC), whereas <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> represents dates through 23:59:59 January 18, 2038, UTC.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an inline function which evaluates to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If you need to force the compiler to interpret <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>as the old 32-bit <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Doing this will cause <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to evaluate to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. This is not recommended because your application may fail after January 18, 2038, and it is not allowed on 64-bit platforms.  
  
 The fields of the structure type [tm](../vs140/standard-types.md) store the following values, each of which is an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Seconds after minute (0 – 59).  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Minutes after hour (0 – 59).  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Hours after midnight (0 – 23).  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Day of month (1 – 31).  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Month (0 – 11; January = 0).  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Year (current year minus 1900).  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Day of week (0 – 6; Sunday = 0).  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Day of year (0 – 365; January 1 = 0).  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Positive value if daylight saving time is in effect; 0 if daylight saving time is not in effect; negative value if status of daylight saving time is unknown. If the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> environment variable is set, the C run-time library assumes rules appropriate to the United States for implementing the calculation of daylight-saving time (DST).  
  
## Remarks  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function converts a time stored as a [time_t](../vs140/standard-types.md) value and stores the result in a structure of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> represents the seconds elapsed since midnight (00:00:00), January 1, 1970, UTC. This value is usually obtained from the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> function.  
  
 Both the 32-bit and 64-bit versions of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> all use a single <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> structure per thread for the conversion. Each call to one of these routines destroys the result of the previous call.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> corrects for the local time zone if the user first sets the global environment variable <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is set, three other environment variables (<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>) are automatically set as well. If the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> variable is not set, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> attempts to use the time zone information specified in the Date/Time application in Control Panel. If this information cannot be obtained, PST8PDT, which signifies the Pacific Time Zone, is used by default. See [_tzset](../vs140/_tzset.md) for a description of these variables. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is a Microsoft extension and not part of the ANSI standard definition of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The target environment should try to determine whether daylight saving time is in effect.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is a null pointer, or if the timer value is negative, these functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<time.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Tue Feb 12 10:05:58 AM**   
## .NET Framework Equivalent  
 [System::DateTime::ToLocalTime](https://msdn.microsoft.com/en-us/library/system.datetime.tolocaltime.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime_s, _localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)   
 [_tzset](../vs140/_tzset.md)