---
title: "CMDIChildWndEx::DockPaneLeftOf"
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
  - "DockPaneLeftOf"
  - "CMDIChildWndEx.DockPaneLeftOf"
  - "CMDIChildWndEx::DockPaneLeftOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPaneLeftOf method"
ms.assetid: fbb23334-a8dd-41f9-a043-2b105177f8c3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::DockPaneLeftOf
Docks one pane to the left of another pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane that is to be docked.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the pane that serves as the point of reference.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on success, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 This method takes the pane specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and docks it at the left side of the pane specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Call this method when you want to dock several panes in predefined order.  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)