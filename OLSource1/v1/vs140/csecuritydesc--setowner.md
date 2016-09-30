---
title: "CSecurityDesc::SetOwner"
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
  - "CSecurityDesc.SetOwner"
  - "SetOwner"
  - "CSecurityDesc::SetOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOwner method"
ms.assetid: e3b66091-3a91-499b-9c94-ad78d99126e6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::SetOwner
Sets the owner information of an absolute format security descriptor. It replaces any owner information already present.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object for the security descriptor's new primary owner. This parameter must not be NULL.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates whether the owner information is derived from a default mechanism. If this value is true, it is default information. The method stores this value as the SE_OWNER_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure. If this parameter is zero, the SE_OWNER_DEFAULTED flag is cleared.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [CSecurityDesc::SetControl](../vs140/csecuritydesc--setcontrol.md)   
 [CSecurityDesc::SetGroup](../vs140/csecuritydesc--setgroup.md)   
 [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md)   
 [CSecurityDesc::GetOwner](../vs140/csecuritydesc--getowner.md)