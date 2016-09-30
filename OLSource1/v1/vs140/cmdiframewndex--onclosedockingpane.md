---
title: "CMDIFrameWndEx::OnCloseDockingPane"
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
  - "OnCloseDockingPane"
  - "CMDIFrameWndEx::OnCloseDockingPane"
  - "CMDIFrameWndEx.OnCloseDockingPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCloseDockingPane method"
ms.assetid: cc240c48-764d-4b71-9cd7-c0573cdacfb1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnCloseDockingPane
Called by the framework when the user clicks the **Close** button on a dockable pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the pane being closed.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the docking pane can be closed. Otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method to handle hiding of docking panes. Return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if you want to prevent a docking pane from being hidden.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)