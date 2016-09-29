---
title: "COleDateTime::GetDayOfWeek"
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
  - "COleDateTime.GetDayOfWeek"
  - "ATL.COleDateTime.GetDayOfWeek"
  - "COleDateTime::GetDayOfWeek"
  - "ATL::COleDateTime::GetDayOfWeek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDayOfWeek method"
ms.assetid: abf60e54-79f4-48a1-82b9-f92ace8903ec
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetDayOfWeek
Gets the day of the month represented by this date/time value.  
  
## Syntax  
  
```  
  
int GetDayOfWeek( ) const throw( );  
  
```  
  
## Return Value  
 The day of the week represented by the value of this `COleDateTime` object or `COleDateTime::error` if the day of the week could not be obtained.  
  
## Remarks  
 Valid return values range between 1 and 7, where 1=Sunday, 2=Monday, and so on.  
  
 For information on other member functions that query the value of this `COleDateTime` object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#7](../vs140/codesnippet/CPP/coledatetime--getdayofweek_1.cpp)]  
  
## Requirements  
 **Header:** atlcommem.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)