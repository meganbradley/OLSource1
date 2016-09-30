---
title: "CSecurityDesc::IsSelfRelative"
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
  - "CSecurityDesc.IsSelfRelative"
  - "ATL::CSecurityDesc::IsSelfRelative"
  - "CSecurityDesc::IsSelfRelative"
  - "ATL.CSecurityDesc.IsSelfRelative"
  - "IsSelfRelative"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSelfRelative method"
ms.assetid: 59ccee4f-bbe6-487c-a9df-4693e847acab
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::IsSelfRelative
Determines if the security descriptor is in self-relative format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true if the security descriptor is in self-relative format with all the security information in a contiguous block of memory. Returns false if the security descriptor is in absolute format. For more information, see [Absolute and Self-Relative Security Descriptors](http://msdn.microsoft.com/library/windows/desktop/aa374807).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [Absolute and Self-Relative Security Descriptors](http://msdn.microsoft.com/library/windows/desktop/aa374807)   
 [CSecurityDesc::MakeSelfRelative](../vs140/csecuritydesc--makeselfrelative.md)   
 [CSecurityDesc::MakeAbsolute](../vs140/csecuritydesc--makeabsolute.md)