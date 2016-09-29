---
title: "CDockablePane::SetTabbedPaneRTC"
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
  - "CDockablePane::SetTabbedPaneRTC"
  - "SetTabbedPaneRTC"
  - "CDockablePane.SetTabbedPaneRTC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTabbedPaneRTC method"
ms.assetid: cc33e8c0-fd65-4f18-a4d0-3075e6ca9553
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::SetTabbedPaneRTC
Sets the runtime class information for a tabbed window that is created when two panes dock together.  
  
## Syntax  
  
```  
void SetTabbedPaneRTC(  
    CRuntimeClass* pRTC  
);  
```  
  
#### Parameters  
 [in] `pRTC`  
 The runtime class information for the tabbed pane.  
  
## Remarks  
 Call this method to set the runtime class information for tabbed panes that are created dynamically. This can occur when a user drags one pane to the caption of another pane, or if you call the [CDockablePane::AttachToTabWnd](../vs140/cdockablepane--attachtotabwnd.md) method to programmatically create a tabbed pane from two dockable panes.  
  
 The default runtime class is set according to the `dwTabbedStyle` parameter of [CDockablePane::Create](../vs140/cdockablepane--create.md) and [CDockablePane::CreateEx](../vs140/cdockablepane--createex.md). To customize the new tabbed panes, derive your class from one of the following classes:  
  
-   [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)  
  
-   [CTabbedPane Class](../vs140/ctabbedpane-class.md)  
  
-   [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md).  
  
 Then, call this method with the pointer to its runtime class information.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)