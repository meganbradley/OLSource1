---
title: "CSecurityDesc::operator ="
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
  - CSecurityDesc.operator=
  - ATL.CSecurityDesc.operator=
  - ATL::CSecurityDesc::operator=
  - CSecurityDesc::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator =, security descriptors
  - = operator, with specific ATL objects
  - operator=, security descriptors
ms.assetid: 20079057-7452-4d13-9812-bb4d681f2b4e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSecurityDesc::operator =
Assignment operator.  
  
## Syntax  
  
```  
  
      CSecurityDesc & operator =(  
   const SECURITY_DESCRIPTOR & rhs   
) throw(...);  
CSecurityDesc & operator =(  
   const CSecurityDesc & rhs   
) throw(...);  
```  
  
#### Parameters  
 `rhs`  
 The **SECURITY_DESCRIPTOR** structure or `CSecurityDesc` object to assign to the `CSecurityDesc` object.  
  
## Return Value  
 Returns the updated `CSecurityDesc` object.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR](http://msdn.microsoft.com/library/windows/desktop/aa379561)