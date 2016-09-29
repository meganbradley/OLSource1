---
title: "CDockablePane::SetAutoHideParents"
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
  - "CDockablePane::SetAutoHideParents"
  - "CDockablePane.SetAutoHideParents"
  - "SetAutoHideParents"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutoHideParents method"
ms.assetid: 97f3a394-dcff-4173-af78-32479eb14504
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::SetAutoHideParents
Sets the auto-hide button and auto-hide toolbar for the pane.  
  
## Syntax  
  
```  
void SetAutoHideParents(  
   CMFCAutoHideBar* pToolBar,  
   CMFCAutoHideButton* pBtn  
);  
```  
  
#### Parameters  
 [in] `pToolBar`  
 Pointer to an auto-hide toolbar.  
  
 [in] `pBtn`  
 Pointer to an auto-hide button.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md)   
 [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md)