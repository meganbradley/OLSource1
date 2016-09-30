---
title: "CPane::RecalcLayout"
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
  - "CPane::RecalcLayout"
  - "CPane.RecalcLayout"
  - "RecalcLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RecalcLayout method"
ms.assetid: ff0b0804-f58a-45a5-9844-012e3dca50f6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::RecalcLayout
Recalculates layout information for the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the pane is docked, this method updates the virtual rectangle for the pane by setting its size to the current size of the pane.  
  
 If the pane is floating, this method notifies the parent mini-frame to adjust the size of the pane to the size of the mini-frame. The framework ensures that the mini-frame is at least the minimum allowed size for the pane ([CPane::GetMinSize](../vs140/cpane--getminsize.md)) and resizes the mini-frame if necessary.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)