---
title: "CMFCToolBar::SetMenuSizes"
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
  - "CMFCToolBar.SetMenuSizes"
  - "CMFCToolBar::SetMenuSizes"
  - "SetMenuSizes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenuSizes method"
ms.assetid: 0b5434c1-3f48-4ea0-821d-b67ed20bab84
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetMenuSizes
Sets the size of toolbar menu buttons and their images.  
  
## Syntax  
  
```  
static void __stdcall SetMenuSizes(  
   SIZE sizeButton,  
   SIZE sizeImage   
);  
```  
  
#### Parameters  
 [in] `sizeButton`  
 Specifies the size of toolbar buttons, in pixels.  
  
 [in] `sizeImage`  
 Specifies the size of toolbar images, in pixels.  
  
## Remarks  
 By default, menu buttons and their images have an undefined size.  
  
 Call the [CMFCToolBar::GetMenuButtonSize](../vs140/cmfctoolbar--getmenubuttonsize.md) method to determine the size of menu buttons and the [CMFCToolBar::GetMenuImageSize](../vs140/cmfctoolbar--getmenuimagesize.md) method to determine the size of menu button images.  
  
 See the IEDemo and MSMoneyDemo samples for examples that use this method.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetMenuButtonSize](../vs140/cmfctoolbar--getmenubuttonsize.md)   
 [CMFCToolBar::GetMenuImageSize](../vs140/cmfctoolbar--getmenuimagesize.md)