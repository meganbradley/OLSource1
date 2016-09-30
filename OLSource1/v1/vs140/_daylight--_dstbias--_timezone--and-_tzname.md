---
title: "_daylight, _dstbias, _timezone, and _tzname"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "tzname"
  - "_timezone"
  - "timezone"
  - "_daylight"
  - "_tzname"
  - "daylight"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "time zones"
  - "time adjustments"
  - "timezone variables"
  - "_tzname function"
  - "_daylight function"
  - "_timezone function"
  - "daylight function"
  - "local time adjustments"
  - "timezone function"
  - "tzname function"
  - "time-zone variables"
ms.assetid: d06c7292-6b99-4aba-b284-16a96570c856
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _daylight, _dstbias, _timezone, and _tzname
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are used in some time and date routines to make local-time adjustments. These global variables have been deprecated for the more secure functional versions, which should be used in place of the global variables.  
  
|Global variable|Functional equivalent|  
|---------------------|---------------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[_get_daylight](../vs140/_get_daylight.md)|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|[_get_dstbias](../vs140/_get_dstbias.md)|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|[_get_timezone](../vs140/_get_timezone.md)|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|[_get_tzname](../vs140/_get_tzname.md)|  
  
 They are declared in Time.h as follows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 On a call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the values of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are determined from the value of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> environment variable. If you do not explicitly set the value of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> contain the default settings of "PST" and "PDT" respectively.  The time-manipulation functions ([_tzset](../vs140/_tzset.md), [_ftime](../vs140/_ftime--_ftime32--_ftime64.md), and [localtime](../vs140/localtime--_localtime32--_localtime64.md)) attempt to set the values of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> by querying the operating system for the default value of each variable. The time-zone global variable values are shown in the following table.  
  
|Variable|Value|  
|--------------|-----------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Nonzero if daylight saving time (DST) zone is specified in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or determined from the operating system; otherwise, 0. The default value is 1.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Offset for daylight saving time.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Difference in seconds between coordinated universal time and local time. The default value is 28,800.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Time-zone name derived from the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> environment variable. The default value is "PST".|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|DST zone name derived from the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> environment variable. The default value is "PDT" (Pacific daylight time).|  
  
## See Also  
 [Global Variables](../vs140/global-variables.md)   
 [_get_daylight](../vs140/_get_daylight.md)   
 [_get_dstbias](../vs140/_get_dstbias.md)   
 [_get_timezone](../vs140/_get_timezone.md)   
 [_get_tzname](../vs140/_get_tzname.md)