---
title: "CTimeSpan::GetDays"
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
  - "CTimeSpan::GetDays"
  - "GetDays"
  - "CTimeSpan.GetDays"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDays method"
  - "CTimeSpan class, extraction"
ms.assetid: 8b7d65d6-41bb-441b-a9ef-c56f6eb80425
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTimeSpan::GetDays
Returns a value that represents the number of complete days in this `CTimeSpan`.  
  
## Syntax  
  
```  
  
LONGLONG GetDays( ) const throw( );  
```  
  
## Return Value  
 Returns the number of complete 24-hour days in the time span. This value may be negative if the time span is negative.  
  
## Remarks  
 Note that Daylight Savings Time can cause `GetDays` to return a potentially surprising result. For example, when DST is in effect, **GetDays** reports the number of days between April 1 and May 1 as 29, not 30, because one day in April is shortened by an hour and therefore does not count as a complete day.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#164](../vs140/codesnippet/CPP/ctimespan--getdays_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)