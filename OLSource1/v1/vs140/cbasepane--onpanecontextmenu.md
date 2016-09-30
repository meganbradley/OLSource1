---
title: "CBasePane::OnPaneContextMenu"
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
  - "OnPaneContextMenu"
  - "CBasePane.OnPaneContextMenu"
  - "CBasePane::OnPaneContextMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPaneContextMenu method"
ms.assetid: cbc584dd-848d-4ecc-a0e2-32c737bec474
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::OnPaneContextMenu
Called by the framework when it builds a menu that has a list of panes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the parent frame.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the location of the shortcut menu.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> calls the docking manager, which maintains the list of panes that belong to the current frame window. This method adds the names of the panes to a shortcut menu and displays it. The commands on the menu show or hide individual panes.  
  
 Override this method to customize this behavior.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)