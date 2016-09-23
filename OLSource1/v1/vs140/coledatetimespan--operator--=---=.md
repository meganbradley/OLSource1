---
title: "COleDateTimeSpan::operator +=, -="
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
  - COleDateTimeSpan::operator-=
  - COleDateTimeSpan::operator+=
  - COleDateTimeSpan.operator+=
  - COleDateTimeSpan::operator+=-=
  - COleDateTimeSpan.operator-=
  - COleDateTimeSpan.operator+=-=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator+=, date time
  - operator +=, date time
  - += operator, date/time calculations
  - operator-=
  - COleDateTimeSpan class, operators
  - -= operator
ms.assetid: 030f7747-8262-4421-b431-72daa11d58ae
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTimeSpan::operator +=, -=
Add and subtract a `COleDateTimeSpan` value from this `COleDateTimeSpan` value.  
  
## Syntax  
  
```  
  
      COleDateTimeSpan& operator +=(   
   const COleDateTimeSpan dateSpan    
) throw( );  
COleDateTimeSpan& operator -=(   
   const COleDateTimeSpan dateSpan    
) throw( );  
```  
  
## Remarks  
 These operators let you add and subtract date/time-span values from this `COleDateTimeSpan` object. If either of the operands is null, the status of the resulting `COleDateTimeSpan` value is null.  
  
 If either of the operands is invalid and the other is not null, the status of the resulting `COleDateTimeSpan` value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](../vs140/coledatetimespan--m_status.md) member variable.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#24](../vs140/codesnippet/CPP/coledatetimespan--operator--=---=_1.cpp)]
  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTimeSpan Class](../vs140/coledatetimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTimeSpan::operator +, -](../vs140/coledatetimespan--operator-----.md)