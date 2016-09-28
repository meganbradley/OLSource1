---
title: "CAnimationBaseObject::GetGroupID"
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
  - "GetGroupID"
  - "afxanimationcontroller/CAnimationBaseObject::GetGroupID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGroupID method"
ms.assetid: 788c0e2b-3856-44c1-9dde-0d138bbccbc7
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::GetGroupID
Returns current Group ID.  
  
## Syntax  
  
```  
UINT32 GetGroupID() const;  
```  
  
## Return Value  
 Current Group ID.  
  
## Remarks  
 Use this method to retrieve Group ID. It's 0 if Group ID has not been set explicitly in constructor or with SetID.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)