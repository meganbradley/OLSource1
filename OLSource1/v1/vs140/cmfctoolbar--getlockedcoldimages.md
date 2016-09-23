---
title: "CMFCToolBar::GetLockedColdImages"
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
  - CMFCToolBar::GetLockedColdImages
  - CMFCToolBar.GetLockedColdImages
  - GetLockedColdImages
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetLockedColdImages method
ms.assetid: c640a243-d215-4e03-b268-318a056e7c5a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::GetLockedColdImages
Returns a pointer to the collection of locked cold images in the toolbar.  
  
## Syntax  
  
```  
CMFCToolBarImages* GetLockedColdImages();  
```  
  
## Return Value  
 A pointer to the collection of locked cold images, or `NULL` if the toolbar is not locked.  
  
## Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar. Cold images are the images that are used when the user is not interacting with the toolbar buttons.  
  
 This method returns `NULL` if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md).  
  
 Call the [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md) method to load the locked cold images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md)   
 [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)