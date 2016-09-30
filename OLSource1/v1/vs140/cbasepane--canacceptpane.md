---
title: "CBasePane::CanAcceptPane"
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
  - "CBasePane::CanAcceptPane"
  - "CanAcceptPane"
  - "CBasePane.CanAcceptPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAcceptPane method"
ms.assetid: fc49e62c-de9f-4f1c-8d50-5cb30acbe341
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanAcceptPane
Determines whether another pane can be docked to the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to dock.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if another pane can be accepted; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method before it docks the pane specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to the current pane.  
  
 Use this method and the [CanBeDocked](../vs140/cbasepane--canbedocked.md) method to control how panes dock to other panes in your application.  
  
 The default implementation returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)