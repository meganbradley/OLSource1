---
title: "CSecurityDesc::SetGroup"
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
  - "CSecurityDesc::SetGroup"
  - "CSecurityDesc.SetGroup"
  - "SetGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGroup method"
ms.assetid: 699c5487-fe44-43f5-88b8-86ed68097915
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::SetGroup
Sets the primary group information of an absolute format security descriptor, replacing any primary group information already present.  
  
## Syntax  
  
```  
  
      bool SetGroup(  
   const CSid & Sid,  
   bool bDefaulted = false   
) throw(...);  
```  
  
#### Parameters  
 `Sid`  
 Reference to a [CSid](../vs140/csid-class.md) object for the security descriptor's new primary group. This parameter must not be NULL. A security descriptor can be marked as not having a DACL or a SACL, but it must have a group and an owner, even it these are the NULL SID (which is a built-in SID with a special meaning).  
  
 `bDefaulted`  
 Indicates whether the primary group information was derived from a default mechanism. If this value is true, it is default information, and the method stores this value as the SE_GROUP_DEFAULTED flag in the **SECURITY_DESCRIPTOR_CONTROL** structure. If this parameter is zero, the SE_GROUP_DEFAULTED flag is cleared.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SetSecurityDescriptorGroup](http://msdn.microsoft.com/library/windows/desktop/aa379584)   
 [CSecurityDesc::SetControl](../vs140/csecuritydesc--setcontrol.md)   
 [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md)   
 [CSecurityDesc::SetOwner](../vs140/csecuritydesc--setowner.md)   
 [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md)   
 [CSecurityDesc::GetGroup](../vs140/csecuritydesc--getgroup.md)