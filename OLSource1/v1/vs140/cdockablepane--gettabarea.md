---
title: "CDockablePane::GetTabArea"
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
  - "GetTabArea"
  - "CDockablePane.GetTabArea"
  - "CDockablePane::GetTabArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabArea method"
ms.assetid: 02f2fbf0-ac09-49e9-b00f-4327b6a2d599
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::GetTabArea
Retrieves the tab area for the pane.  
  
## Syntax  
  
```  
virtual void GetTabArea(  
   CRect& rectTabAreaTop,  
   CRect& rectTabAreaBottom  
) const;  
```  
  
#### Parameters  
 [in] `rectTabAreaTop`  
 `GetTabArea` fills this variable with the tab area if tabs are located at the top of the pane. If tabs are located at the bottom of the pane, this variable is filled with an empty rectangle.  
  
 [in] `rectTabAreaBottom`  
 `GetTabArea` fills this variable with the tab area if tabs are located at the bottom of the pane. If tabs are located at the top of the pane, this variable is filled with an empty rectangle.  
  
## Remarks  
 This method is used only in classes that are derived from `CDockablePane` and have tabs. For more information, see [CTabbedPane::GetTabArea](../vs140/ctabbedpane--gettabarea.md) and [CMFCOutlookBar::GetTabArea](../vs140/cmfcoutlookbar--gettabarea.md).  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)