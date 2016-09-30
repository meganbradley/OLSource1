---
title: "CDockablePane::ReplacePane"
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
  - "CDockablePane.ReplacePane"
  - "CDockablePane::ReplacePane"
  - "ReplacePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReplacePane method"
ms.assetid: dfb7ad8c-eb32-46e3-b647-e32f76033d80
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::ReplacePane
Replaces the pane with a specified pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a dockable pane.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Not used.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the new pane is registered with the docking manager of the parent of the old pane. The new pane is inserted at the index of the old pane in the list of panes that is maintained by the docking manager.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the replacement is successful; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)