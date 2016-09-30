---
title: "_ftime_s, _ftime32_s, _ftime64_s"
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
  - "_ftime_s"
  - "_ftime64_s"
  - "_ftime32_s"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ftime_s"
  - "_ftime64_s"
  - "ftime_s"
  - "_ftime32_s"
  - "ftime32_s"
  - "ftime64_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ftime32_s function"
  - "ftime_s function"
  - "_ftime64_s function"
  - "current time"
  - "ftime64_s function"
  - "time, getting current"
  - "_ftime_s function"
  - "_ftime32_s function"
ms.assetid: d03080d9-a520-45be-aa65-504bdb197e8b
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _ftime_s, _ftime32_s, _ftime64_s
Gets the current time. These are versions of [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 Zero if successful, an error code on failure. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the return value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function gets the current local time and stores it in the structure pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>*.* The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>,and<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structures are defined in SYS\Timeb.h. They contain four fields, which are listed in the following table.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Nonzero if daylight savings time is currently in effect for the local time zone. (See [_tzset](../vs140/_tzset.md) for an explanation of how daylight savings time is determined.)  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Fraction of a second in milliseconds.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Time in seconds since midnight (00:00:00), January 1, 1970, coordinated universal time (UTC).  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Difference in minutes, moving westward, between UTC and local time. The value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set from the value of the global variable <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (see <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> structure, allows file-creation dates to be expressed up through 23:59:59, December 31, 3000, UTC; whereas <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> only represents dates through 23:59:59 January 18, 2038, UTC. Midnight, January 1, 1970, is the lower bound of the date range for all these functions.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> contains a 64-bit time. This is true unless _<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is defined, in which case the old behavior is in effect; \_<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> uses a 32-bit time and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> contains a 32-bit time.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> validates its parameters. If passed a null pointer as <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function sets <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<sys/types.h> and \<sys/timeb.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<sys/types.h> and \<sys/timeb.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<sys/types.h> and \<sys/timeb.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Seconds since midnight, January 1, 1970 (UTC): 1051553334**  
**Milliseconds: 230**  
**Minutes between UTC and local time: 480**  
**Daylight savings time flag (1 means Daylight time is in effect): 1**  
**The time is Mon Apr 28 11:08:54.230 2003**   
## .NET Framework Equivalent  
 [System::DateTime::Now](https://msdn.microsoft.com/en-us/library/system.datetime.now.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)