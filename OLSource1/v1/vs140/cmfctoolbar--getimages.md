---
title: "CMFCToolBar::GetImages"
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
  - "CMFCToolBar.GetImages"
  - "CMFCToolBar::GetImages"
  - "GetImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImages method"
ms.assetid: 515b8334-9e62-4bed-8dab-2215fe37e593
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetImages
Returns a pointer to the collection of default button images in the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md) object that contains the collection of default images for all toolbars in the application.  
  
## Remarks  
 This shared method provides access to the collection of all default toolbar images for the application. Call the [CMFCToolBar::LoadBitmap](../vs140/cmfctoolbar--loadbitmap.md) method to add images to the collection.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [CMFCToolBar::LoadBitmap](../vs140/cmfctoolbar--loadbitmap.md)