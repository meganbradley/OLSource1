---
title: "CMFCOutlookBar::OnAfterAnimation"
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
  - CMFCOutlookBar.OnAfterAnimation
  - OnAfterAnimation
  - CMFCOutlookBar::OnAfterAnimation
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnAfterAnimation method
ms.assetid: e7e4016c-75d6-417b-a6a6-27ccacbacc79
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCOutlookBar::OnAfterAnimation
Called by [CMFCOutlookBarTabCtrl::SetActiveTab](../vs140/cmfcoutlookbartabctrl--setactivetab.md) after the active tab has been set using animation.  
  
## Syntax  
  
```  
virtual void OnAfterAnimation(  
   int nPage  
);  
```  
  
#### Parameters  
 [in] `nPage`  
 The zero-based index of the tab page that has been made active.  
  
## Remarks  
 The visual effect of setting the active tab depends on whether you have enabled animation. For more information, see [CMFCOutlookBarTabCtrl::EnableAnimation](../vs140/cmfcoutlookbartabctrl--enableanimation.md).  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)