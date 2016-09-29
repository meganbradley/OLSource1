---
title: "CMFCTabCtrl::IsSharedScroll"
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
  - "CMFCTabCtrl::IsSharedScroll"
  - "CMFCTabCtrl.IsSharedScroll"
  - "IsSharedScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSharedScroll method"
  - "CMFCTabCtrl::IsSharedScroll"
ms.assetid: e33d8e6c-ab19-4209-b506-3f83c40a4097
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::IsSharedScroll
Indicates whether the current tab control has a scroll bar that can scroll its tabs as a group.  
  
## Syntax  
  
```  
BOOL IsSharedScroll() const;  
```  
  
## Return Value  
 `TRUE` if the tab control has a shared scroll bar; otherwise, `FALSE`.  
  
## Remarks  
 This method returns `TRUE` if the `style` parameter of the [CMFCTabCtrl::Create](../vs140/cmfctabctrl--create.md) method is STYLE_FLAT_SHARED_HORZ_SCROLL.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTabCtrl::Create](../vs140/cmfctabctrl--create.md)