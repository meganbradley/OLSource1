---
title: "CAnimationController::GetUIAnimationTimer"
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
  - "afxanimationcontroller/CAnimationController::GetUIAnimationTimer"
  - "GetUIAnimationTimer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUIAnimationTimer method"
ms.assetid: 9300f7b3-6fa6-4421-975f-aea57250cf0d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::GetUIAnimationTimer
Provides access to encapsulated IUIAnimationTimer object.  
  
## Syntax  
  
```  
IUIAnimationTimer* GetUIAnimationTimer();  
```  
  
## Return Value  
 A pointer to IUIAnimationTimer interface or NULL, if creation of animation timer failed.  
  
## Remarks  
 If current OS does not support Windows Animation API, this method returns NULL and after that all subsequent calls on CAnimationController::IsValid return FALSE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)