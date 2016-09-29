---
title: "CMFCRibbonStatusBarPane::StartAnimation"
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
  - "StartAnimation"
  - "CMFCRibbonStatusBarPane.StartAnimation"
  - "CMFCRibbonStatusBarPane::StartAnimation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StartAnimation method"
ms.assetid: d61a850c-424f-476f-a763-0c853e3835aa
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBarPane::StartAnimation
Starts the animation that you assign to the pane.  
  
## Syntax  
  
```  
void StartAnimation(  
   UINT nFrameDelay=500,  
   UINT nDuration=-1   
);  
```  
  
#### Parameters  
 [in] `nFrameDelay`  
 Specifies the animation frame rate, in milliseconds.  
  
 [in] `nDuration`  
 Specifies how long to play the animation, in milliseconds. Use -1 for an infinite loop.  
  
## Remarks  
 You must specify a handle to an image list before you call `StartAnimation` by using `SetAnimationList`.  
  
## Requirements  
 **Header:** afxribbonstatusbarpane.h  
  
## See Also  
 [CMFCRibbonStatusBarPane Class](../vs140/cmfcribbonstatusbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)