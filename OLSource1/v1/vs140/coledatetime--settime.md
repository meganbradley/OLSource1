---
title: "COleDateTime::SetTime"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleDateTime.SetTime
  - ATL.COleDateTime.SetTime
  - ATL::COleDateTime::SetTime
  - COleDateTime::SetTime
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetTime method
ms.assetid: bc6dadcf-d90d-4235-b791-82e7312ad7ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTime::SetTime
Sets the time of this `COleDateTime` object.  
  
## Syntax  
  
```  
  
      int SetTime(  
   int nHour,  
   int nMin,  
   int nSec   
) throw( );  
```  
  
#### Parameters  
 `nHour`, `nMin`, `nSec`  
 Indicate the time components to be copied into this `COleDateTime` object.  
  
## Return Value  
 Zero if the value of this `COleDateTime` object was set successfully; otherwise, 1. This return value is based on the **DateTimeStatus** enumerated type. For more information, see the [SetStatus](../vs140/coledatetime--setstatus.md) member function.  
  
## Remarks  
 The time is set to the specified values. The date is set to date 0, meaning 30 December 1899.  
  
 See the following table for bounds for the parameter values:  
  
|Parameter|Bounds|  
|---------------|------------|  
|`nHour`|0 – 23|  
|`nMin`|0 – 59|  
|`nSec`|0 – 59|  
  
 If the time value specified by the parameters is not valid, the status of this object is set to invalid and the value of this object is not changed.  
  
 Here are some examples of time values:  
  
|`nHour`|`nMin`|`nSec`|Value|  
|-------------|------------|------------|-----------|  
|1|3|3|01:03:03|  
|23|45|0|23:45:00|  
|25|30|0|Invalid|  
|9|60|0|Invalid|  
  
 To set both date and time, see [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md).  
  
 For information on member functions that query the value of this `COleDateTime` object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
 For more information about the bounds for `COleDateTime` values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Example  
 See the example for [SetDate](../vs140/coledatetime--setdate.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)   
 [COleDateTime::m_dt](../vs140/coledatetime--m_dt.md)