---
title: "COleDateTime::GetSecond"
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
  - "COleDateTime.GetSecond"
  - "COleDateTime::GetSecond"
  - "ATL.COleDateTime.GetSecond"
  - "ATL::COleDateTime::GetSecond"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSecond method"
ms.assetid: adbbb18d-de89-4e88-88a2-5da3dcf1da7c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetSecond
Gets the second represented by this date/time value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The second represented by the value of this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the second could not be obtained.  
  
## Remarks  
 Valid return values range between 0 and 59.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class does not support leap seconds.  
  
 For more information about the implementation for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
 For information on other member functions that query the value of this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](../vs140/coledatetime--getday.md)  
  
-   [GetMonth](../vs140/coledatetime--getmonth.md)  
  
-   [GetYear](../vs140/coledatetime--getyear.md)  
  
-   [GetHour](../vs140/coledatetime--gethour.md)  
  
-   [GetMinute](../vs140/coledatetime--getminute.md)  
  
-   [GetDayOfWeek](../vs140/coledatetime--getdayofweek.md)  
  
-   [GetDayOfYear](../vs140/coledatetime--getdayofyear.md)  
  
## Example  
 See the example for [GetHour](../vs140/coledatetime--gethour.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::operator =](../vs140/coledatetime--operator-=.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)