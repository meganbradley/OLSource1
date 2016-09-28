---
title: "CSid::operator &lt;="
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
  - "Csid::operator<="
  - "ATL::CSid::operator<="
  - "CSid.operator<="
  - "ATL.CSid.operator<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<= operator, with specific ATL objects"
  - "operator<=, security identifiers"
  - "operator <=, security identifiers"
ms.assetid: 8fa00e77-f24d-47ae-b863-8cdab0a5a0cf
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::operator &lt;=
Compares relative value of two security descriptor objects.  
  
## Syntax  
  
```  
  
      bool operator<(   
   const CSid &lhs,   
   const CSid &rhs   
) throw( );  
```  
  
#### Parameters  
 `lhs`  
 The `SID` (security identifier) or `CSid` that appears on the left side of the != operator.  
  
 `rhs`  
 The `SID` (security identifier) or `CSid` that appears on the right side of the != operator.  
  
## Return Value  
 **true** if `lhs` is less than or equal to `rhs`, otherwise **false**.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)