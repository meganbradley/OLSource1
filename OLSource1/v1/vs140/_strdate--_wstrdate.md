---
title: "_strdate, _wstrdate"
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
  - "_strdate"
  - "_wstrdate"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tstrdate"
  - "wstrdate"
  - "_wstrdate"
  - "_strdate"
  - "strdate"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strdate function"
  - "dates, copying"
  - "tstrdate function"
  - "_wstrdate function"
  - "wstrdate function"
  - "_strdate function"
  - "_tstrdate function"
  - "copying dates"
ms.assetid: de8e4097-58f8-42ba-9dcd-cb4d9a9f1696
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strdate, _wstrdate
Copy current system date to a buffer. More secure versions of these functions are available; see [_strdate_s, _wstrdate_s](../vs140/_strdate_s--_wstrdate_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a buffer containing the formatted date string.  
  
## Return Value  
 Each of these functions returns a pointer to the resulting character string <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 More secure versions of these functions are available; see [_strdate_s, _wstrdate_s](../vs140/_strdate_s--_wstrdate_s.md). It is recommended that the more secure functions be used wherever possible.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function copies the current system date to the buffer pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, formatted <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is two digits representing the month, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is two digits representing the day, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the last two digits of the year. For example, the string <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> represents December 5, 1999. The buffer must be at least 9 bytes long.  
  
 If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>; the argument and return value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are wide-character strings. These functions behave identically otherwise.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<time.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **OS date: 04/25/03**   
## .NET Framework Equivalent  
 [System::DateTime::Parse](https://msdn.microsoft.com/en-us/library/system.datetime.parse.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [mktime, _mktime32, _mktime64](../vs140/mktime--_mktime32--_mktime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)   
 [_tzset](../vs140/_tzset.md)