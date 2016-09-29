---
title: "CMFCPopupMenu::SetAnimationSpeed"
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
  - "SetAnimationSpeed"
  - "CMFCPopupMenu.SetAnimationSpeed"
  - "CMFCPopupMenu::SetAnimationSpeed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAnimationSpeed method"
ms.assetid: a6919af1-94db-4ea6-bd0b-3935909d2989
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::SetAnimationSpeed
Sets the animation speed for pop-up menus.  
  
## Syntax  
  
```  
static void SetAnimationSpeed(  
   UINT nElapse   
);  
```  
  
#### Parameters  
 [in] `nElapse`  
 The new animation speed, in milliseconds.  
  
## Remarks  
 The animation speed is a global value and affects all the pop-up menus in the application. This value specifies how long it takes for the animation for a pop-up menu to finish.  
  
 By default, this parameter is set to 30 milliseconds. The range of valid values for `nElapse` is from 0 to 200.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu::GetAnimationSpeed](../vs140/cmfcpopupmenu--getanimationspeed.md)