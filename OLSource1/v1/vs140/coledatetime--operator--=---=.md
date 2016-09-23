---
title: "COleDateTime::operator +=, -="
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
  - COleDateTime::operator+=-=
  - COleDateTime.operator+=
  - COleDateTime::operator+=
  - COleDateTime.operator+=-=
  - COleDateTime::operator-=
  - COleDateTime.operator-=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator+=, date time
  - COleDateTime class, operators
  - operator +=, date time
  - += operator, date/time calculations
  - operator-=
  - -= operator
ms.assetid: 93f4f7de-005b-41c6-a245-685cd7d43f81
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDateTime::operator +=, -=
Add and subtract a **ColeDateTime** value from this `COleDateTime` object.  
  
## Syntax  
  
```  
  
      COleDateTime& operator +=(  
   COleDateTimeSpan dateSpan   
) throw( );  
COleDateTime& operator -=(  
   COleDateTimeSpan dateSpan   
) throw( );  
```  
  
## Remarks  
 These operators allow you to add and subtract a `COleDateTimeSpan` value to and from this `COleDateTime`. If either of the operands is null, the status of the resulting `COleDateTime` value is null.  
  
 If the resulting `COleDateTime` value falls outside the bounds of acceptable values, the status of this `COleDateTime` value is set to invalid.  
  
 If either of the operands is invalid and other is not null, the status of the resulting `COleDateTime` value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](../vs140/coledatetime--m_status.md) member variable.  
  
 The **+=** and **-=** operators will assert if the `COleDateTime` object is set to null. See [COleDateTime Relational Operators](../vs140/coledatetime-relational-operators.md) for an example.  
  
 For more information about the bounds for `COleDateTime` values, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::operator +, -](../vs140/coledatetime--operator-----.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)