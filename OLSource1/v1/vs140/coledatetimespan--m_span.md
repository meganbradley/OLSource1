---
title: "COleDateTimeSpan::m_span"
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
  - "COleDateTimeSpan.m_span"
  - "COleDateTimeSpan::m_span"
  - "m_span"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_span"
  - "COleDateTimeSpan class, data members"
ms.assetid: 8a25d18c-132d-4860-8283-c0733e3ceb71
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan::m_span
The underlying **double** value for this `COleDateTime` object.  
  
## Syntax  
  
```  
  
double m_span;  
  
```  
  
## Remarks  
 This value expresses the date/time-span in days.  
  
> [!CAUTION]
>  Changing the value in the **double** data member will change the value of this `COleDateTimeSpan` object. It does not change the status of this `COleDateTimeSpan` object.  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::COleDateTimeSpan](../vs140/coledatetimespan--coledatetimespan.md)   
 [COleDateTimeSpan::SetDateTimeSpan](../vs140/coledatetimespan--setdatetimespan.md)   
 [COleDateTimeSpan::operator double](../vs140/coledatetimespan--operator-double.md)