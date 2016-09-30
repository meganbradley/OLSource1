---
title: "_tzset"
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
  - "_tzset"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tzset"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tzset function"
  - "time environment variables"
  - "environment variables, setting time"
ms.assetid: 3f6ed537-b414-444d-b272-5dd377481930
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _tzset
Sets time environment variables.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see                  [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function uses the current setting of the environment variable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to assign values to three global variables: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. These variables are used by the [_ftime](../vs140/_ftime--_ftime32--_ftime64.md) and [localtime](../vs140/localtime--_localtime32--_localtime64.md) functions to make corrections from coordinated universal time (UTC) to local time, and by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function to compute UTC from system time. Use the following syntax to set the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> environment variable:  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>=<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[+ &#124; –]<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>] ][<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>]  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Three-letter time-zone name, such as PST. You must specify the correct offset from local time to UTC.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Difference in hours between UTC and local time. Sign (+) optional for positive values.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Minutes. Separated from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> by a colon (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Seconds. Separated from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> by a colon (<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Three-letter daylight-saving-time zone such as PDT. If daylight saving time is never in effect in the locality, set <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> without a value for <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The C run-time library assumes the United States' rules for implementing the calculation of daylight saving time (DST).  
  
> [!NOTE]
>  Take care in computing the sign of the time difference. Because the time difference is the offset from local time to UTC (rather than the reverse), its sign may be the opposite of what you might intuitively expect. For time zones ahead of UTC, the time difference is negative; for those behind UTC, the difference is positive.  
  
 For example, to set the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> environment variable to correspond to the current time zone in Germany, enter the following on the command line:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This command uses GST to indicate German standard time, assumes that UTC is one hour behind Germany (or in other words, that Germany is one hour ahead of UTC), and assumes that Germany observes daylight-saving time.  
  
 If the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value is not set, _<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> attempts to use the time zone information specified by the operating system. In the Windows operating system, this information is specified in the Date/Time application in Control Panel. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> cannot obtain this information, it uses PST8PDT by default, which signifies the Pacific Time zone.  
  
 Based on the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> environment variable value, the following values are assigned to the global variables <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is called:  
  
|Global variable|Description|Default value|  
|---------------------|-----------------|-------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Nonzero value if a daylight-saving-time zone is specified in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> setting; otherwise, 0.|1|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Difference in seconds between local time and UTC.|28800 (28800 seconds equals 8 hours)|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>[0]|String value of time-zone name from <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> environmental variable; empty if <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> has not been set.|PST|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>[1]|String value of daylight-saving-time zone; empty if daylight-saving-time zone is omitted from <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> environmental variable.|PDT|  
  
 The default values shown in the preceding table for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> array correspond to "PST8PDT." If the DST zone is omitted from the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> environmental variable, the value of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is 0 and the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> functions return 0 for their DST flags.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<time.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **_daylight = 1**  
**_timezone = 28800**  
**_tzname[0] = Pacific Standard Time**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)   
 [_utime, _utime32 _utime64, _wutime, _wutime32, _wutime64](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md)