---
title: "COleDateTime::GetDayOfYear"
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
  - "ATL.COleDateTime.GetDayOfYear"
  - "COleDateTime.GetDayOfYear"
  - "GetDayOfYear"
  - "COleDateTime::GetDayOfYear"
  - "ATL::COleDateTime::GetDayOfYear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDayOfYear method"
ms.assetid: 663dbbf2-7661-44c6-8d67-68ec2360efef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetDayOfYear
Gets the day of the year represented by this date/time value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The day of the year represented by the value of this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the day of the year could not be obtained.  
  
## Remarks  
 Valid return values range between 1 and 366, where January 1 = 1.  
  
 For information on other member functions that query the value of this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetSecond](../vs140/coledatetime--getsecond.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#8](../vs140/codesnippet/CPP/coledatetime--getdayofyear_1.cpp)]  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)