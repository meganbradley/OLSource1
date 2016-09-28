---
title: "CSecurityDesc::IsOwnerDefaulted"
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
  - "ATL.CSecurityDesc.IsOwnerDefaulted"
  - "IsOwnerDefaulted"
  - "CSecurityDesc.IsOwnerDefaulted"
  - "CSecurityDesc::IsOwnerDefaulted"
  - "ATL::CSecurityDesc::IsOwnerDefaulted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsOwnerDefaulted method"
ms.assetid: 850cdfd6-8d82-42fe-8857-b1f566cdf771
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsOwnerDefaulted
Determines if the security descriptor's owner security identifier (SID) was set by default.  
  
## Syntax  
  
```  
  
bool IsOwnerDefaulted( ) const throw( );  
  
```  
  
## Return Value  
 Returns true if a default mechanism, rather than the original provider of the security descriptor, provided the security descriptor's owner SID. Returns false otherwise.  
  
## Remarks  
 To set this flag, use the [CSecurityDesc::SetOwner](../vs140/csecuritydesc--setowner.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::SetOwner](../vs140/csecuritydesc--setowner.md)   
 [CSecurityDesc::GetOwner](../vs140/csecuritydesc--getowner.md)