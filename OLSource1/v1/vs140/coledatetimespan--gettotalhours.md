---
title: "COleDateTimeSpan::GetTotalHours"
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
  - "ATL.COleDateTimeSpan.GetTotalHours"
  - "COleDateTimeSpan::GetTotalHours"
  - "COleDateTimeSpan.GetTotalHours"
  - "ATL::COleDateTimeSpan::GetTotalHours"
  - "GetTotalHours"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTotalHours method"
ms.assetid: 8c35e1cb-4722-494b-b62c-4149fec3336d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::GetTotalHours
Retrieves this date/time-span value expressed in hours.  
  
## Syntax  
  
```  
  
double GetTotalHours( ) const throw( );  
  
```  
  
## Return Value  
 This date/time-span value expressed in hours. Although this function is prototyped to return a double, it will always return an integer value.  
  
## Remarks  
 The return values from this function range between approximately – 8.77e7 and 8.77e7.  
  
 For other functions that query the value of a `COleDateTimeSpan` object, see the following member functions:  
  
-   [GetDays](../vs140/coledatetimespan--getdays.md)  
  
-   [GetHours](../vs140/coledatetimespan--gethours.md)  
  
-   [GetMinutes](../vs140/coledatetimespan--getminutes.md)  
  
-   [GetSeconds](../vs140/coledatetimespan--getseconds.md)  
  
-   [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md)  
  
-   [GetTotalMinutes](../vs140/coledatetimespan--gettotalminutes.md)  
  
-   [GetTotalSeconds](../vs140/coledatetimespan--gettotalseconds.md)  
  
## Example  
 See the example for [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md)