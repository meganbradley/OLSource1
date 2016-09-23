---
title: "COleDateTimeSpan::GetTotalDays"
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
  - COleDateTimeSpan.GetTotalDays
  - GetTotalDays
  - COleDateTimeSpan::GetTotalDays
  - ATL::COleDateTimeSpan::GetTotalDays
  - ATL.COleDateTimeSpan.GetTotalDays
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTotalDays method
ms.assetid: 997e2e29-fa67-4a9e-b2f0-962a19ee0413
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTimeSpan::GetTotalDays
Retrieves this date/time-span value expressed in days.  
  
## Syntax  
  
```  
  
double GetTotalDays( ) const throw( );  
  
```  
  
## Return Value  
 This date/time-span value expressed in days. Although this function is prototyped to return a double, it will always return an integer value.  
  
## Remarks  
 The return values from this function range between approximately – 3.65e6 and 3.65e6.  
  
 For other functions that query the value of a `COleDateTimeSpan` object, see the following member functions:  
  
-   [GetDays](../vs140/coledatetimespan--getdays.md)  
  
-   [GetHours](../vs140/coledatetimespan--gethours.md)  
  
-   [GetMinutes](../vs140/coledatetimespan--getminutes.md)  
  
-   [GetSeconds](../vs140/coledatetimespan--getseconds.md)  
  
-   [GetTotalHours](../vs140/coledatetimespan--gettotalhours.md)  
  
-   [GetTotalMinutes](../vs140/coledatetimespan--gettotalminutes.md)  
  
-   [GetTotalSeconds](../vs140/coledatetimespan--gettotalseconds.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#20](../vs140/codesnippet/CPP/coledatetimespan--gettotaldays_1.cpp)]
  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md)   
 [COleDateTimeSpan::operator double](../vs140/coledatetimespan--operator-double.md)