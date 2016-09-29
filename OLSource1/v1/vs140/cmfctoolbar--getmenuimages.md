---
title: "CMFCToolBar::GetMenuImages"
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
  - "CMFCToolBar.GetMenuImages"
  - "GetMenuImages"
  - "CMFCToolBar::GetMenuImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenuImages method"
ms.assetid: 640d596e-bc48-4801-9712-0a3da54e3e84
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetMenuImages
Returns a pointer to the collection of menu button images in the application.  
  
## Syntax  
  
```  
static CMFCToolBarImages* GetMenuImages();  
```  
  
## Return Value  
 A pointer to the collection of menu images.  
  
## Remarks  
 Call the [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md) method to load the menu images.  
  
 Call the [CMFCToolBar::SetMenuSizes](../vs140/cmfctoolbar--setmenusizes.md) method to set the size of buttons and their images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)   
 [CMFCToolBar::SetMenuSizes](../vs140/cmfctoolbar--setmenusizes.md)