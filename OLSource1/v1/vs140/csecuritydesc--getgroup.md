---
title: "CSecurityDesc::GetGroup"
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
  - "CSecurityDesc::GetGroup"
  - "ATL.CSecurityDesc.GetGroup"
  - "ATL::CSecurityDesc::GetGroup"
  - "GetGroup"
  - "CSecurityDesc.GetGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGroup method"
ms.assetid: b0d86007-7dae-40e8-b11e-b05578452021
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::GetGroup
Retrieves the primary group information from the security descriptor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [CSid](../vs140/csid-class.md) (security identifier) that receives a copy of the group stored in the CDacl.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a flag set to the value of the SE_GROUP_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure when the method returns.  
  
## Return Value  
 Returns true if the method succeeds, false if it fails.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [GetSecurityDescriptorGroup](http://msdn.microsoft.com/library/windows/desktop/aa446649)   
 [CSecurityDesc::GetControl](../vs140/csecuritydesc--getcontrol.md)   
 [CSecurityDesc::GetDacl](../vs140/csecuritydesc--getdacl.md)   
 [CSecurityDesc::GetOwner](../vs140/csecuritydesc--getowner.md)   
 [CSecurityDesc::GetSacl](../vs140/csecuritydesc--getsacl.md)   
 [CSecurityDesc::SetGroup](../vs140/csecuritydesc--setgroup.md)