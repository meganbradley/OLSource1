---
title: "COleDateTime::GetDay"
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
  - "ATL.COleDateTime.GetDay"
  - "ATL::COleDateTime::GetDay"
  - "COleDateTime.GetDay"
  - "COleDateTime::GetDay"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDay method"
ms.assetid: 7441eadc-fcea-4d8d-827d-8953728559fc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetDay
Gets the day of the month represented by this date/time value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The day of the month represented by the value of this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the day could not be obtained.  
  
## Remarks  
 Valid return values range between 1 and 31.  
  
 For information on other member functions that query the value of this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#6](../vs140/codesnippet/CPP/coledatetime--getday_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)