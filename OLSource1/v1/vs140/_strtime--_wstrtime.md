---
title: "_strtime, _wstrtime"
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
  - "_wstrtime"
  - "_strtime"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wstrtime"
  - "_strtime"
  - "wstrtime"
  - "strtime"
  - "_tstrtime"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strtime function"
  - "_strtime function"
  - "_wstrtime function"
  - "copying time to buffers"
  - "wstrtime function"
  - "tstrtime function"
  - "_tstrtime function"
  - "time, copying"
ms.assetid: 9e538161-cf49-44ec-bca5-c0ab0b9e4ca3
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strtime, _wstrtime
Copy the time to a buffer. More secure versions of these functions are available; see [_strtime_s, _wstrtime_s](../vs140/_strtime_s--_wstrtime_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Time string.  
  
## Return Value  
 Returns a pointer to the resulting character string <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function copies the current local time into the buffer pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>*.* The time is formatted as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is two digits representing the hour in 24-hour notation, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is two digits representing the minutes past the hour, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is two digits representing seconds. For example, the string <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> represents 23 minutes and 44 seconds past 6 P.M. The buffer must be at least 9 bytes long.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>; the argument and return value of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are wide-character strings. These functions behave identically otherwise.If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> pointer or if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is formatted incorrectly, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If the exception is allowed to continue, these functions return a NULL and set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> was a NULL or set <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is formatted incorrectly.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The current time is 14:21:44**   
## .NET Framework Equivalent  
  
-   [System::DateTime::ToLongDateString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongdatestring.aspx)  
  
-   [System::DateTime::ToLongTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.tolongtimestring.aspx)  
  
-   [System::DateTime::ToShortDateString](https://msdn.microsoft.com/en-us/library/system.datetime.toshortdatestring.aspx)  
  
-   [System::DateTime::ToShortTimeString](https://msdn.microsoft.com/en-us/library/system.datetime.toshorttimestring.aspx)  
  
-   [System::DateTime::ToString](https://msdn.microsoft.com/en-us/library/system.datetime.tostring.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [mktime, _mktime32, _mktime64](../vs140/mktime--_mktime32--_mktime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)   
 [_tzset](../vs140/_tzset.md)