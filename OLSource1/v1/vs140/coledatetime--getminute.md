---
title: "COleDateTime::GetMinute"
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
  - COleDateTime.GetMinute
  - COleDateTime::GetMinute
  - ATL::COleDateTime::GetMinute
  - ATL.COleDateTime.GetMinute
  - GetMinute
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetMinute method
ms.assetid: 26370967-45b4-4bbd-9cb6-09909510c00b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTime::GetMinute
Gets the minute represented by this date/time value.  
  
## Syntax  
  
```  
  
int GetMinute( ) const throw( );  
  
```  
  
## Return Value  
 The minute represented by the value of this `COleDateTime` object or `COleDateTime::error` if the minute could not be obtained.  
  
## Remarks  
 Valid return values range between 0 and 59.  
  
 For information on other member functions that query the value of this `COleDateTime` object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
## Example  
 See the example for [GetHour](../vs140/coledatetime--gethour.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)