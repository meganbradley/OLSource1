---
title: "CSecurityDesc::GetSacl"
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
  - ATL.CSecurityDesc.GetSacl
  - ATL::CSecurityDesc::GetSacl
  - CSecurityDesc.GetSacl
  - CSecurityDesc::GetSacl
  - GetSacl
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSacl method
ms.assetid: 5db814cb-958f-4b4c-a47b-b53b5d84c9e5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSecurityDesc::GetSacl
Retrieves system access-control list (SACL) information from the security descriptor.  
  
## Syntax  
  
```  
  
      bool GetSacl(  
   CSacl * pSacl,  
   bool * pbPresent = NULL,  
   bool * pbDefaulted = NULL   
) const throw(...);  
```  
  
#### Parameters  
 `pSacl`  
 Pointer to an `CSacl` structure in which to store a copy of the security descriptor's SACL. If a system **ACL** exists, the method sets `pSacl` to the address of the security descriptor's system **ACL**. If a system **ACL** does not exist, no value is stored.  
  
 `pbPresent`  
 Pointer to a flag the method sets to indicate the presence of a system **ACL** in the specified security descriptor. If the security descriptor contains a system **ACL**, this parameter is set to true. If the security descriptor does not contain a system **ACL**, this parameter is set to false.  
  
 `pbDefaulted`  
 Pointer to a flag set to the value of the SE_SACL_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure if a system **ACL** exists for the security descriptor.  
  
## Return Value  
 Returns true if the method succeeds, false if it fails.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [GetSecurityDescriptorSacl](http://msdn.microsoft.com/library/windows/desktop/aa446653)   
 [CSecurityDesc::GetControl](../vs140/csecuritydesc--getcontrol.md)   
 [CSecurityDesc::GetDacl](../vs140/csecuritydesc--getdacl.md)   
 [CSecurityDesc::GetGroup](../vs140/csecuritydesc--getgroup.md)   
 [CSecurityDesc::GetOwner](../vs140/csecuritydesc--getowner.md)   
 [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md)