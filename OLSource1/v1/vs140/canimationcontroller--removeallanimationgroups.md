---
title: "CAnimationController::RemoveAllAnimationGroups"
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
  - "afxanimationcontroller/CAnimationController::RemoveAllAnimationGroups"
  - "RemoveAllAnimationGroups"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAllAnimationGroups method"
ms.assetid: 5483193c-eb1f-4952-a91a-9d322c19c864
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::RemoveAllAnimationGroups
Removes all animation groups from animation controller.  
  
## Syntax  
  
```  
void RemoveAllAnimationGroups();  
```  
  
## Remarks  
 All groups will be deleted, their pointer, if stored at the application level, must be invalidated. If CAnimationGroup::m_bAutodestroyAnimationObjects for a group being deleted is TRUE, all animation objects that belong to that group will be deleted; otherwise their references to parent animation controller will be set to NULL and they can be added to another controller.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)