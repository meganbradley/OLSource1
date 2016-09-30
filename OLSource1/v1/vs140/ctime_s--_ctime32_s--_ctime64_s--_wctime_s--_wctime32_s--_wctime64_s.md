---
title: "ctime_s, _ctime32_s, _ctime64_s, _wctime_s, _wctime32_s, _wctime64_s"
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
  - "_ctime64_s"
  - "_wctime32_s"
  - "ctime_s"
  - "_wctime64_s"
  - "_ctime32_s"
  - "_wctime_s"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ctime64_s"
  - "_ctime32_s"
  - "_tctime32_s"
  - "_ctime64_s"
  - "_wctime_s"
  - "_tctime_s"
  - "_tctime64_s"
  - "ctime_s"
  - "ctime32_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wctime32_s function"
  - "ctime64_s function"
  - "_tctime64_s function"
  - "_wctime_s function"
  - "tctime_s function"
  - "_wctime64_s function"
  - "ctime_s function"
  - "ctime32_s function"
  - "_ctime64_s function"
  - "tctime64_s function"
  - "wctime64_s function"
  - "wctime_s function"
  - "_tctime_s function"
  - "tctime32_s function"
  - "wctime32_s function"
  - "time, converting"
  - "_ctime32_s function"
  - "_tctime32_s function"
ms.assetid: 36ac419a-8000-4389-9fd8-d78b747a009b
caps.latest.revision: 31
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ctime_s, _ctime32_s, _ctime64_s, _wctime_s, _wctime32_s, _wctime64_s
Convert a time value to a string and adjust for local time zone settings. These are versions of [ctime, _ctime64, _wctime, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Must be large enough to hold 26 characters. A pointer to the character string result, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>if:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> represents a date before midnight, January 1, 1970, UTC.  
  
-   If you use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> represents a date after 23:59:59 January 18, 2038, UTC.  
  
-   If you use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> represents a date after 23:59:59, December 31, 3000, UTC.  
  
-   If you use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, these functions are wrappers to the previous functions. See the Remarks section.  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The size of the buffer.  
  
 [in] t<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Pointer to stored time.  
  
## Return Value  
 Zero if successful. If there is a failure due to an invalid parameter, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, an error code is returned. Error codes are defined in ERRNO.H; for a listing of these errors, see [errno](../vs140/errno-constants.md). The actual error codes thrown for each error condition are shown in the following table.  
  
## Error Conditions  
  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Return|Value in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|--------------|------------------------|------------|------------|-----------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Not modified|  
|Not <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (points to valid memory)|0|any|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Not modified|  
|Not <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|0< size < 26|any|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Empty string|  
|Not <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|>= 26|NULL|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Empty string|  
|Not <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|>= 26|< 0|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Empty string|  
  
## Remarks  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function converts a time value stored as a [time_t](../vs140/standard-types.md) structure into a character string. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> value is usually obtained from a call to [time](../vs140/time--_time32--_time64.md), which returns the number of seconds elapsed since midnight (00:00:00), January 1, 1970, coordinated universal time (UTC). The return value string contains exactly 26 characters and has the form:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A 24-hour clock is used. All fields have a constant width. The new line character ('\n') and the null character ('\0') occupy the last two positions of the string.  
  
 The converted character string is also adjusted according to the local time zone settings. See the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, [_ftime](../vs140/_ftime--_ftime32--_ftime64.md), and [localtime32_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md) functions for information about configuring the local time and the [_tzset](../vs140/_tzset.md) function for information about defining the time zone environment and global variables.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> are the wide-character version of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>; returning a pointer to wide-character string. Otherwise, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> behave identically to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is an inline function that evaluates to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. If you need to force the compiler to interpret <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> as the old 32-bit <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. Doing this will cause <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to evaluate to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. This is not recommended because your application may fail after January 18, 2038, and it is not allowed on 64-bit platforms.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::DateTime::GetDateTimeFormats](https://msdn.microsoft.com/en-us/library/system.datetime.getdatetimeformats.aspx)  
  
-   [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)  
  
-   [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx)  
  
-   [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime_s, _gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [localtime_s, _localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)