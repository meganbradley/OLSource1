---
title: "CMFCDesktopAlertWnd::SetAnimationType"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCDesktopAlertWnd.SetAnimationType
  - SetAnimationType
  - CMFCDesktopAlertWnd::SetAnimationType
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetAnimationType method
ms.assetid: 99e5361d-2f1f-4a9c-b721-0b70f41265dc
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCDesktopAlertWnd::SetAnimationType
Sets the animation type.  
  
## Syntax  
  
```  
void SetAnimationType(  
    CMFCPopupMenu::ANIMATION_TYPE type   
);  
```  
  
#### Parameters  
 [in] `type`  
 Specifies the animation type.  
  
## Remarks  
 Call this method to set animation type. You can specify one of the following values:  
  
-   `NO_ANIMATION`  
  
-   `UNFOLD`  
  
-   `SLIDE`  
  
-   `FADE`  
  
-   `SYSTEM_DEFAULT_ANIMATION`  
  
## Requirements  
 **Header:** afxDesktopAlertWnd.h  
  
## See Also  
 [CMFCDesktopAlertWnd Class](../vs140/cmfcdesktopalertwnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)