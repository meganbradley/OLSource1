---
title: "CSecurityDesc::IsDaclProtected"
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
  - "CSecurityDesc::IsDaclProtected"
  - "ATL.CSecurityDesc.IsDaclProtected"
  - "ATL::CSecurityDesc::IsDaclProtected"
  - "IsDaclProtected"
  - "CSecurityDesc.IsDaclProtected"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDaclProtected method"
ms.assetid: dfe565fc-7116-4aa3-bf59-895ed1259bd9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsDaclProtected
Determines if the discretionary access-control list (DACL) is configured to prevent modifications.  
  
## Syntax  
  
```  
  
bool IsDaclProtected( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if the DACL is configured to prevent the security descriptor from being modified by inheritable access-control entries (ACEs). Returns false otherwise.  
  
## Remarks  
 To set this flag, use the [CSecurityDesc::SetDacl](../vs140/csecuritydesc--setdacl.md) method.  
  
 This method is only meaningful for Windows 2000 or later, as only Windows 2000 supports automatic propagation of inheritable ACEs.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsDaclAutoInherited](../vs140/csecuritydesc--isdaclautoinherited.md)   
 [CSecurityDesc::IsDaclDefaulted](../vs140/csecuritydesc--isdacldefaulted.md)   
 [CSecurityDesc::IsDaclPresent](../vs140/csecuritydesc--isdaclpresent.md)