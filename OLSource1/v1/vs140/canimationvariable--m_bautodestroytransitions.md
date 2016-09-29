---
title: "CAnimationVariable::m_bAutodestroyTransitions"
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
  - "m_bAutodestroyTransitions"
  - "afxanimationcontroller/CAnimationVariable::m_bAutodestroyTransitions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bAutodestroyTransitions data member"
ms.assetid: 0932dc47-7e79-47ec-8502-5787ac42b214
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariable::m_bAutodestroyTransitions
Specifies whether related transition objects should be deleted.  
  
## Syntax  
  
```  
BOOL m_bAutodestroyTransitions;  
```  
  
## Remarks  
 Set this value to TRUE to force deletion of transition objects when they are being removed from the internal list of transitions. If this value is FALSE the transitions should be deleted by calling application. The list of transitions is always cleared after an animation has been scheduled. The default value is FALSE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)