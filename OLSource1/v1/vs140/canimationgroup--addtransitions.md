---
title: "CAnimationGroup::AddTransitions"
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
  - "afxanimationcontroller/CAnimationGroup::AddTransitions"
  - "AddTransitions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTransitions method"
ms.assetid: 44472d7b-05e8-4826-a905-9cfe513786c4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationGroup::AddTransitions
A helper that adds transitions to a storyboard.  
  
## Syntax  
  
```  
void AddTransitions(  
   IUIAnimationStoryboard* pStoryboard,  
   BOOL bDependOnKeyframes  
);  
```  
  
#### Parameters  
 `pStoryboard`  
 A pointer to a storyboard COM object.  
  
 `bDependOnKeyframes`  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationGroup Class](../vs140/canimationgroup-class.md)