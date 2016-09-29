---
title: "CSid::operator ="
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
  - "CSid.operator="
  - "CSid::operator="
  - "ATL.CSid.operator="
  - "ATL::CSid::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator=, security identifiers"
  - "operator =, security identifiers"
ms.assetid: 649907a9-50ae-4bb6-8af0-6a0f1f296fd6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::operator =
Assignment operator.  
  
## Syntax  
  
```  
  
      CSid & operator =(  
   const CSid & rhs   
) throw(...);  
CSid & operator =(  
   const SID & rhs   
) throw(...);  
```  
  
#### Parameters  
 `rhs`  
 The `SID` (security identifier) or `CSid` to assign to the `CSid` object.  
  
## Return Value  
 Returns a reference to the updated `CSid` object.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)