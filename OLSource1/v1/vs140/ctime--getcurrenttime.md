---
title: "CTime::GetCurrentTime"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CTime.GetCurrentTime
  - CTime::GetCurrentTime
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCurrentTime method
  - CTime class, construction/destruction
ms.assetid: 17a539d6-6f01-4cee-beeb-c9ea7b036adb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTime::GetCurrentTime
Returns a `CTime` object that represents the current time.  
  
## Syntax  
  
```  
  
static CTime WINAPI GetCurrentTime( ) throw( );  
```  
  
## Remarks  
 Returns the current system date and time in Coordinated Universal Time (UTC).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#152](../vs140/codesnippet/CPP/ctime--getcurrenttime_1.cpp)]
  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)