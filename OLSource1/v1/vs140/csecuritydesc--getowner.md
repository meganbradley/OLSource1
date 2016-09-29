---
title: "CSecurityDesc::GetOwner"
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
  - "CSecurityDesc.GetOwner"
  - "ATL::CSecurityDesc::GetOwner"
  - "CSecurityDesc::GetOwner"
  - "ATL.CSecurityDesc.GetOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOwner method"
ms.assetid: b33d715f-220c-4ce6-89c1-cd1f0280fad5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::GetOwner
Retrieves owner informaton from the security descriptor.  
  
## Syntax  
  
```  
  
      bool GetOwner(  
   CSid * pSid,  
   bool * pbDefaulted = NULL   
) const throw(...);  
```  
  
#### Parameters  
 `pSid`  
 Pointer to a [CSid](../vs140/csid-class.md) (security identifier) that receives a copy of the group stored in the CDacl.  
  
 `pbDefaulted`  
 Pointer to a flag set to the value of the SE_OWNER_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure when the method returns.  
  
## Return Value  
 Returns true if the method succeeds, false if it fails.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [GetSecurityDescriptorOwner](http://msdn.microsoft.com/library/windows/desktop/aa446651)   
 [CSecurityDesc::GetControl](../vs140/csecuritydesc--getcontrol.md)   
 [CSecurityDesc::GetDacl](../vs140/csecuritydesc--getdacl.md)   
 [CSecurityDesc::GetGroup](../vs140/csecuritydesc--getgroup.md)   
 [CSecurityDesc::GetSacl](../vs140/csecuritydesc--getsacl.md)   
 [CSecurityDesc::SetOwner](../vs140/csecuritydesc--setowner.md)