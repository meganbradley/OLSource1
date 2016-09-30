---
title: "CBaseTabbedPane::AddTab"
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
  - "AddTab"
  - "CBaseTabbedPane.AddTab"
  - "CBaseTabbedPane::AddTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTab method"
ms.assetid: 72ca5bee-59e8-4be0-ad0f-4672455a06f9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::AddTab
Adds a new tab to a tabbed pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to add. This pointer may become invalid after you call this method. For more information, see the Remarks section.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to make the tab visible; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to make the tab the active tab; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to make the tab detachable; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the pane was successfully added as a tab and was not destroyed in the process. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the pane being added is an object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see the Remarks section.  
  
## Remarks  
 Call this method to add a pane as a new tab on a tabbed pane. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> points to an object of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, all its tabs are copied onto the tabbed pane and then <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is destroyed. Thus, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> becomes an invalid pointer and should not be used.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)