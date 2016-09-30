---
title: "CPrivateObjectSecurityDesc::Get"
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
  - "ATL::CPrivateObjectSecurityDesc::Get"
  - "CPrivateObjectSecurityDesc.Get"
  - "CPrivateObjectSecurityDesc::Get"
  - "ATL.CPrivateObjectSecurityDesc.Get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Get method"
ms.assetid: cbc6b6e7-79d8-4286-8d03-5cc911f07547
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrivateObjectSecurityDesc::Get
Call this method to retrieve information from a private object's security descriptor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A set of bit flags that indicate the parts of the security descriptor to retrieve. This value can be a combination of the [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) bit flags.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a [CSecurityDesc](../vs140/csecuritydesc-class.md) object that receives a copy of the requested information from the specified security descriptor.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Remarks  
 The security descriptor is a structure and associated data that contains the security information for a securable object.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CPrivateObjectSecurityDesc Class](../vs140/cprivateobjectsecuritydesc-class.md)   
 [GetPrivateObjectSecurity](http://msdn.microsoft.com/library/windows/desktop/aa446646)   
 [CPrivateObjectSecurityDesc::Set](../vs140/cprivateobjectsecuritydesc--set.md)