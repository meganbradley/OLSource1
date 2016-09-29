---
title: "CSid::operator !="
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
  - "ATL::CSid::operator!="
  - "ATL.CSid.operator!="
  - "CSid.operator!="
  - "CSid::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!=, security identifiers"
  - "operator !=, security identifiers"
  - "!= operator, with specific ATL objects"
ms.assetid: 16e5d1d4-e205-4056-baa2-f0f824cb5d33
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::operator !=
Tests two security descriptor objects for inequality.  
  
## Syntax  
  
```  
  
      bool operator!=(   
   const CSid &lhs,   
   const CSid &rhs   
) throw(   );  
```  
  
#### Parameters  
 `lhs`  
 The `SID` (security identifier) or `CSid` that appears on the left side of the != operator.  
  
 `rhs`  
 The `SID` (security identifier) or `CSid` that appears on the right side of the != operator.  
  
## Return Value  
 **true** if the security descriptors are not equal, otherwise **false**.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)