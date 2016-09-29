---
title: "CMFCTabCtrl::SetImageList"
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
  - "SetImageList"
  - "CMFCTabCtrl::SetImageList"
  - "CMFCTabCtrl.SetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImageList method"
ms.assetid: c51a4498-7da4-440b-bef7-a4895e449258
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::SetImageList
Specifies an image list.  
  
## Syntax  
  
```  
virtual BOOL SetImageList(  
   UINT uiID,  
   int cx=15,  
   COLORREF clrTransp=RGB(255,0,255)   
);  
virtual BOOL SetImageList(  
   HIMAGELIST hImageList   
);  
```  
  
#### Parameters  
 [in] `uiID`  
 The ID of a bitmap resource that contains the image list.  
  
 [in] `cx`  
 The width of each image, in pixels. The default value is 15.  
  
 [in] `clrTransp`  
 The transparent image color. The parts of the image that are this color will be transparent. The default value is the color magenta, RGB(255,0,255).  
  
 [in] `hImageList`  
 A handle to a preloaded image list.  
  
## Return Value  
 `TRUE` if this method is successful. `FALSE` if the tab control is created by using a flat style or if the first method overload cannot load the bitmap that is specified by the `uiID` parameter.  
  
## Remarks  
 Use this method to set an image list for the tab control. The images from the image list are displayed next to the tab label. This method recalculates the tab height so that the tab is sized to contain both the image and the text.  
  
 Use the [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md) method that is inherited by the tab control to specify the index of the image to display.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md)