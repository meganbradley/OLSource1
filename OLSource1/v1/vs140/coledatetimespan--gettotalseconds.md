---
title: "COleDateTimeSpan::GetTotalSeconds"
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
  - "ATL::COleDateTimeSpan::GetTotalSeconds"
  - "COleDateTimeSpan::GetTotalSeconds"
  - "COleDateTimeSpan.GetTotalSeconds"
  - "ATL.COleDateTimeSpan.GetTotalSeconds"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTotalSeconds method"
ms.assetid: ca4e3821-97c3-4acc-8559-2b59bfb6578f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::GetTotalSeconds
Retrieves this date/time-span value expressed in seconds.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 This date/time-span value expressed in seconds. Although this function is prototyped to return a double, it will always return an integer value.  
  
## Remarks  
 The return values from this function range between approximately – 3.16e11 to 3.16e11.  
  
 For other functions that query the value of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](../vs140/coledatetimespan--getdays.md)  
  
-   [GetHours](../vs140/coledatetimespan--gethours.md)  
  
-   [GetMinutes](../vs140/coledatetimespan--getminutes.md)  
  
-   [GetSeconds](../vs140/coledatetimespan--getseconds.md)  
  
-   [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md)  
  
-   [GetTotalHours](../vs140/coledatetimespan--gettotalhours.md)  
  
-   [GetTotalMinutes](../vs140/coledatetimespan--gettotalminutes.md)  
  
## Example  
 See the example for [GetTotalDays](../vs140/coledatetimespan--gettotaldays.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md)