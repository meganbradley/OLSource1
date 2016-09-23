---
title: "CSacl::CSacl"
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
  - CSacl::CSacl
  - ATL::CSacl::CSacl
  - ATL.CSacl.CSacl
  - CSacl.CSacl
  - CSacl
dev_langs: 
  - C++
helpviewer_keywords: 
  - CSacl class, constructor
  - CSacl constructor
ms.assetid: d58eff15-bb8c-458e-ac7e-2774b1d9e1b5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSacl::CSacl
The constructor.  
  
## Syntax  
  
```  
  
      CSacl( ) throw( );   
CSacl(  
   const ACL & rhs   
) throw(...);  
```  
  
#### Parameters  
 `rhs`  
 An existing **ACL** (access-control list) structure.  
  
## Remarks  
 The `CSacl` object can be optionally created using an existing **ACL** structure. Ensure that this parameter is a system access-control list (SACL) and not a discretionary access-control list (DACL). In debug builds, if a DACL is supplied an assertion will occur. In release builds any entries from a DACL are ignored.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSacl Class](../vs140/csacl-class.md)   
 [CSacl::~CSacl](../vs140/csacl--~csacl.md)