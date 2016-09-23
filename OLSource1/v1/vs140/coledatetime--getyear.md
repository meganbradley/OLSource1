---
title: "COleDateTime::GetYear"
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
  - ATL.COleDateTime.GetYear
  - COleDateTime::GetYear
  - COleDateTime.GetYear
  - ATL::COleDateTime::GetYear
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetYear method
ms.assetid: f2009137-1673-4fb9-862e-bd9eb88e9224
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTime::GetYear
Gets the year represented by this date/time value.  
  
## Syntax  
  
```  
  
int GetYear( ) const throw( );  
  
```  
  
## Return Value  
 The year represented by the value of this `COleDateTime` object or `COleDateTime::error` if the year could not be obtained.  
  
## Remarks  
 Valid return values range between 100 and 9999, which includes the century.  
  
 For information on other member functions that query the value of this `COleDateTime` object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
 For more information about the bounds for `COleDateTime` values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Example  
 See the example for [GetDay](../vs140/coledatetime--getday.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)