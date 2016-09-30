---
title: "ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64"
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
  - "_ctime64"
  - "_wctime32"
  - "ctime"
  - "_wctime64"
  - "_ctime32"
  - "_wctime"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wctime64"
  - "_ctime32"
  - "_tctime"
  - "_wctime"
  - "_wctime32"
  - "_tctime64"
  - "_ctime64"
  - "ctime"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tctime64 function"
  - "_ctime32 function"
  - "ctime32 function"
  - "_wctime function"
  - "wctime64 function"
  - "_tctime64 function"
  - "_tctime32 function"
  - "_ctime64 function"
  - "_wctime64 function"
  - "ctime function"
  - "wctime32 function"
  - "ctime64 function"
  - "_wctime32 function"
  - "_tctime function"
  - "tctime32 function"
  - "tctime function"
  - "wctime function"
  - "time, converting"
ms.assetid: 2423de37-a35c-4f0a-a378-3116bc120a9d
caps.latest.revision: 27
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64
Convert a time value to a string and adjust for local time zone settings. More secure versions of these functions are available; see [ctime_s, _ctime32_s, _ctime64_s, _wctime32_s, _wctime64_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to stored time.  
  
## Return Value  
 A pointer to the character string result. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be returned if:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> represents a date before midnight, January 1, 1970, UTC.  
  
-   If you use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> represents a date after 23:59:59 January 18, 2038, UTC.  
  
-   If you use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> represents a date after 23:59:59, December 31, 3000, UTC.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is an inline function which evaluates to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If you need to force the compiler to interpret <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> as the old 32-bit <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Doing this will cause <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to evaluate to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. This is not recommended because your application may fail after January 18, 2038, and it is not allowed on 64-bit platforms.  
  
## Remarks  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function converts a time value stored as a [time_t](../vs140/standard-types.md) value into a character string. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value is usually obtained from a call to [time](../vs140/time--_time32--_time64.md), which returns the number of seconds elapsed since midnight (00:00:00), January 1, 1970, coordinated universal time (UTC). The return value string contains exactly 26 characters and has the form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A 24-hour clock is used. All fields have a constant width. The newline character ('\n') and the null character ('\0') occupy the last two positions of the string.  
  
 The converted character string is also adjusted according to the local time zone settings. See the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, [_ftime](../vs140/_ftime--_ftime32--_ftime64.md), and [localtime](../vs140/localtime--_localtime32--_localtime64.md) functions for information on configuring the local time and the [_tzset](../vs140/_tzset.md) function for details about defining the time zone environment and global variables.  
  
 A call to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> modifies the single statically allocated buffer used by the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> functions. Each call to one of these routines destroys the result of the previous call. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> shares a static buffer with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function. Thus, a call to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> destroys the results of any previous call to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> are the wide-character version of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>; returning a pointer to wide-character string. Otherwise, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> behave identically to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is a null pointer, or if the timer value is negative, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **The time is Wed Feb 13 16:04:43 2002**   
## .NET Framework Equivalent  
  
-   [System::DateTime::GetDateTimeFormats](https://msdn.microsoft.com/en-us/library/system.datetime.getdatetimeformats.aspx)  
  
-   [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)  
  
-   [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx)  
  
-   [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [ctime_s, _ctime32_s, _ctime64_s, _wctime_s, _wctime32_s, _wctime64_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)