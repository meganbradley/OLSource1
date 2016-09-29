---
title: "CSecurityDesc::SetDacl"
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
  - "CSecurityDesc::SetDacl"
  - "CSecurityDesc.SetDacl"
  - "SetDacl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDacl method"
ms.assetid: 906ac993-fe82-4dc4-8d57-5b1fcb940641
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::SetDacl
Sets information in a discretionary access-control list (DACL). If a DACL is already present in the security descriptor, it is replaced.  
  
## Syntax  
  
```  
  
      inline void SetDacl(  
   bool bPresent = true,  
   bool bDefaulted = false   
) throw(...);  
inline void SetDacl(  
   const CDacl & Dacl,  
   bool bDefaulted = false   
) throw(...);  
```  
  
#### Parameters  
 *Dacl*  
 Reference to a `CDacl` object specifying the DACL for the security descriptor. This parameter must not be NULL. To set a NULL DACL in the security descriptor, the first form of the method should be used with `bPresent` set to false.  
  
 `bPresent`  
 Specifies a flag indicating the presence of a DACL in the security descriptor. If this parameter is true, the method sets the SE_DACL_PRESENT flag in the **SECURITY_DESCRIPTOR_CONTROL** structure and uses the values in the *Dacl* and `bDefaulted` parameters. If it is false, the method clears the SE_DACL_PRESENT flag, and `bDefaulted` is ignored.  
  
 `bDefaulted`  
 Specifies a flag indicating the source of the DACL. If this flag is true, the DACL has been retrieved by some default mechanism. If false, the DACL has been explicitly specified by a user. The method stores this value in the SE_DACL_DEFAULTED flag of the **SECURITY_DESCRIPTOR_CONTROL** structure. If this parameter is not specified, the SE_DACL_DEFAULTED flag is cleared.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 There is an important difference between an empty and a nonexistent DACL. When a DACL is empty, it contains no access-control entries and no access rights have been explicitly granted. As a result, access to the object is implicitly denied. When an object has no DACL, on the other hand, no protection is assigned to the object, and any access request is granted.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SetSecurityDescriptorDacl](http://msdn.microsoft.com/library/windows/desktop/aa379583)   
 [CSecurityDesc::SetControl](../vs140/csecuritydesc--setcontrol.md)   
 [CSecurityDesc::SetGroup](../vs140/csecuritydesc--setgroup.md)   
 [CSecurityDesc::SetOwner](../vs140/csecuritydesc--setowner.md)   
 [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md)   
 [CSecurityDesc::GetDacl](../vs140/csecuritydesc--getdacl.md)