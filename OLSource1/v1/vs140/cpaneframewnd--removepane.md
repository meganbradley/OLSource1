---
title: "CPaneFrameWnd::RemovePane"
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
  - "RemovePane"
  - "CPaneFrameWnd::RemovePane"
  - "CPaneFrameWnd.RemovePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemovePane method"
ms.assetid: a83fbdb7-1d29-4618-9887-d946d752aab6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::RemovePane
Removes a pane from the mini-frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to remove.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies what happens to the mini-frame window. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, this method destroys the mini-frame window immediately. If it is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, this method destroys the mini-frame window after a certain delay.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, delayed destruction is disabled. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, delayed destruction is enabled.  
  
## Remarks  
 The framework can destroy mini-frame windows immediately or after a certain delay. If you want to delay destruction of mini-frame windows, pass <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter. Delayed destruction occurs when the framework processes the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> message.  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)