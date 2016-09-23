---
title: "COleDateTimeSpan::GetTotalMinutes"
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
  - COleDateTimeSpan::GetTotalMinutes
  - COleDateTimeSpan.GetTotalMinutes
  - GetTotalMinutes
  - ATL::COleDateTimeSpan::GetTotalMinutes
  - ATL.COleDateTimeSpan.GetTotalMinutes
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTotalMinutes method
ms.assetid: 1b9a530d-ca75-4c3a-b827-5349ef5ca969
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTimeSpan::GetTotalMinutes
Retrieves this date/time-span value expressed in minutes.  
  
## Syntax  
  
```  
  
double GetTotalMinutes( ) const throw( );  
  
```  
  
## Return Value  
 This date/time-span value expressed in minutes. Although this function is prototyped to return a double, it will always return an integer value.  
  
## Remarks  
 The return values from this function range between approximately – 5.26e9 and 5.26e9.  
  
 For other functions that query the value of a `COleDateTimeSpan` object, see the following member functions:  
  
-   [GetDays](../vs140/coledatetimespan--getdays.md)  
  
-   [GetHours](../vs140/coledatetimespan--gethours.md)  
  
-   [GetMinutes](../vs140/coledatetimespan--getminutes.md)  
  
-   [GetSeconds](../vs140/coledatetimespan--getseconds.md)  
  
-   [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md)  
  
-   [GetTotalHours](../vs140/coledatetimespan--gettotalhours.md)  
  
-   [GetTotalSeconds](../vs140/coledatetimespan--gettotalseconds.md)  
  
## Example  
 See the example for [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md)