---
title: "COleDateTime::GetHour"
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
  - ATL::COleDateTime::GetHour
  - COleDateTime::GetHour
  - ATL.COleDateTime.GetHour
  - COleDateTime.GetHour
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHour method
ms.assetid: d6d303a5-5f61-4ee5-a6bd-9cf012399c3a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTime::GetHour
Gets the hour represented by this date/time value.  
  
## Syntax  
  
```  
  
int GetHour( ) const throw( );  
  
```  
  
## Return Value  
 The hour represented by the value of this `COleDateTime` object or `COleDateTime::error` if the hour could not be obtained.  
  
## Remarks  
 Valid return values range between 0 and 23.  
  
 For information on other member functions that query the value of this `COleDateTime` object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#9](../vs140/codesnippet/CPP/coledatetime--gethour_1.cpp)]
  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)