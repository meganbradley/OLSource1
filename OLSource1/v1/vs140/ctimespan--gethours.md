---
title: "CTimeSpan::GetHours"
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
  - "CTimeSpan::GetHours"
  - "CTimeSpan.GetHours"
  - "GetHours"
  - "ATL::CTimeSpan::GetHours"
  - "ATL.CTimeSpan.GetHours"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTimeSpan class, extraction"
  - "GetHours method"
ms.assetid: e4cfb702-d981-4405-9f9f-80c04c1af28b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTimeSpan::GetHours
Returns a value that represents the number of hours in the current day (–23 through 23).  
  
## Syntax  
  
```  
  
LONG GetHours( ) const throw( );  
```  
  
## Return Value  
 Returns the number of hours in the current day. The range is –23 through 23.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#165](../vs140/codesnippet/CPP/ctimespan--gethours_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)