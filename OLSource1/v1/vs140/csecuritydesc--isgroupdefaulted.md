---
title: "CSecurityDesc::IsGroupDefaulted"
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
  - "ATL.CSecurityDesc.IsGroupDefaulted"
  - "ATL::CSecurityDesc::IsGroupDefaulted"
  - "CSecurityDesc::IsGroupDefaulted"
  - "IsGroupDefaulted"
  - "CSecurityDesc.IsGroupDefaulted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsGroupDefaulted method"
ms.assetid: e2a815b4-9b5d-4978-be98-bdef83ca7928
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsGroupDefaulted
Determines if the security descriptor's group security identifier (SID) was set by default.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true if a default mechanism, rather than the original provider of the security descriptor, provided the security descriptor's group SID. Returns false otherwise.  
  
## Remarks  
 To set this flag, use the [CSecurityDesc::SetGroup](../vs140/csecuritydesc--setgroup.md) method.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [CSecurityDesc::SetGroup](../vs140/csecuritydesc--setgroup.md)   
 [CSecurityDesc::GetGroup](../vs140/csecuritydesc--getgroup.md)