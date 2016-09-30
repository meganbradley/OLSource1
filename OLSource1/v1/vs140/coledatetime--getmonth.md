---
title: "COleDateTime::GetMonth"
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
  - "ATL::COleDateTime::GetMonth"
  - "COleDateTime::GetMonth"
  - "COleDateTime.GetMonth"
  - "ATL.COleDateTime.GetMonth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMonth method"
ms.assetid: 9a41a1e8-9e90-43af-9d54-dd0ba60efb47
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetMonth
Gets the month represented by this date/time value.  
  
## Syntax  
  
```  
  
int GetMonth( ) const throw( );  
  
```  
  
## Return Value  
 The month represented by the value of this `COleDateTime` object or `COleDateTime::error` if the month could not be obtained.  
  
## Remarks  
 Valid return values range between 1 and 12.  
  
 For information on other member functions that query the value of this `COleDateTime` object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
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