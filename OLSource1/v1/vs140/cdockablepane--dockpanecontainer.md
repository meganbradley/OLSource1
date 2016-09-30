---
title: "CDockablePane::DockPaneContainer"
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
  - "DockPaneContainer"
  - "CDockablePane::DockPaneContainer"
  - "CDockablePane.DockPaneContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPaneContainer method"
ms.assetid: f49e2f2d-7e0d-4d60-b123-1033515a309f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::DockPaneContainer
Docks a container to the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to the container manager of the container that is being docked.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that specifies the side of the pane to which the container is being docked.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Not used.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the container was successfully docked to the pane; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The container is being docked to the top of the pane.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The container is being docked to the bottom of the pane.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The container is being docked to the left of the pane.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The container is being docked to the right of the pane.|  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPaneContainerManager Class](../vs140/cpanecontainermanager-class.md)