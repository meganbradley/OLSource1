---
title: "CMFCOutlookBar::OnBeforeAnimation"
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
  - "OnBeforeAnimation"
  - "CMFCOutlookBar.OnBeforeAnimation"
  - "CMFCOutlookBar::OnBeforeAnimation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnBeforeAnimation method"
ms.assetid: 0f578952-ee5b-4c36-80dc-09b909c8242b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar::OnBeforeAnimation
Called by [CMFCOutlookBarTabCtrl::SetActiveTab](../vs140/cmfcoutlookbartabctrl--setactivetab.md) before a tab page is set as the active tab using animation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the tab page that is about to be set active.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if animation should be used in setting the new active tab, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if animation should be disabled.  
  
## Remarks  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)