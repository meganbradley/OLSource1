---
title: "CMDIFrameWndEx::OnShowCustomizePane"
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
  - "CMDIFrameWndEx.OnShowCustomizePane"
  - "CMDIFrameWndEx::OnShowCustomizePane"
  - "OnShowCustomizePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowCustomizePane method"
ms.assetid: c37aaf3d-0194-4d9f-9137-2cdf5d62db20
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnShowCustomizePane
Called by the framework when a Quick Customize pane is activated.  
  
## Syntax  
  
```  
virtual BOOL OnShowCustomizePane(  
   CMFCPopupMenu* pMenuPane,  
   UINT uiToolbarID   
);  
```  
  
#### Parameters  
 [in] `pMenuPane`  
 A pointer to the Quick Customize pane.  
  
 [in] `uiToolbarID`  
 Control ID of the toolbar to customize.  
  
## Return Value  
 This method always returns `TRUE`.  
  
## Remarks  
 The Quick Customize pane is a menu that opens when the user clicks **Customize** on a toolbar.  
  
 Override this method in a derived class to make changes in the Quick Customize pane.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)