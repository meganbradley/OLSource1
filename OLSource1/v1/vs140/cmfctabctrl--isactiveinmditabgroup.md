---
title: "CMFCTabCtrl::IsActiveInMDITabGroup"
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
  - "CMFCTabCtrl.IsActiveInMDITabGroup"
  - "CMFCTabCtrl::IsActiveInMDITabGroup"
  - "IsActiveInMDITabGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsActiveInMDITabGroup method"
  - "CMFCTabCtrl::IsActiveInMDITabGroup"
ms.assetid: 395f0172-03e0-498a-8937-b3da63cd43c8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::IsActiveInMDITabGroup
Indicates whether the current tab of a tab control is the active tab in a multiple document interface tab group.  
  
## Syntax  
  
```  
BOOL IsActiveInMDITabGroup() const;  
```  
  
## Return Value  
 `TRUE` if the current tab of a tab control is the active tab in an MDI tab group; otherwise, `FALSE`.  
  
## Remarks  
 You can organize multiple document windows into either vertical or horizontal tab groups and easily shuffle documents from one tab group to another.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTabCtrl::SetActiveInMDITabGroup](../vs140/cmfctabctrl--setactiveinmditabgroup.md)   
 [Window Types](../vs140/kinds-of-windows.md)   
 [Managing MDI Child Windows](../vs140/managing-mdi-child-windows.md)