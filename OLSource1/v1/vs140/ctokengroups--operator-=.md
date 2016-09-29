---
title: "CTokenGroups::operator ="
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
  - "CTokenGroups::operator="
  - "ATL.CTokenGroups.operator="
  - "ATL::CTokenGroups::operator="
  - "CTokenGroups.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator=, access tokens"
  - "operator =, access tokens"
ms.assetid: c67a7faa-ed85-4f30-b34e-ebbf14430a2b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenGroups::operator =
Assignment operator.  
  
## Syntax  
  
```  
  
      CTokenGroups & operator =(  
   const TOKEN_GROUPS & rhs   
) throw(...);  
CTokenGroups & operator =(  
   const CTokenGroups & rhs   
) throw(...);  
```  
  
#### Parameters  
 `rhs`  
 The `CTokenGroups` object or [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure to assign to the `CTokenGroups` object.  
  
## Return Value  
 Returns the updated `CTokenGroups` object.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenGroups Class](../vs140/ctokengroups-class.md)