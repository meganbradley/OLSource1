---
title: "_mkgmtime, _mkgmtime32, _mkgmtime64"
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
  - "_mkgmtime32"
  - "_mkgmtime64"
  - "_mkgmtime"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mkgmtime64"
  - "mkgmtime32"
  - "_mkgmtime32"
  - "mkgmtime"
  - "mkgmtime64"
  - "_mkgmtime"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mkgmtime32 function"
  - "time functions"
  - "mkgmtime function"
  - "_mkgmtime function"
  - "converting times"
  - "mkgmtime64 function"
  - "_mkgmtime64 function"
  - "_mkgmtime32 function"
  - "time, converting"
ms.assetid: b4ca2b67-e198-4f43-b3e2-e8ad6bd01867
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _mkgmtime, _mkgmtime32, _mkgmtime64
Converts a UTC time represented by a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to a UTC time represented by a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the UTC time as a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to convert.  
  
## Return Value  
 A quantity of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> representing the number of seconds elapsed since midnight, January 1, 1970, in Coordinated Universal Time (UTC). If the date is out of range (see the Remarks section) or the input cannot be interpreted as a valid time, the return value is –1.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> functions convert a UTC time to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> type representing the time in UTC. To convert a local time to UTC time, use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> instead.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is an inline function that evaluates to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If you need to force the compiler to interpret <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>as the old 32-bit <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, you can define <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This is not recommended because your application might fail after January 18, 2038 (the maximum range of a 32-bit <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>), and it is not allowed at all on 64-bit platforms.  
  
 The time structure passed in will be changed as follows, in the same way as they are changed with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> functions: the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> fields are set to new values based on the values of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. When specifying a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structure time, set the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> field to:  
  
-   Zero (0) to indicate that standard time is in effect.  
  
-   A value greater than 0 to indicate that daylight saving time is in effect.  
  
-   A value less than zero to have the C run-time library code compute whether standard time or daylight saving time is in effect.  
  
 The C run-time library uses the TZ environment variable to determine the correct daylight savings time. If TZ is not set, the operating system is queried to get the correct regional daylight savings time behavior. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a required field. If not set, its value is undefined and the return value from <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is unpredictable.  
  
 The range of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> function is from midnight, January 1, 1970, UTC to 23:59:59 January 18, 2038, UTC. The range of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is from midnight, January 1, 1970, UTC to 23:59:59, December 31, 3000, UTC. An out-of-range date results in a return value of –1. The range of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> depends on whether <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is defined. If not defined (the default) the range is that of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>; otherwise, the range is limited to the 32-bit range of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 Note that <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> use a single statically allocated buffer for the conversion. If you supply this buffer to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, the previous contents are destroyed.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example shows how the incomplete structure is filled out with the computed values of the day of the week and the day of the year.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [asctime_s, _wasctime_s](../vs140/asctime_s--_wasctime_s.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [_gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [_localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)   
 [mktime, _mktime32, _mktime64](../vs140/mktime--_mktime32--_mktime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)