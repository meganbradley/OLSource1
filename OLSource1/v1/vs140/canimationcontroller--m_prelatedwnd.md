---
title: "CAnimationController::m_pRelatedWnd"
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
  - "m_pRelatedWnd"
  - "afxanimationcontroller/CAnimationController::m_pRelatedWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pRelatedWnd data member"
ms.assetid: c6d60ee7-ac8d-4595-8e5e-94149f569943
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::m_pRelatedWnd
A pointer to a related CWnd object, which can be automatically redrawn when the status of animation manager has changed, or post update event has occurred. Can be NULL.  
  
## Syntax  
  
```  
CWnd* m_pRelatedWnd;  
```  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)