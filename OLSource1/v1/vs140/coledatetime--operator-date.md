---
title: "COleDateTime::operator DATE"
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
  - "COleDateTime::operatorDATE"
  - "operatorDATE"
  - "COleDateTime.operatorDATE"
  - "ATL::COleDateTime::operatorDATE"
  - "ATL.COleDateTime.operatorDATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DATE operator"
  - "operator DATE"
  - "COleDateTime class, operators"
ms.assetid: 5b98673a-9e97-482e-85fa-0137678fb365
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::operator DATE
Converts a **ColeDateTime** value into a **DATE**.  
  
## Syntax  
  
```  
  
operator DATE( ) const throw( );  
  
```  
  
## Remarks  
 This operator returns a **DATE** object whose value is copied from this `COleDateTime` object. For more information about the implementation of the **DATE** object, see the article [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
 The **DATE** operator will assert if the `COleDateTime` object is set to null. See [COleDateTime Relational Operators](../vs140/coledatetime-relational-operators.md) for an example.  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::m_dt](../vs140/coledatetime--m_dt.md)