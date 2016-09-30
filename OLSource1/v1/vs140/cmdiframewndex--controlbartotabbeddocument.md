---
title: "CMDIFrameWndEx::ControlBarToTabbedDocument"
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
  - "ControlBarToTabbedDocument"
  - "CMDIFrameWndEx::ControlBarToTabbedDocument"
  - "CMDIFrameWndEx.ControlBarToTabbedDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ControlBarToTabbedDocument method"
ms.assetid: 918347a6-1710-4271-aeba-c01657cb7e84
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::ControlBarToTabbedDocument
Converts the specified docking pane to a tabbed document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the docking pane to convert.  
  
## Return Value  
 Returns a pointer to the new MDI child window that contains the docking pane.  
  
## Remarks  
 This method converts a docking pane to a tabbed document. When you call this method, the framework creates a [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md) object, removes the docking pane from the docking manager, and adds the docking pane to the new MDI child window. The MDI child window resizes the docking pane to cover the entire client area  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)