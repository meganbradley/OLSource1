---
title: "CSecurityDesc::IsSaclProtected"
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
  - "IsSaclProtected"
  - "ATL::CSecurityDesc::IsSaclProtected"
  - "ATL.CSecurityDesc.IsSaclProtected"
  - "CSecurityDesc::IsSaclProtected"
  - "CSecurityDesc.IsSaclProtected"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSaclProtected method"
ms.assetid: c966d9c4-be36-4de7-8b16-1efe52ed0cfa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsSaclProtected
Determines if the system access-control list (SACL) is configured to prevent modifications.  
  
## Syntax  
  
```  
  
bool IsSaclProtected( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if the SACL is configured to prevent the security descriptor from being modified by inheritable access-control entries (ACEs). Returns false otherwise.  
  
## Remarks  
 To set this flag, use the [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md) method.  
  
 This method is only meaningful for Windows 2000 or later, as only Windows 2000 supports automatic propagation of inheritable ACEs.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsSaclAutoInherited](../vs140/csecuritydesc--issaclautoinherited.md)   
 [CSecurityDesc::IsSaclDefaulted](../vs140/csecuritydesc--issacldefaulted.md)   
 [CSecurityDesc::IsSaclPresent](../vs140/csecuritydesc--issaclpresent.md)