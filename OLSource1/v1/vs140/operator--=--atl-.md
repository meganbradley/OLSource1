---
title: "operator &lt;= (ATL)"
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
  - "ATLSECURITY/<="
  - "operator<="
  - "ATLSECURITY/operator<="
  - "<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<= operator, with specific ATL objects"
  - "operator<=, security identifiers"
  - "operator <=, security identifiers"
ms.assetid: b0098249-855c-4405-8315-c1ff0f93936a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator &lt;= (ATL)
Tests if the `CSid` object or `SID` structure on the left side of the operator is less than or equal to the `CSid` object or `SID` structure on the right side (for STL compatibility).  
  
## Syntax  
  
```  
  
      bool operator <(  
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
 Returns **true** if the address of the `lhs` is less than or equal to the address of the `rhs`, **false** otherwise.  
  
## Remarks  
 This operator acts on the address of the `CSid` object or `SID` structure, and is implemented to provide compatibility with STL collection classes.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [Operators Alphabetical Reference](../vs140/atl-operators-alphabetical-reference.md)   
 [operator >=](../vs140/operator--=--atl-.md)