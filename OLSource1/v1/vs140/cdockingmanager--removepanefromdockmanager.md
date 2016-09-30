---
title: "CDockingManager::RemovePaneFromDockManager"
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
  - "CDockingManager.RemovePaneFromDockManager"
  - "CDockingManager::RemovePaneFromDockManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemovePaneFromDockManager method"
ms.assetid: ba04acc9-a33f-4eb0-b337-a6661fb8c75f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::RemovePaneFromDockManager
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
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the pane is removed from the list of autohide bars. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the pane is removed from the list of regular panes.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to a pane that replaces the removed pane.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)