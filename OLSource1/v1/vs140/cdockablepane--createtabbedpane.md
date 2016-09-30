---
title: "CDockablePane::CreateTabbedPane"
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
  - "CDockablePane.CreateTabbedPane"
  - "CreateTabbedPane"
  - "CDockablePane::CreateTabbedPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateTabbedPane method"
ms.assetid: 9815e840-edce-4ccd-a27f-b7f3e88297d3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CreateTabbedPane
Creates a tabbed pane from the current pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The new tabbed pane, or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the create operation failed.  
  
## Remarks  
 The framework calls this method when it creates a tabbed pane to replace this pane. For more information, see [CDockablePane::AttachToTabWnd](../vs140/cdockablepane--attachtotabwnd.md).  
  
 Override this method in a derived class to customize how tabbed panes are created and initialized.  
  
 The tabbed pane is created according to the runtime class information stored in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member, which is initialized by the [CDockablePane::CreateEx](../vs140/cdockablepane--createex.md) method.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)