---
title: "CBaseTabbedPane::ShowTab"
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
  - "CBaseTabbedPane::ShowTab"
  - "ShowTab"
  - "CBaseTabbedPane.ShowTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowTab method"
ms.assetid: 76ceccea-19fa-4b60-b2c3-71b97dd2c92c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::ShowTab
Shows or hides a tab.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to show or hide.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to show the pane; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to hide the pane.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to delay the adjustment of the tab layout; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to make the tab the active tab; otherwise, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the tab was either shown or hidden successfully; otherwise, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 When you call this method, a pane is either shown or hidden, depending on the value of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter. If you hide a tab and it is the last visible tab in the underlying tab window, the tabbed pane is hidden. If you show a tab when there were previously no tabs visible, the tabbed pane is shown.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)