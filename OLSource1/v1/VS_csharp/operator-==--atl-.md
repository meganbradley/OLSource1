---
title: "operator == (ATL)"
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
  - "operator=="
  - "ATLSECURITY/=="
  - "ATLSECURITY/operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, security identifiers"
  - "operator==, security identifiers"
  - "== operator, with specific ATL objects"
ms.assetid: 200061de-0163-410c-bfc1-174eccade9dd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator == (ATL)
Compares `CSid` objects or `SID` (security identifier) structures for equality.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   const CSid & lhs,   
   const CSid & rhs,   
) throw();  
```  
  
#### Parameters  
 `lhs`  
 The first `CSid` object or `SID` structure to compare.  
  
 `rhs`  
 The second `CSid` object or `SID` structure to compare.  
  
## Return Value  
 Returns **true** if the objects are equal, **false** if they are not equal.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Operators Alphabetical Reference](../VS_csharp/atl-operators-alphabetical-reference.md)   
 [operator !=](../VS_csharp/operator-!=--atl-.md)