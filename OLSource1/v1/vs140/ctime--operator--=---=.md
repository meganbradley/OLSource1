---
title: "CTime::operator +=, -="
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
  - CTime::operator+=
  - CTime::operator+=-=
  - CTime.operator+=
  - CTime.operator-=
  - CTime::operator-=
  - CTime.operator+=-=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator+=, date time
  - operator +=, date time
  - += operator, date/time calculations
  - operator-=
  - CTime class, operators
  - -= operator
ms.assetid: 703dd5e5-f15f-4ed7-a472-aae968d2948a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTime::operator +=, -=
These operators add and subtract a `CTimeSpan` object to and from this `CTime` object.  
  
## Syntax  
  
```  
  
      CTime& operator +=(  
   CTimeSpan span   
) throw( );  
CTime& operator -=(  
   CTimeSpan span   
) throw( );  
```  
  
#### Parameters  
 `span`  
 The `CTimeSpan` object to be added or subtracted.  
  
## Return Value  
 The updated `CTime` object.  
  
## Remarks  
 These operators allow you to add and subtract a `CTimeSpan` object to and from this `CTime` object.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#160](../vs140/codesnippet/CPP/ctime--operator--=---=_1.cpp)]
  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)