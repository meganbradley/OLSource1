---
title: "CSecurityDesc::IsDaclAutoInherited"
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
  - CSecurityDesc::IsDaclAutoInherited
  - CSecurityDesc.IsDaclAutoInherited
  - ATL::CSecurityDesc::IsDaclAutoInherited
  - ATL.CSecurityDesc.IsDaclAutoInherited
  - IsDaclAutoInherited
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsDaclAutoInherited method
ms.assetid: 54f72060-8d4c-4f51-b552-7798ea76d8b3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSecurityDesc::IsDaclAutoInherited
Determines if the discretionary access-control list (DACL) is configured to support automatic propagation.  
  
## Syntax  
  
```  
  
bool IsDaclAutoInherited( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if the security descriptor contains a DACL which is set up to support automatic propagation of inheritable access-control entries (ACEs) to existing child objects. Returns false otherwise.  
  
## Remarks  
 The system sets this bit when it performs the automatic inheritance algorithm for the object and its existing child objects.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::IsDaclDefaulted](../vs140/csecuritydesc--isdacldefaulted.md)   
 [CSecurityDesc::IsDaclPresent](../vs140/csecuritydesc--isdaclpresent.md)   
 [CSecurityDesc::IsDaclProtected](../vs140/csecuritydesc--isdaclprotected.md)