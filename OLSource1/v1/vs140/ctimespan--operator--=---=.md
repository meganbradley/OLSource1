---
title: "CTimeSpan::operator +=, -="
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
  - "CTimeSpan.operator+="
  - "CTimeSpan::operator-="
  - "CTimeSpan.operator+=-="
  - "CTimeSpan.operator-="
  - "CTimeSpan::operator+="
  - "CTimeSpan::operator+=-="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator+=, date time"
  - "operator +=, date time"
  - "+= operator, date/time calculations"
  - "CTimeSpan class, operators"
  - "operator-="
  - "-= operator"
ms.assetid: ece7c677-ea62-4585-9a7c-e08a69e098db
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTimeSpan::operator +=, -=
Adds and subtracts a `CTimeSpan` object to and from this `CTimeSpan`.  
  
## Syntax  
  
```  
  
      CTimeSpan& operator +=(  
   CTimeSpan span   
) throw( );  
CTimeSpan& operator -=(  
   CTimeSpan span   
) throw( );  
```  
  
#### Parameters  
 `span`  
 The value to add to the `CTimeSpan` object.  
  
## Return Value  
 The updated `CTimeSpan` object.  
  
## Remarks  
 These operators allow you to add and subtract a `CTimeSpan` object to and from this `CTimeSpan`.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#168](../vs140/codesnippet/CPP/ctimespan--operator--=---=_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)