---
title: "gmtime, _gmtime32, _gmtime64"
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
  - "_gmtime32"
  - "gmtime"
  - "_gmtime64"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "gmtime"
  - "_gmtime32"
  - "_gmtime64"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "gmtime32 function"
  - "_gmtime64 function"
  - "gmtime function"
  - "time functions"
  - "_gmtime32 function"
  - "gmtime64 function"
  - "time structure conversion"
ms.assetid: 315501f3-477e-475d-a414-ef100ee0db27
caps.latest.revision: 32
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# gmtime, _gmtime32, _gmtime64
Converts a time value to a structure. More secure versions of these functions are available; see [_gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the stored time. The time is represented as seconds elapsed since midnight (00:00:00), January 1, 1970, coordinated universal time (UTC).  
  
## Return Value  
 A pointer to a structure of type [tm](../vs140/standard-types.md). The fields of the returned structure hold the evaluated value of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument in UTC rather than in local time. Each of the structure fields is of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, as follows:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Seconds after minute (0 – 59).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Minutes after hour (0 – 59).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Hours since midnight (0 – 23).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Day of month (1 – 31).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Month (0 – 11; January = 0).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Year (current year minus 1900).  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Day of week (0 – 6; Sunday = 0).  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Day of year (0 – 365; January 1 = 0).  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Always 0 for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 Both the 32-bit and 64-bit versions of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> all use one common <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> structure per thread for the conversion. Each call to one of these functions destroys the result of any previous call. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> represents a date before midnight, January 1, 1970, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. There is no error return.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> structure, enables dates to be expressed up through 23:59:59, December 31, 3000, UTC, whereas <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> only represent dates through 23:59:59 January 18, 2038, UTC. Midnight, January 1, 1970, is the lower bound of the date range for both functions.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is an inline function that evaluates to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> unless <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is defined. If you must force the compiler to interpret <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> as the old 32-bit <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, but doing so causes <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to be in-lined to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to be defined as <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. We recommend that you do not do this, because it is not allowed on 64-bit platforms and in any case your application may fail after January 18, 2038.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a null pointer, or if the timer value is negative, these functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function breaks down the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> value and stores it in a statically allocated structure of type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, defined in TIME.H. The value of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is typically obtained from a call to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> function.  
  
> [!NOTE]
>  In most cases, the target environment tries to determine whether daylight savings time is in effect. The C run-time library assumes that the United States rules for implementing the calculation of Daylight Saving Time (DST) are used.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<time.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Coordinated universal time is Tue Feb 12 23:11:31 2002**   
## .NET Framework Equivalent  
  
-   [System::DateTime::UtcNow](https://msdn.microsoft.com/en-us/library/system.datetime.utcnow.aspx)  
  
-   [System::DateTime::ToUniversalTime](https://msdn.microsoft.com/en-us/library/system.datetime.touniversaltime.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime_s, _gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [_mkgmtime, _mkgmtime32, _mkgmtime64](../vs140/_mkgmtime--_mkgmtime32--_mkgmtime64.md)   
 [mktime, _mktime32, _mktime64](../vs140/mktime--_mktime32--_mktime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)