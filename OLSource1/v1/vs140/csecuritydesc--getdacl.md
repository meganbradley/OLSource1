---
title: "CSecurityDesc::GetDacl"
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
  - "CSecurityDesc.GetDacl"
  - "ATL::CSecurityDesc::GetDacl"
  - "GetDacl"
  - "ATL.CSecurityDesc.GetDacl"
  - "CSecurityDesc::GetDacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDacl method"
ms.assetid: f587fc27-84cf-4bcd-83ca-e6407462a32c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::GetDacl
Retrieves discretionary access-control list (DACL) information from the security descriptor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure in which to store a copy of the security descriptor's DACL. If a discretionary **ACL** exists, the method sets <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the address of the security descriptor's discretionary **ACL**. If a discretionary **ACL** does not exist, no value is stored.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a value that indicates the presence of a discretionary **ACL** in the specified security descriptor. If the security descriptor contains a discretionary **ACL**, this parameter is set to true. If the security descriptor does not contain a discretionary **ACL**, this parameter is set to false.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a flag set to the value of the SE_DACL_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure if a discretionary **ACL** exists for the security descriptor. If this flag is true, the discretionary **ACL** was retrieved by a default mechanism; if false, the discretionary **ACL** was explicitly specified by a user.  
  
## Return Value  
 Returns true if the method succeeds, false if it fails.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [GetSecurityDescriptorDacl](http://msdn.microsoft.com/library/windows/desktop/aa446648)   
 [CSecurityDesc::GetControl](../vs140/csecuritydesc--getcontrol.md)   
 [CSecurityDesc::GetGroup](../vs140/csecuritydesc--getgroup.md)   
 [CSecurityDesc::GetOwner](../vs140/csecuritydesc--getowner.md)   
 [CSecurityDesc::GetSacl](../vs140/csecuritydesc--getsacl.md)   
 [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md)