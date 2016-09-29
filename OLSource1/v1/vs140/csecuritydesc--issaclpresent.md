---
title: "CSecurityDesc::IsSaclPresent"
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
  - "CSecurityDesc.IsSaclPresent"
  - "IsSaclPresent"
  - "CSecurityDesc::IsSaclPresent"
  - "ATL::CSecurityDesc::IsSaclPresent"
  - "ATL.CSecurityDesc.IsSaclPresent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSaclPresent method"
ms.assetid: ce01b9e2-d6de-4fb2-8701-cc96ed6c3d41
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsSaclPresent
Determines if the security descriptor contains a system access-control list (SACL).  
  
## Syntax  
  
```  
  
bool IsSaclPresent( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if the security descriptor contains a SACL, false otherwise.  
  
## Remarks  
 To set this flag, use the [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsSaclAutoInherited](../vs140/csecuritydesc--issaclautoinherited.md)   
 [CSecurityDesc::IsSaclDefaulted](../vs140/csecuritydesc--issacldefaulted.md)   
 [CSecurityDesc::IsSaclProtected](../vs140/csecuritydesc--issaclprotected.md)