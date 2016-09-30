---
title: "CSecurityDesc::MakeSelfRelative"
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
  - "CSecurityDesc.MakeSelfRelative"
  - "MakeSelfRelative"
  - "CSecurityDesc::MakeSelfRelative"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MakeSelfRelative method"
ms.assetid: 1629dfca-cf28-40cc-b37f-95bc6b1de50d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityDesc::MakeSelfRelative
Call this method to convert the security descriptor to self-relative format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns true if the method succeeds, false otherwise.  
  
## Remarks  
 A security descriptor in absolute format contains pointers to the information it contains, rather than containing the information itself. A security descriptor in self-relative format contains the information in a contiguous block of memory. In a self-relative security descriptor, a **SECURITY_DESCRIPTOR** structure always starts the information, but the security descriptor's other components can follow the structure in any order. Instead of using memory addresses, the components of the security descriptor are identified by offsets from the beginning of the security descriptor. This format is useful when a security descriptor must be stored on a disk or transmitted by means of a communications protocol. For more information, see [Absolute and Self-Relative Security Descriptors](http://msdn.microsoft.com/library/windows/desktop/aa374807).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSecurityDesc Class](../vs140/csecuritydesc-class.md)   
 [SECURITY_DESCRIPTOR_CONTROL](http://msdn.microsoft.com/library/windows/desktop/aa379566)   
 [Absolute and Self-Relative Security Descriptors](http://msdn.microsoft.com/library/windows/desktop/aa374807)   
 [CSecurityDesc::MakeAbsolute](../vs140/csecuritydesc--makeabsolute.md)   
 [CSecurityDesc::IsSelfRelative](../vs140/csecuritydesc--isselfrelative.md)   
 [MakeSelfRelativeSD](http://msdn.microsoft.com/library/windows/desktop/aa379265)