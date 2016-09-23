---
title: "CSecurityDesc::GetControl"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetControl
  - ATL.CSecurityDesc.GetControl
  - ATL::CSecurityDesc::GetControl
  - CSecurityDesc::GetControl
  - CSecurityDesc.GetControl
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetControl method
ms.assetid: ba51e09b-4c17-4f5f-8230-a7edbd218605
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSecurityDesc::GetControl
Retrieves control information from the security descriptor.  
  
## Syntax  
  
```  
  
      bool GetControl(  
   SECURITY_DESCRIPTOR_CONTROL * psdc   
) const throw( );  
```  
  
#### Parameters  
 *psdc*  
 Pointer to a **SECURITY_DESCRIPTOR_CONTROL** structure that receives the security descriptor's control information.  
  
## Return Value  
 Returns true if the method succeeds, false if it fails.  
  
## Remarks  
 This method is only meaningful when using Windows 2000 or later, as it calls [GetSecurityDescriptorControl](http://msdn.microsoft.com/library/windows/desktop/aa446647).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [CSecurityDesc::GetDacl](../vs140/csecuritydesc--getdacl.md)   
 [CSecurityDesc::GetGroup](../vs140/csecuritydesc--getgroup.md)   
 [CSecurityDesc::GetOwner](../vs140/csecuritydesc--getowner.md)   
 [CSecurityDesc::GetSacl](../vs140/csecuritydesc--getsacl.md)   
 [CSecurityDesc::SetControl](../vs140/csecuritydesc--setcontrol.md)