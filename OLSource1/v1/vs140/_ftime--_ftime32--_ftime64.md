---
title: "_ftime, _ftime32, _ftime64"
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
  - "_ftime64"
  - "_ftime"
  - "_ftime32"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ftime32"
  - "_ftime"
  - "_ftime64"
  - "ftime64"
  - "ftime"
  - "ftime32"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ftime64 function"
  - "_ftime64 function"
  - "current time"
  - "_ftime function"
  - "ftime function"
  - "_ftime32 function"
  - "ftime32 function"
  - "time, getting current"
ms.assetid: 96bc464c-3bcd-41d5-a212-8bbd836b814a
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ftime, _ftime32, _ftime64
Get the current time. More secure versions of these functions are available; see [_ftime_s, _ftime32_s, _ftime64_s](../vs140/_ftime_s--_ftime32_s--_ftime64_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function gets the current local time and stores it in the structure pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>*.* The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,and<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structures are defined in SYS\Timeb.h. They contain four fields, which are listed in the following table.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Nonzero if daylight savings time is currently in effect for the local time zone. (See [_tzset](../vs140/_tzset.md) for an explanation of how daylight savings time is determined.)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Fraction of a second in milliseconds.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Time in seconds since midnight (00:00:00), January 1, 1970, coordinated universal time (UTC).  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Difference in minutes, moving westward, between UTC and local time. The value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set from the value of the global variable <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (see <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> structure, allows file-creation dates to be expressed up through 23:59:59, December 31, 3000, UTC; whereas <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> only represents dates through 23:59:59 January 18, 2038, UTC. Midnight, January 1, 1970, is the lower bound of the date range for all these functions.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> contains a 64-bit time. This is true unless <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is defined, in which case the old behavior is in effect; <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> uses a 32-bit time and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> contains a 32-bit time.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> validates its parameters. If passed a null pointer as <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, the function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function sets <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<sys/types.h> and \<sys/timeb.h>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<sys/types.h> and \<sys/timeb.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<sys/types.h> and \<sys/timeb.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
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