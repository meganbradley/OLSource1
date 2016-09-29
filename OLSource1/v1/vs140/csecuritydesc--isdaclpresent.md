---
title: "CSecurityDesc::IsDaclPresent"
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
  - "ATL::CSecurityDesc::IsDaclPresent"
  - "CSecurityDesc.IsDaclPresent"
  - "IsDaclPresent"
  - "ATL.CSecurityDesc.IsDaclPresent"
  - "CSecurityDesc::IsDaclPresent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDaclPresent method"
ms.assetid: 0646a560-7bf7-44f2-b854-2467026ee647
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsDaclPresent
Determines if the security descriptor contains a discretionary access-control list (DACL).  
  
## Syntax  
  
```  
  
bool IsDaclPresent( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if the security descriptor contains a DACL, false otherwise.  
  
## Remarks  
 If this flag is not set, or if this flag is set and the DACL is NULL, the security descriptor allows full access to everyone.  
  
 This flag is used to hold the security information specified by a caller until the security descriptor is associated with a securable object. Once the security descriptor is associated with a securable object, the SE_DACL_PRESENT flag is always set in the security descriptor control.  
  
 To set this flag, use the [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsDaclAutoInherited](../vs140/csecuritydesc--isdaclautoinherited.md)   
 [CSecurityDesc::IsDaclDefaulted](../vs140/csecuritydesc--isdacldefaulted.md)   
 [CSecurityDesc::IsDaclProtected](../vs140/csecuritydesc--isdaclprotected.md)