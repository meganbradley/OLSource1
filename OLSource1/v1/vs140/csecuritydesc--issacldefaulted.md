---
title: "CSecurityDesc::IsSaclDefaulted"
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
  - "CSecurityDesc.IsSaclDefaulted"
  - "ATL::CSecurityDesc::IsSaclDefaulted"
  - "ATL.CSecurityDesc.IsSaclDefaulted"
  - "IsSaclDefaulted"
  - "CSecurityDesc::IsSaclDefaulted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSaclDefaulted method"
ms.assetid: db20e0f0-0a8f-45eb-9e9a-c46f3c135a55
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsSaclDefaulted
Determines if the security descriptor is configured with a default system access-control list (SACL).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true if the security descriptor contains a default SACL, false otherwise.  
  
## Remarks  
 This flag can affect how the system treats the SACL, with respect to access-control entry (ACE) inheritance. The system ignores this flag if the SE_SACL_PRESENT flag is not set.  
  
 To set this flag, use the [CSecurityDesc::SetSacl](../vs140/csecuritydesc--setsacl.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsSaclAutoInherited](../vs140/csecuritydesc--issaclautoinherited.md)   
 [CSecurityDesc::IsSaclPresent](../vs140/csecuritydesc--issaclpresent.md)   
 [CSecurityDesc::IsSaclProtected](../vs140/csecuritydesc--issaclprotected.md)