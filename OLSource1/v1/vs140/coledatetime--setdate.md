---
title: "COleDateTime::SetDate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleDateTime::SetDate"
  - "SetDate"
  - "ATL::COleDateTime::SetDate"
  - "COleDateTime.SetDate"
  - "ATL.COleDateTime.SetDate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setDate method"
ms.assetid: 76e8466b-897a-4144-a545-4ccdc1bb035d
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::SetDate
Sets the date of this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Indicate the date components to be copied into this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Zero if the value of this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object was set successfully; otherwise, 1. This return value is based on the **DateTimeStatus** enumerated type. For more information, see the [SetStatus](../vs140/coledatetime--setstatus.md) member function.  
  
## Remarks  
 The date is set to the specified values. The time is set to time 0, midnight.  
  
 See the following table for bounds for the parameter values:  
  
|Parameter|Bounds|  
|---------------|------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|100 – 9999|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|1 – 12|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|0 – 31|  
  
 If the day of the month overflows, it is converted to the correct day of the next month and the month and/or year is incremented accordingly. A day value of zero indicates the last day of the previous month. The behavior is the same as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 If the date value specified by the parameters is not valid, the status of this object is set to **COleDateTime::invalid**. You should use [GetStatus](../vs140/coledatetime--getstatus.md) to check the validity of the **DATE** value and should not assume that the value of [m_dt](../vs140/coledatetime--m_dt.md) will remain unmodified.  
  
 Here are some examples of date values:  
  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Value|  
|-------------|--------------|------------|-----------|  
|2000|2|29|29 February 2000|  
|1776|7|4|4 July 1776|  
|1925|4|35|35 April 1925 (invalid date)|  
|10000|1|1|1 January 10000 (invalid date)|  
  
 To set both date and time, see [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md).  
  
 For information on member functions that query the value of this <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
 For more information about the bounds for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#11](../vs140/codesnippet/CPP/coledatetime--setdate_1.cpp)]  
  
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