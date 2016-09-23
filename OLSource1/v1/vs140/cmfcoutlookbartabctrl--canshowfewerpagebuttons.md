---
title: "CMFCOutlookBarTabCtrl::CanShowFewerPageButtons"
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
  - CMFCOutlookBarTabCtrl::CanShowFewerPageButtons
  - CMFCOutlookBarTabCtrl.CanShowFewerPageButtons
  - CanShowFewerPageButtons
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanShowFewerPageButtons method
ms.assetid: ee803f37-2f83-42f9-bc4c-a7c75f9b9fd8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCOutlookBarTabCtrl::CanShowFewerPageButtons
Called by the framework during resizing operations to determine whether fewer Outlook bar tab page buttons can be displayed than are currently visible.  
  
## Syntax  
  
```  
virtual BOOL CanShowFewerPageButtons() const;  
```  
  
## Return Value  
 `TRUE` if there is more than one button; otherwise `FALSE`.  
  
## Remarks  
 The Outlook bar tab control dynamically adds or removes tabs from the display depending on how much room is available. This method is used by the framework to assist in that process.  
  
## Requirements  
 **Header:** afxoutlookbartabctrl.h  
  
## See Also  
 [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)