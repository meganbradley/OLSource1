---
title: "CSecurityDesc::IsDaclDefaulted"
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
  - "ATL::CSecurityDesc::IsDaclDefaulted"
  - "IsDaclDefaulted"
  - "ATL.CSecurityDesc.IsDaclDefaulted"
  - "CSecurityDesc.IsDaclDefaulted"
  - "CSecurityDesc::IsDaclDefaulted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDaclDefaulted method"
ms.assetid: 35a058e8-9a65-479b-bf34-113b10664a22
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsDaclDefaulted
Determines if the security descriptor is configured with a default discretionary access-control list (DACL).  
  
## Syntax  
  
```  
  
bool IsDaclDefaulted( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if the security descriptor contains a default DACL, false otherwise.  
  
## Remarks  
 This flag can affect how the system treats the DACL, with respect to access-control entry (ACE) inheritance. For example, if an object's creator does not specify a DACL, the object receives the default DACL from the creator's access token. The system ignores this flag if the SE_DACL_PRESENT flag is not set.  
  
 This flag is used to determine how the final DACL on the object is to be computed and is not stored physically in the security descriptor control of the securable object.  
  
 To set this flag, use the [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsDaclAutoInherited](../vs140/csecuritydesc--isdaclautoinherited.md)   
 [CSecurityDesc::IsDaclPresent](../vs140/csecuritydesc--isdaclpresent.md)   
 [CSecurityDesc::IsDaclProtected](../vs140/csecuritydesc--isdaclprotected.md)