---
title: "CDockablePane::OnBeforeChangeParent"
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
  - "OnBeforeChangeParent"
  - "CDockablePane::OnBeforeChangeParent"
  - "CDockablePane.OnBeforeChangeParent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnBeforeChangeParent method"
ms.assetid: 074cfa60-3f35-4fb0-81fb-78d60f8bb0ff
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::OnBeforeChangeParent
The framework calls this method before it changes the parent of the pane.  
  
## Syntax  
  
```  
virtual void OnBeforeChangeParent(  
   CWnd* pWndNewParent,  
   BOOL bDelay = FALSE  
);  
```  
  
#### Parameters  
 [in] `pWndNewParent`  
 A pointer to the new parent window.  
  
 [in] `bDelay`  
 `BOOL` that specifies whether to delay recalculation of the docking layout if the pane is undocked. For more information, see [CDockablePane::UndockPane](../vs140/cdockablepane--undockpane.md).  
  
## Remarks  
 If the pane is docked and the new parent does not allow docking, this method undocks the pane.  
  
 If the pane is being converted to a tabbed document, this method stores its recent docking position. The framework uses the recent docking position to restore the position of the pane when it is converted back to a docked state.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)