---
title: "CMFCToolBar::GetLockedDisabledImages"
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
  - GetLockedDisabledImages
  - CMFCToolBar.GetLockedDisabledImages
  - CMFCToolBar::GetLockedDisabledImages
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetLockedDisabledImages method
ms.assetid: bed1e0ee-5755-4769-b56f-de6325eb47c7
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::GetLockedDisabledImages
Returns a pointer to the collection of locked disabled images in the toolbar.  
  
## Syntax  
  
```  
CMFCToolBarImages* GetLockedDisabledImages();  
```  
  
## Return Value  
 A pointer to the collection of locked disabled images, or `NULL` if the toolbar is not locked.  
  
## Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar. Disabled images are the images that the framework uses when a button has the `TBBS_DISABLED` style.  
  
 This method returns `NULL` if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md).  
  
 Call the [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md) method to load the locked disabled images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md)   
 [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)