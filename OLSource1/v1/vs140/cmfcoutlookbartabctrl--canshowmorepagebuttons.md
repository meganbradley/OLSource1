---
title: "CMFCOutlookBarTabCtrl::CanShowMorePageButtons"
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
  - "CMFCOutlookBarTabCtrl.CanShowMorePageButtons"
  - "CanShowMorePageButtons"
  - "CMFCOutlookBarTabCtrl::CanShowMorePageButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanShowMorePageButtons method"
ms.assetid: 6077d00d-c642-4ead-a6eb-f75669ad2d37
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarTabCtrl::CanShowMorePageButtons
Called by the framework during resizing operations to determine whether more Outlook bar tab page buttons can be displayed than are currently visible.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if there are buttons that are not currently visible; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The Outlook bar tab control dynamically adds or removes tabs from the display, depending on how much room is available. This method is used by the framework to assist in that process.  
  
## Requirements  
 **Header:** afxoutlookbartabctrl.h  
  
## See Also  
 [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)