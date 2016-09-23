---
title: "CMFCRibbonStatusBarPane::OnFinishAnimation"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnFinishAnimation
  - CMFCRibbonStatusBarPane::OnFinishAnimation
  - CMFCRibbonStatusBarPane.OnFinishAnimation
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnFinishAnimation method
ms.assetid: 2cd51372-c705-4504-82f7-0ad8eb582c2f
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonStatusBarPane::OnFinishAnimation
Framework calls this method when the animation that is assigned to the pane ends.  
  
## Syntax  
  
```  
virtual void OnFinishAnimation();  
```  
  
## Remarks  
 `StopAnimation` method calls the `OnFinishAnimation` method, which you can use to clean up data when the animation ends.  
  
## Requirements  
 **Header:** afxribbonstatusbarpane.h  
  
## See Also  
 [CMFCRibbonStatusBarPane Class](../vs140/cmfcribbonstatusbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)