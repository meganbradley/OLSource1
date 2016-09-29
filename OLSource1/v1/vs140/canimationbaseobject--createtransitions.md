---
title: "CAnimationBaseObject::CreateTransitions"
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
  - "CreateTransitions"
  - "afxanimationcontroller/CAnimationBaseObject::CreateTransitions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateTransitions method"
ms.assetid: afd5fbf9-309e-46bd-80f8-f5b000b5ed3f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::CreateTransitions
Creates transitions associated with an animation object.  
  
## Syntax  
  
```  
BOOL CreateTransitions();  
```  
  
## Return Value  
 TRUE if transitions were created successfully; otherwise FALSE.  
  
## Remarks  
 Loops over list of animation variables encapsulated in a derived animation object and creates transitions associated with each animation variable.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)