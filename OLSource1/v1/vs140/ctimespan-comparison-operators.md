---
title: "CTimeSpan Comparison Operators"
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
  - "!="
  - "CTimeSpan"
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, date time"
  - "!= operator"
  - "operator<=, date time"
  - "operator!=, date time"
  - "< operator, date/time comparisons"
  - "operator==, date time"
  - "operator <, date time"
  - "<= operator, date/time comparisons"
  - ">= operator, date/time comparisons"
  - "operator<, date time"
  - "operator !=, date time"
  - "operator >=, date time"
  - "operator <=, date time"
  - "CTimeSpan class, operators"
  - "> operator, date/time comparisons"
  - "operator ==, date time"
  - "operator>=, date time"
  - "== operator"
ms.assetid: a58a57c6-273a-4407-9f30-e96815801f9f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTimeSpan Comparison Operators
Comparison operators.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   CTimeSpan span   
) const throw( );  
bool operator !=(  
   CTimeSpan span   
) const throw( );  
bool operator <(  
   CTimeSpan span   
) const throw( );  
bool operator >(  
   CTimeSpan span   
) const throw( );  
bool operator <=(  
   CTimeSpan span   
) const throw( );  
bool operator >=(  
   CTimeSpan span   
) const throw( );  
```  
  
#### Parameters  
 `span`  
  
 The object to compare.  
  
## Return Value  
 These operators compare two relative time values. They return **true** if the condition is true; otherwise **false**.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#169](../vs140/codesnippet/CPP/ctimespan-comparison-operators_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)