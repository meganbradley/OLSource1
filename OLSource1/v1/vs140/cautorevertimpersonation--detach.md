---
title: "CAutoRevertImpersonation::Detach"
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
  - "ATL::CAutoRevertImpersonation::Detach"
  - "CAutoRevertImpersonation::Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method [ATL]"
ms.assetid: 9309fae5-577d-4018-830e-e763a4df37f7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoRevertImpersonation::Detach
Cancels the automatic impersonation reversion.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The address of the previously associated [CAccessToken](../vs140/caccesstoken-class.md), or NULL if no association existed.  
  
## Remarks  
 Calling **Detach** prevents the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object from reverting any impersonation currently in effect for the [CAccessToken](../vs140/caccesstoken-class.md) object associated with this object. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can then be destroyed with no effect or reassociated to the same or another <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object using [Attach](../vs140/cautorevertimpersonation--attach.md).  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAutoRevertImpersonation Class](../vs140/cautorevertimpersonation-class.md)   
 [CAccessToken Class](../vs140/caccesstoken-class.md)