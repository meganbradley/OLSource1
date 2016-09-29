---
title: "CMFCToolBar::GetLockedImages"
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
  - "CMFCToolBar.GetLockedImages"
  - "GetLockedImages"
  - "CMFCToolBar::GetLockedImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLockedImages method"
ms.assetid: 69fd359f-f4a2-43dd-83fc-d8d655c72bb1
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetLockedImages
Returns a pointer to the collection of locked button images in the toolbar.  
  
## Syntax  
  
```  
CMFCToolBarImages* GetLockedImages();  
```  
  
## Return Value  
 A pointer to the collection of locked toolbar button images, or `NULL` if the toolbar is not locked.  
  
## Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar.  
  
 This method returns `NULL` if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md)