---
title: "CFrameWndEx::OnShowCustomizePane"
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
  - "CFrameWndEx::OnShowCustomizePane"
  - "OnShowCustomizePane"
  - "CFrameWndEx.OnShowCustomizePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowCustomizePane method"
ms.assetid: a6c376e1-8f6a-4584-82e4-407465d0168c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnShowCustomizePane
Called by the framework when it displays a `QuickCustomizePane`.  
  
## Syntax  
  
```  
virtual BOOL OnShowCustomizePane(  
   CMFCPopupMenu* pMenuPane,  
   UINT uiToolbarID   
);  
```  
  
#### Parameters  
 [in] `pMenuPane`  
 A pointer to the quick customize pane.  
  
 [in] `uiToolbarID`  
 The control ID of the toolbar to customize.  
  
## Return Value  
 This method always return `TRUE`.  
  
## Remarks  
 The quick customize menu is a pop-up menu that appears when you click the toolbar’s customize button  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)