---
title: "CTime::GetDay"
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
  - "ATL::CTime::GetDay"
  - "CTime.GetDay"
  - "CTime::GetDay"
  - "ATL.CTime.GetDay"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDay method"
  - "CTime class, extraction"
ms.assetid: 777193bd-7420-4492-b925-8e881d2d60f4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetDay
Returns the day represent by the `CTime` object.  
  
## Syntax  
  
```  
  
int GetDay( ) const throw( );  
```  
  
## Return Value  
 Returns the day of the month, based on local time, in the range 1 through 31.  
  
## Remarks  
 This function calls `GetLocalTm`, which uses an internal, statically allocated buffer. The data in this buffer is overwritten because of calls to other `CTime` member functions.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#153](../vs140/codesnippet/CPP/ctime--getday_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::GetDayOfWeek](../vs140/ctime--getdayofweek.md)