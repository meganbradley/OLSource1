---
title: "COleDateTimeSpan::GetSeconds"
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
  - "COleDateTimeSpan::GetSeconds"
  - "ATL::COleDateTimeSpan::GetSeconds"
  - "ATL.COleDateTimeSpan.GetSeconds"
  - "COleDateTimeSpan.GetSeconds"
  - "GetSeconds"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSeconds method"
ms.assetid: 17fc4e09-8912-42a3-9e08-695671f684e8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::GetSeconds
Retrieves the second portion of this date/time-span value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The seconds portion of this date/time-span value.  
  
## Remarks  
 The return values from this function range between – 59 and 59.  
  
 For other functions that query the value of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](../vs140/coledatetimespan--getdays.md)  
  
-   [GetHours](../vs140/coledatetimespan--gethours.md)  
  
-   [GetMinutes](../vs140/coledatetimespan--getminutes.md)  
  
-   [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md)  
  
-   [GetTotalHours](../vs140/coledatetimespan--gettotalhours.md)  
  
-   [GetTotalMinutes](../vs140/coledatetimespan--gettotalminutes.md)  
  
-   [GetTotalSeconds](../vs140/coledatetimespan--gettotalseconds.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#19](../vs140/codesnippet/CPP/coledatetimespan--getseconds_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md)