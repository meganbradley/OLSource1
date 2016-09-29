---
title: "CFileTimeSpan::operator &lt;="
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
  - "ATL.CFileTimeSpan.operator<="
  - "ATL::CFileTimeSpan::operator<="
  - "CFileTimeSpan.operator<="
  - "CFileTimeSpan::operator<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<=, date time"
  - "<= operator, date/time comparisons"
  - "operator <=, date time"
ms.assetid: 0ff5ed10-3ef9-4796-9555-701429e5877e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTimeSpan::operator &lt;=
Compares two `CFileTimeSpan` objects to determine equality or the lesser.  
  
## Syntax  
  
```  
  
      bool operator<=(  
   CFileTimeSpan span   
) const throw( );  
```  
  
#### Parameters  
 `span`  
 The `CFileTimeSpan` object to be compared.  
  
## Return Value  
 Returns **true** if the first object is less than (that is, represents a shorter time period) or equal to the second, otherwise **false**.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTimeSpan Class](../vs140/cfiletimespan-class.md)