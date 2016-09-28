---
title: "CAnimationController::GetUITransitionFactory"
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
  - "afxanimationcontroller/CAnimationController::GetUITransitionFactory"
  - "GetUITransitionFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUITransitionFactory method"
ms.assetid: a5cdeed5-9269-4206-81f9-c8ce1516e7ad
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::GetUITransitionFactory
A pointer to IUIAnimationTransitionFactory interface or NULL, if creation of transition library failed.  
  
## Syntax  
  
```  
IUIAnimationTransitionFactory* GetUITransitionFactory();  
```  
  
## Return Value  
 A pointer to IUIAnimationTransitionFactory or NULL, if creation of transition factory failed.  
  
## Remarks  
 If current OS does not support Windows Animation API, this method returns NULL and after that all subsequent calls on CAnimationController::IsValid return FALSE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)