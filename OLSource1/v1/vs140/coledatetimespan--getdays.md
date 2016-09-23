---
title: "COleDateTimeSpan::GetDays"
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
  - COleDateTimeSpan::GetDays
  - ATL::COleDateTimeSpan::GetDays
  - ATL.COleDateTimeSpan.GetDays
  - COleDateTimeSpan.GetDays
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDays method
ms.assetid: 5b9177e2-eebe-4048-8f57-3a22dc6961c2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTimeSpan::GetDays
Retrieves the day portion of this date/time-span value.  
  
## Syntax  
  
```  
  
LONG GetDays( ) const throw( );  
  
```  
  
## Return Value  
 The day portion of this date/time-span value.  
  
## Remarks  
 The return values from this function range between approximately – 3,615,000 and 3,615,000.  
  
 For other functions that query the value of a `COleDateTimeSpan` object, see the following member functions:  
  
-   [GetHours](../vs140/coledatetimespan--gethours.md)  
  
-   [GetMinutes](../vs140/coledatetimespan--getminutes.md)  
  
-   [GetSeconds](../vs140/coledatetimespan--getseconds.md)  
  
-   [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md)  
  
-   [GetTotalHours](../vs140/coledatetimespan--gettotalhours.md)  
  
-   [GetTotalMinutes](../vs140/coledatetimespan--gettotalminutes.md)  
  
-   [GetTotalSeconds](../vs140/coledatetimespan--gettotalseconds.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#16](../vs140/codesnippet/CPP/coledatetimespan--getdays_1.cpp)]
  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md)