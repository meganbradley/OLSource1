---
title: "CMDIFrameWndEx::DockPaneLeftOf"
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
  - "CMDIFrameWndEx::DockPaneLeftOf"
  - "DockPaneLeftOf"
  - "CMDIFrameWndEx.DockPaneLeftOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPaneLeftOf method"
ms.assetid: fb6dc89f-3bcb-4c2a-b143-e50b1c5c1009
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::DockPaneLeftOf
Docks one pane to the left of another pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the docking pane.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the pane that serves as the dock site. .  
  
## Return Value  
 Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the operation is successful. Otherwise returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to dock several pane objects in a predefined order. This method docks the pane specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to the left of the pane specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows how the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#5](../vs140/codesnippet/CPP/cmdiframewndex--dockpaneleftof_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)