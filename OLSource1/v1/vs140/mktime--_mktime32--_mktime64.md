---
title: "mktime, _mktime32, _mktime64"
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
  - "_mktime32"
  - "mktime"
  - "_mktime64"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mktime"
  - "_mktime64"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mktime32 function"
  - "mktime function"
  - "time functions"
  - "mktime64 function"
  - "converting times"
  - "mktime32 function"
  - "_mktime64 function"
  - "time, converting"
ms.assetid: 284ed5d4-7064-48a2-bd50-15effdae32cf
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# mktime, _mktime32, _mktime64
Convert the local time to a calendar value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *timeptr*  
 Pointer to time structure; see [asctime](../vs140/asctime--_wasctime.md).  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the specified calendar time encoded as a value of type [time_t](../vs140/standard-types.md). If *timeptr* references a date before midnight, January 1, 1970, or if the calendar time cannot be represented, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns –1 cast to type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. When using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and if *timeptr* references a date after 23:59:59 January 18, 2038, Coordinated Universal Time (UTC), it will return –1 cast to type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will return –1 cast to type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if *timeptr* references a date after 23:59:59, December 31, 3000, UTC.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> functions convert the supplied time structure (possibly incomplete) pointed to by *timeptr* into a fully defined structure with normalized values and then converts it to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> calendar time value. The converted time has the same encoding as the values returned by the [time](../vs140/time--_time32--_time64.md) function. The original values of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> components of the *timeptr* structure are ignored, and the original values of the other components are not restricted to their normal ranges.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is an inline function that is equivalent to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, unless <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is defined, in which case it is equivalent to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 After an adjustment to UTC, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> handles dates from midnight, January 1, 1970, to 23:59:59 January 18, 2038, UTC. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> handles dates from midnight, January 1, 1970 to 23:59:59, December 31, 3000. This adjustment may cause these functions to return -1 (cast to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) even though the date you specify is within range. For example, if you are in Cairo, Egypt, which is two hours ahead of UTC, two hours will first be subtracted from the date you specify in *timeptr*; this may now put your date out of range.  
  
 These functions may be used to validate and fill in a tm structure. If successful, these functions set the values of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> as appropriate and set the other components to represent the specified calendar time, but with their values forced to the normal ranges. The final value of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is not set until <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are determined. When specifying a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> structure time, set the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> field to:  
  
-   Zero (0) to indicate that standard time is in effect.  
  
-   A value greater than 0 to indicate that daylight saving time is in effect.  
  
-   A value less than zero to have the C run-time library code compute whether standard time or daylight saving time is in effect.  
  
 The C run-time library will determine the daylight savings time behavior from the [TZ](../vs140/_tzset.md) environment variable. If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is not set, the Win32 API call [GetTimeZoneInformation](http://msdn.microsoft.com/library/windows/desktop/ms724421.aspx) is used to get the daylight savings time information from the operating system. If this fails, the library assumes the United States' rules for implementing the calculation of daylight saving time are used. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a required field. If not set, its value is undefined and the return value from these functions is unpredictable. If *timeptr* points to a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> structure returned by a previous call to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> (or variants of these functions), the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> field contains the correct value.  
  
 Note that <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> (and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>) use a single buffer per thread for the conversion. If you supply this buffer to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, the previous contents are destroyed.  
  
 These functions validate their parameter. If *timeptr* is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<time.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 \<xref:System.DateTimeOffset.#ctor*>  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [_mkgmtime, _mkgmtime32, _mkgmtime64](../vs140/_mkgmtime--_mkgmtime32--_mkgmtime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)