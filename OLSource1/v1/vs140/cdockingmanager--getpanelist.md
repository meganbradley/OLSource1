---
title: "CDockingManager::GetPaneList"
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
  - "CDockingManager.GetPaneList"
  - "CDockingManager::GetPaneList"
  - "GetPaneList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaneList method"
ms.assetid: a258b61d-8774-4412-8b72-4fbf92d0b239
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::GetPaneList
Returns a list of panes that belong to the docking manager. This includes all floating panes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains all the panes of the current docking manager.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to include the panes that are in autohide mode; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the returned list contains panes only of the specified runtime class.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to include tabs; otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 If there are any tabbed panes in the docking manager, the method returns pointers to [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md) objects and you must enumerate the tabs explicitly.  
  
 Use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to obtain a particular class of panes. For example, you can obtain only toolbars by setting this value appropriately.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)