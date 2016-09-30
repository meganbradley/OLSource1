---
title: "asctime_s, _wasctime_s"
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
  - "_wasctime_s"
  - "asctime_s"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "asctime_s"
  - "_wasctime_s"
  - "_tasctime_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tasctime_s function"
  - "_tasctime_s function"
  - "time structure conversion"
  - "wasctime_s function"
  - "time, converting"
  - "_wasctime_s function"
  - "asctime_s function"
ms.assetid: 17ad9b2b-a459-465d-976a-42822897688a
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# asctime_s, _wasctime_s
Convert a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> time structure to a character string. These functions are versions of [asctime, _wasctime](../vs140/asctime--_wasctime.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] A pointer to a buffer to store the character string result. This function assumes a pointer to a valid memory location with a size specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The size of the buffer used to store the result.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Time/date structure. This function assumes a pointer to a valid <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Zero if successful. If there is a failure, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the return value is an error code. Error codes are defined in ERRNO.H. For more information, see [errno Constants](../vs140/errno-constants.md). The actual error codes returned for each error condition are shown in the following table.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Return|Value in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|--------------|------------------------|----------|------------|-----------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Any|Any|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Not modified|  
|Not<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (points to valid memory)|0|Any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Not modified|  
|Not <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|0< size < 26|Any|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Empty string|  
|Not <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|>= 26|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Empty string|  
|Not <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|>= 26|Invalid time structure or out of range values for components of the time|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Empty string|  
  
> [!NOTE]
>  Error conditions for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> are similar to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> with the exception that the size limit is measured in words.  
  
## Remarks  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function converts a time stored as a structure to a character string. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value is usually obtained from a call to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. Both functions can be used to fill in a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> structure, as defined in TIME.H.  
  
|timeptr member|Value|  
|--------------------|-----------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Hours since midnight (0–23)|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Positive if daylight saving time is in effect; 0 if daylight saving time is not in effect; negative if status of daylight saving time is unknown. The C run-time library assumes the United States' rules for implementing the calculation of Daylight Saving Time (DST).|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Day of month (1–31)|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Minutes after hour (0–59)|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Month (0–11; January = 0)|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Seconds after minute (0–59)|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Day of week (0–6; Sunday = 0)|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Day of year (0–365; January 1 = 0)|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Year (current year minus 1900)|  
  
 The converted character string is also adjusted according to the local time zone settings. See the [time, _time32, _time64](../vs140/time--_time32--_time64.md), [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md), and [localtime_s, _localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md) functions for information about configuring the local time and the [_tzset](../vs140/_tzset.md) function for information about defining the time zone environment and global variables.  
  
 The string result produced by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> contains exactly 26 characters and has the form <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. A 24-hour clock is used. All fields have a constant width. The new line character and the null character occupy the last two positions of the string. The value passed in as the second parameter should be at least this big. If it is less, an error code, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, will be returned.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mapping  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
  
## Security  
 If the buffer pointer is not <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and the pointer does not point to a valid buffer, the function will overwrite whatever is at the location. This can also result in an access violation.  
  
 A [buffer overrun](http://msdn.microsoft.com/library/windows/desktop/ms717795) can occur if the size argument passed in is greater than the actual size of the buffer.  
  
## Example  
 This program places the system time in the long integer <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, translates it into the structure <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and then converts it to string form for output, using the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Current date and time: Wed May 14 15:30:17 2003**   
## .NET Framework Equivalent  
  
-   \<xref:System.DateTime.ToLongDateString*?displayProperty=fullName>  
  
-   \<xref:System.DateTime.ToLongTimeString*?displayProperty=fullName>  
  
-   \<xref:System.DateTime.ToShortDateString*?displayProperty=fullName>  
  
-   \<xref:System.DateTime.ToShortTimeString*?displayProperty=fullName>  
  
-   \<xref:System.DateTime.ToString*?displayProperty=fullName>  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [ctime_s, _ctime32_s, _ctime64_s, _wctime_s, _wctime32_s, _wctime64_s](../vs140/ctime_s--_ctime32_s--_ctime64_s--_wctime_s--_wctime32_s--_wctime64_s.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime_s, _gmtime32_s, _gmtime64_s](../vs140/gmtime_s--_gmtime32_s--_gmtime64_s.md)   
 [localtime_s, _localtime32_s, _localtime64_s](../vs140/localtime_s--_localtime32_s--_localtime64_s.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)   
 [_tzset](../vs140/_tzset.md)