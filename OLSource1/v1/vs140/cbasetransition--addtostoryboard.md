---
title: "CBaseTransition::AddToStoryboard"
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
  - "AddToStoryboard"
  - "afxanimationcontroller/CBaseTransition::AddToStoryboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToStoryboard method"
ms.assetid: e8844c67-8c49-4723-8f9f-b501c4b1c37a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTransition::AddToStoryboard
Adds a transition to a storyboard.  
  
## Syntax  
  
```  
BOOL AddToStoryboard(  
   IUIAnimationStoryboard* pStoryboard  
);  
```  
  
#### Parameters  
 `pStoryboard`  
 A pointer to storyboard, which will animate the related variable.  
  
## Return Value  
 TRUE, if transition was successfully added to a storyboard.  
  
## Remarks  
 Applies the transition to the related variable in the storyboard. If this is the first transition applied to this variable in this storyboard, the transition begins at the start of the storyboard. Otherwise, the transition is appended to the transition added most recently to the variable.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CBaseTransition Class](../vs140/cbasetransition-class.md)