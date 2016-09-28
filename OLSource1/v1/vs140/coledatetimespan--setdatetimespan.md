---
title: "COleDateTimeSpan::SetDateTimeSpan"
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
  - "COleDateTimeSpan.SetDateTimeSpan"
  - "SetDateTimeSpan"
  - "COleDateTimeSpan::SetDateTimeSpan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDateTimeSpan method"
ms.assetid: 0587f1f5-b678-45b1-954c-3ea3fbc7f5fb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::SetDateTimeSpan
Sets the value of this date/time-span value.  
  
## Syntax  
  
```  
  
      void SetDateTimeSpan(   
   LONG lDays,   
   int nHours,   
   int nMins,   
   int nSecs    
) throw( );  
```  
  
#### Parameters  
 `lDays`, `nHours`, `nMins`, `nSecs`  
 Indicate the date-span and time-span values to be copied into this `COleDateTimeSpan` object.  
  
## Remarks  
 For functions that query the value of a `COleDateTimeSpan` object, see the following member functions:  
  
-   [GetDays](../vs140/coledatetimespan--getdays.md)  
  
-   [GetHours](../vs140/coledatetimespan--gethours.md)  
  
-   [GetMinutes](../vs140/coledatetimespan--getminutes.md)  
  
-   [GetSeconds](../vs140/coledatetimespan--getseconds.md)  
  
-   [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md)  
  
-   [GetTotalHours](../vs140/coledatetimespan--gettotalhours.md)  
  
-   [GetTotalMinutes](../vs140/coledatetimespan--gettotalminutes.md)  
  
-   [GetTotalSeconds](../vs140/coledatetimespan--gettotalseconds.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#21](../vs140/codesnippet/CPP/coledatetimespan--setdatetimespan_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::GetStatus](../vs140/coledatetimespan--getstatus.md)   
 [COleDateTimeSpan::m_span](../vs140/coledatetimespan--m_span.md)