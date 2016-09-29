---
title: "CAnimationController::IsValid"
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
  - "afxanimationcontroller/CAnimationController::IsValid"
  - "IsValid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsValid method"
ms.assetid: a1332a49-f6a6-44b2-8f2f-565fa67cd33d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::IsValid
Tells whether animation controller is valid.  
  
## Syntax  
  
```  
BOOL IsValid() const;  
```  
  
## Return Value  
 TRUE if animation controller is valid; otherwise FALSE.  
  
## Remarks  
 This method returns FALSE only if Windows Animation API is not supported on the current OS and creation of animation manager failed because it's not registered. You need to call GetUIAnimationManager at least once after initialization of COM libraries to cause setting of this flag.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)