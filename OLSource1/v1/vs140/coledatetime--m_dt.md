---
title: "COleDateTime::m_dt"
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
  - "m_dt"
  - "COleDateTime::m_dt"
  - "COleDateTime.m_dt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDateTime class, data members"
  - "m_dt"
ms.assetid: 6c5a4c67-682f-4040-be19-634e55d8abe4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::m_dt
The underlying **DATE** structure for this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!CAUTION]
>  Changing the value in the **DATE** object accessed by the pointer returned by this function will change the value of this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. It does not change the status of this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 For more information about the implementation of the **DATE** object, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::COleDateTime](../vs140/coledatetime--coledatetime.md)   
 [COleDateTime::SetDateTime](../vs140/coledatetime--setdatetime.md)   
 [COleDateTime::SetDate](../vs140/coledatetime--setdate.md)   
 [COleDateTime::SetTime](../vs140/coledatetime--settime.md)   
 [COleDateTime::operator DATE](../vs140/coledatetime--operator-date.md)