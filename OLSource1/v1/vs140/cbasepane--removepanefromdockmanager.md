---
title: "CBasePane::RemovePaneFromDockManager"
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
  - "RemovePaneFromDockManager"
  - "CBasePane.RemovePaneFromDockManager"
  - "CBasePane::RemovePaneFromDockManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemovePaneFromDockManager method"
ms.assetid: 45403e47-f0d4-4d57-8beb-b22334a4da5f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::RemovePaneFromDockManager
Unregisters a pane and removes it from the list in the docking manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a pane to be removed.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the removed pane is destroyed.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, adjust the docking layout immediately.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the docking layout is related to the list of autohide bars. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the docking layout is related to the list of regular panes.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)