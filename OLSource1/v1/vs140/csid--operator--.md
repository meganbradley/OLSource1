---
title: "CSid::operator &gt;"
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
  - operator >
  - ATL::CSid::operator >
  - ATL.CSid.operator >
  - CSid.operator >
  - Csid::operator >
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator >, security identifiers
  - > operator, with specific ATL objects
  - operator>, security identifiers
ms.assetid: 3dd32e32-87f7-4677-8c29-8f20dc85acb1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSid::operator &gt;
Compares relative value of two security descriptor objects.  
  
## Syntax  
  
```  
  
      bool operator<(   
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
 **true** if `lhs` is greater than `rhs`, otherwise **false**.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)