---
title: "CToolBar::SetSizes"
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
  - CToolBar.SetSizes
  - CToolBar::SetSizes
  - SetSizes
dev_langs: 
  - C++
helpviewer_keywords: 
  - size
  - toolbar controls [MFC], size
  - size, toolbar buttons
  - SetSizes method
  - CToolBar class, construction/destruction
ms.assetid: b3bb2116-005d-4f34-a99c-5d051a0901d3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBar::SetSizes
Call this member function to set the toolbar's buttons to the size, in pixels, specified in *sizeButton*.  
  
## Syntax  
  
```  
  
      void SetSizes(  
   SIZE sizeButton,  
   SIZE sizeImage   
);  
```  
  
#### Parameters  
 *sizeButton*  
 The size in pixels of each button.  
  
 `sizeImage`  
 The size in pixels of each image.  
  
## Remarks  
 The `sizeImage` parameter must contain the size, in pixels, of the images in the toolbar's bitmap. The dimensions in *sizeButton* must be sufficient to hold the image plus 7 pixels extra in width and 6 pixels extra in height. This function also sets the toolbar height to fit the buttons.  
  
 Call this member function only for toolbars that do not follow *Windows Interface Guidelines for Software Design* recommendations for button and image sizes.  
  
## Example  
 [!code[NVC_MFCListView#8](../vs140/codesnippet/CPP/ctoolbar--setsizes_1.cpp)]
  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::LoadBitmap](../vs140/ctoolbar--loadbitmap.md)   
 [CToolBar::SetButtonInfo](../vs140/ctoolbar--setbuttoninfo.md)   
 [CToolBar::SetButtons](../vs140/ctoolbar--setbuttons.md)