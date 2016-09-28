---
title: "CMFCOutlookBarTabCtrl::SetToolbarImageList"
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
  - "CMFCOutlookBarTabCtrl::SetToolbarImageList"
  - "CMFCOutlookBarTabCtrl.SetToolbarImageList"
  - "SetToolbarImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetToolbarImageList method"
ms.assetid: 121c66ca-9b29-4c39-9786-8acc4dc05d2f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarTabCtrl::SetToolbarImageList
Sets the bitmap that contains the icons that are displayed on the bottom of the Outlook bar in Outlook 2003 mode.  
  
## Syntax  
  
```  
BOOL SetToolbarImageList(  
   UINT uiID,  
   int cx,  
   COLORREF clrTransp=RGB(255,0,255)   
);  
```  
  
#### Parameters  
 [in] `uiID`  
 Specifies the resource ID of the image to load.  
  
 [in] `cx`  
 Specifies the width of an image in the image list, in pixels.  
  
 [in] `clrTransp`  
 An RGB value that specifies the transparent color.  
  
## Return Value  
 Returns `TRUE` if successful; otherwise returns `FALSE`.  
  
## Remarks  
 Use this function to attach an image list whose images will be displayed on toolbar buttons in Microsoft Office 2003 mode. Image indexes should correspond to page indexes.  
  
 This method should not be called if not in Microsoft Office 2003 mode. For more information, see [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md).  
  
## Requirements  
 **Header:** afxOutlookBarTabCtrl.h  
  
## See Also  
 [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)