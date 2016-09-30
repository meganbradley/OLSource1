---
title: "CMFCStatusBar::SetPaneAnimation"
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
  - "CMFCStatusBar.SetPaneAnimation"
  - "CMFCStatusBar::SetPaneAnimation"
  - "SetPaneAnimation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPaneAnimation method"
ms.assetid: c82fd8e3-1c8e-4f1c-b94b-ebcbe24337ac
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStatusBar::SetPaneAnimation
Assigns an animation to the specified pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the index of the pane to which you want to assign to it an animation.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a handle to the image list that holds the animation frames.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the frame rate, in milliseconds, for the animation.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, update the pane content immediately. Otherwise, the pane content is updated when it is invalidated.  
  
## Remarks  
 If you want to disable the current animation, call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)