---
title: "CFrameWndEx::OnCloseDockingPane"
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
  - "CFrameWndEx.OnCloseDockingPane"
  - "CFrameWndEx::OnCloseDockingPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCloseDockingPane method"
ms.assetid: 611c64d3-6a5f-41ee-a418-8138b939f687
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnCloseDockingPane
Called by the framework when the user clicks the **Close** button on a docking pane.  
  
## Syntax  
  
```  
virtual BOOL OnCloseDockingPane(  
   CDockablePane* pPane  
);  
```  
  
## Return Value  
 `TRUE` if the docking bar can be closed. `FALSE` otherwise  
  
## Remarks  
 The default implement does nothing. Override this method if you want to handle the hiding of the docking bar.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)