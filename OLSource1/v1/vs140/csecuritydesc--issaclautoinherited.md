---
title: "CSecurityDesc::IsSaclAutoInherited"
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
  - "IsSaclAutoInherited"
  - "CSecurityDesc.IsSaclAutoInherited"
  - "ATL.CSecurityDesc.IsSaclAutoInherited"
  - "ATL::CSecurityDesc::IsSaclAutoInherited"
  - "CSecurityDesc::IsSaclAutoInherited"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSaclAutoInherited method"
ms.assetid: b7d61dca-1930-4aef-99ea-d20bdfe2b3c1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsSaclAutoInherited
Determines if the system access-control list (SACL) is configured to support automatic propagation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true if the security descriptor contains a SACL which is set up to support automatic propagation of inheritable access-control entries (ACEs) to existing child objects. Returns false otherwise.  
  
## Remarks  
 The system sets this bit when it performs the automatic inheritance algorithm for the object and its existing child objects.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsSaclDefaulted](../vs140/csecuritydesc--issacldefaulted.md)   
 [CSecurityDesc::IsSaclPresent](../vs140/csecuritydesc--issaclpresent.md)   
 [CSecurityDesc::IsSaclProtected](../vs140/csecuritydesc--issaclprotected.md)