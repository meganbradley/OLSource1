---
title: "CAnimationBaseObject::SetAutodestroyTransitions"
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
  - "SetAutodestroyTransitions"
  - "afxanimationcontroller/CAnimationBaseObject::SetAutodestroyTransitions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutodestroyTransitions method"
ms.assetid: b5bea8bd-8720-424d-aa9b-637213d36aa0
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::SetAutodestroyTransitions
Sets a flag that orders to automatically destroy transitions.  
  
## Syntax  
  
```  
void SetAutodestroyTransitions(  
   BOOL bValue  
);  
```  
  
#### Parameters  
 `bValue`  
 Specifies the auto destroy flag.  
  
## Remarks  
 Set this flag only if you allocated transition objects using operator new. If for some reason transition objects are allocated on the stack, the auto destroy flag should be FALSE. By default this flag is TRUE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)