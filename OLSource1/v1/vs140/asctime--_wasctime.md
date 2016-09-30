---
title: "asctime, _wasctime"
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
  - "_wasctime"
  - "asctime"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tasctime"
  - "asctime"
  - "_wasctime"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "asctime function"
  - "tasctime function"
  - "wasctime function"
  - "_tasctime function"
  - "_wasctime function"
  - "time structure conversion"
  - "time, converting"
ms.assetid: 974f1727-10ff-4ed4-8cac-2eb2d681f576
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# asctime, _wasctime
Convert a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> time structure to a character string. More secure versions of these functions are available; see [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Time/date structure.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns a pointer to the character string result; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a pointer to the wide-character string result. There is no error return value.  
  
## Remarks  
 More secure versions of these functions are available; see [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md).  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function converts a time stored as a structure to a character string. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value is usually obtained from a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which both return a pointer to a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure, defined in TIME.H.  
  
|timeptr member|Value|  
|--------------------|-----------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Hours since midnight (0–23)|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Positive if daylight saving time is in effect; 0 if daylight saving time is not in effect; negative if status of daylight saving time is unknown. The C run-time library assumes the United States' rules for implementing the calculation of Daylight Saving Time (DST).|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Day of month (1–31)|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Minutes after hour (0–59)|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Month (0–11; January = 0)|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Seconds after minute (0–59)|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Day of week (0–6; Sunday = 0)|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Day of year (0–365; January 1 = 0)|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Year (current year minus 1900)|  
  
 The converted character string is also adjusted according to the local time zone settings. For information about configuring the local time, see the [time](../vs140/time--_time32--_time64.md), [_ftime](../vs140/_ftime--_ftime32--_ftime64.md), and [localtime](../vs140/localtime--_localtime32--_localtime64.md) functions and the [_tzset](../vs140/_tzset.md) function for information about defining the time zone environment and global variables.  
  
 The string result produced by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> contains exactly 26 characters and has the form <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. A 24-hour clock is used. All fields have a constant width. The newline character and the null character occupy the last two positions of the string. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> uses a single, statically allocated buffer to hold the return string. Each call to this function destroys the result of the previous call.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> behave identically otherwise.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a null pointer, or if it contains out-of-range values, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mapping  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
  
## Example  
 This program places the system time in the long integer <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, translates it into the structure <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and then converts it to string form for output, using the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Current date and time: Sun Feb 03 11:38:58 2002**   
## .NET Framework Equivalent  
  
-   [System::DateTime::ToLongDateString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongdatestring.aspx)  
  
-   [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx)  
  
-   [System::DateTime::ToShortDateString](https://msdn.microsoft.com/en-us/library/system.datetime.toshortdatestring.aspx)  
  
-   [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx)  
  
-   [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)   
 [_tzset](../vs140/_tzset.md)   
 [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)