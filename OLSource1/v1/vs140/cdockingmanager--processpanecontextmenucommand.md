---
title: "CDockingManager::ProcessPaneContextMenuCommand"
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
  - "CDockingManager::ProcessPaneContextMenuCommand"
  - "ProcessPaneContextMenuCommand"
  - "CDockingManager.ProcessPaneContextMenuCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ProcessPaneContextMenuCommand method"
ms.assetid: 0da88b69-2dd6-418d-871b-9cd42f6efe87
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::ProcessPaneContextMenuCommand
Called by the framework to select or to clear a check box for the specified command and recalculate the layout of a shown pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The id of a control bar in the menu.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The command notification code.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to void that is casted to a pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is CN_UPDATE_COMMAND_UI.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to an info structure. This parameter is not used.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not NULL and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> equals CN_UPDATE_COMMAND_UI, or if there is a control bar with the specified <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)