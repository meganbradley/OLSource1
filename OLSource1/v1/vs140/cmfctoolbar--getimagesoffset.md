---
title: "CMFCToolBar::GetImagesOffset"
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
  - CMFCToolBar.GetImagesOffset
  - CMFCToolBar::GetImagesOffset
  - GetImagesOffset
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetImagesOffset method
ms.assetid: 07e275bd-35e5-4174-bfef-8b73986c58ac
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::GetImagesOffset
Returns the index offset used to find the toolbar button images for this toolbar in the global list of toolbar button images.  
  
## Syntax  
  
```  
int GetImagesOffset() const;  
```  
  
## Return Value  
 The index offset of the toolbar images.  
  
## Remarks  
 All toolbar default images are stored in the global [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md) list. The images for each button in the toolbar are stored consecutively in that list. To compute the index of the image, add the index of the button in the toolbar to the offset of the beginning of the list of images for that toolbar button.  
  
 Call [CMFCToolBar::ButtonToIndex](../vs140/cmfctoolbar--buttontoindex.md) to obtain the index of a toolbar button given a pointer to the button.  
  
 Call [CMFCToolBar::GetImages](../vs140/cmfctoolbar--getimages.md) to obtain a pointer to the collection of toolbar images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)