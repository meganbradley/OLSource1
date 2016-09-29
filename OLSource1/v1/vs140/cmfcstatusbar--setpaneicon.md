---
title: "CMFCStatusBar::SetPaneIcon"
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
  - "SetPaneIcon"
  - "CMFCStatusBar.SetPaneIcon"
  - "CMFCStatusBar::SetPaneIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPaneIcon method"
ms.assetid: e589b715-581f-4b83-94dd-95e5996cabe3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCStatusBar::SetPaneIcon
Set the icon of the status bar pane.  
  
## Syntax  
  
```  
void SetPaneIcon(  
   int nIndex,  
   HICON hIcon,  
   BOOL bUpdate=TRUE   
);  
void SetPaneIcon(  
   int nIndex,  
   HBITMAP hBmp,  
   COLORREF clrTransparent=RGB(255,0,255),  
   BOOL bUpdate=TRUE   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the index of the pane for which to set the image.  
  
 [in] `hIcon`  
 Specifies a handle to the icon to be set as the pane image.  
  
 [in] `bUpdate`  
 Specifies whether to update the pane content immediately.  
  
 [in] `hBmp`  
 Specifies a handle to the bitmap to be set as the pane image.  
  
 [in] `clrTransparent`  
 Specifies the transparent color of the bitmap that the `hBmp` indicates.  
  
## Remarks  
 You can pass either `HICON` or `HBITMAP` together with the transparent color to set the pane's image. If you do not want to display the image any longer, pass the `NULL` value as the image handle.  
  
 If there is any running animation that [CMFCStatusBar::SetPaneAnimation](../vs140/cmfcstatusbar--setpaneanimation.md) has set, the animation will be stopped.  
  
## Requirements  
 **Header:** afxstatusbar.h  
  
## See Also  
 [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)