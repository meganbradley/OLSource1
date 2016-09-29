---
title: "CMFCRibbonStatusBarPane::CMFCRibbonStatusBarPane"
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
  - "CMFCRibbonStatusBarPane.CMFCRibbonStatusBarPane"
  - "CMFCRibbonStatusBarPane"
  - "CMFCRibbonStatusBarPane::CMFCRibbonStatusBarPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonStatusBarPane class, constructor"
ms.assetid: 46f6f9f2-6017-442f-9701-371e1551cefc
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonStatusBarPane::CMFCRibbonStatusBarPane
Construct a pane object in the status bar.  
  
## Syntax  
  
```  
CMFCRibbonStatusBarPane(  
   UINT nCmdID,  
   LPCTSTR lpszText,  
   BOOL bIsStatic=FALSE,  
   HICON hIcon=NULL,  
   LPCTSTR lpszAlmostLargeText=NULL   
);  
CMFCRibbonStatusBarPane(  
   UINT nCmdID,  
   LPCTSTR lpszText,  
   HBITMAP hBmpAnimationList,  
   int cxAnimation=16,  
   COLORREF clrTrnsp=RGB(192,  
   192 1,  
   192) 1,  
   HICON hIcon=NULL,  
   BOOL bIsStatic=FALSE   
);  
CMFCRibbonStatusBarPane(  
   UINT nCmdID,  
   LPCTSTR lpszText,  
   UINT uiAnimationListResID,  
   int cxAnimation=16,  
   COLORREF clrTrnsp=RGB(192,  
   192 1,  
   192) 1,  
   HICON hIcon=NULL,  
   BOOL bIsStatic=FALSE   
);  
```  
  
#### Parameters  
 [in] `nCmdID`  
 Specifies the command ID of the pane.  
  
 [in] `lpszText`  
 Specifies text string to be displayed on pane.  
  
 [in] `bIsStatic`  
 If `TRUE`, the status pane cannot be highlighted or selected by clicking it.  
  
 [in] `hIcon`  
 Specifies a handle to an icon to be displayed on the pane.  
  
 [in] `lpszAlmostLargeText`  
 Specifies the longest text string that can be displayed by the pane.  
  
 [in] `hBmpAnimationList`  
 Specifies a handle to an image list that is used for animation.  
  
 [in] `cxAnimation`  
 Specifies the width, in pixels, of the icon in the image list that is used for animation.  
  
 [in] `clrTrnsp`  
 Specifies the transparent color of images in the image list that are used for animation.  
  
 [in] `uiAnimationListResID`  
 Specifies a resource ID of an image list that is used for animation.  
  
## Requirements  
 **Header:** afxribbonstatusbarpane.h  
  
## See Also  
 [CMFCRibbonStatusBarPane Class](../vs140/cmfcribbonstatusbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)