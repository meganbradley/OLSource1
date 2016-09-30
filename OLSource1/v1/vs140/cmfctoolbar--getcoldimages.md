---
title: "CMFCToolBar::GetColdImages"
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
  - "GetColdImages"
  - "CMFCToolBar::GetColdImages"
  - "CMFCToolBar.GetColdImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColdImages method"
ms.assetid: 7f962f9a-cc95-458c-b073-67d5853fd5b6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetColdImages
Returns a pointer to the collection of cold toolbar button images in the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the collection of cold toolbar button images.  
  
## Remarks  
 Cold images are the images that are used when the user is not interacting with the toolbar buttons. Call [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md) or [CMFCToolBar::LoadBitmap](../vs140/cmfctoolbar--loadbitmap.md) to load the cold images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)   
 [CMFCToolBar::LoadBitmap](../vs140/cmfctoolbar--loadbitmap.md)