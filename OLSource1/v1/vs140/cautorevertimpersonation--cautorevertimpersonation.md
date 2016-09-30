---
title: "CAutoRevertImpersonation::CAutoRevertImpersonation"
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
  - "CAutoRevertImpersonation::CAutoRevertImpersonation"
  - "CAutoRevertImpersonation"
  - "ATL::CAutoRevertImpersonation::CAutoRevertImpersonation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoRevertImpersonation constructor"
  - "CAutoRevertImpersonation class, constructor"
ms.assetid: 1e3544d8-70ee-47e3-a50e-c6c144506a45
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoRevertImpersonation::CAutoRevertImpersonation
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The address of the [CAccessToken](../vs140/caccesstoken-class.md) object to be reverted automatically.  
  
## Remarks  
 The actual impersonation of the access token should be performed separately from and preferably before the creation of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. This impersonation will be reverted automatically when the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object goes out of scope.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md)   
 [CAccessToken Class](../vs140/caccesstoken-class.md)