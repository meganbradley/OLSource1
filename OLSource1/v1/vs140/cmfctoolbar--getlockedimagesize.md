---
title: "CMFCToolBar::GetLockedImageSize"
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
  - "GetLockedImageSize"
  - "CMFCToolBar.GetLockedImageSize"
  - "CMFCToolBar::GetLockedImageSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLockedImageSize method"
ms.assetid: 0193b7e2-777d-4a15-9b80-2e47ac0987b2
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetLockedImageSize
Returns the default size of locked toolbar images.  
  
## Syntax  
  
```  
CSize GetLockedImageSize() const;  
```  
  
## Return Value  
 A `CSize` structure that specifies the size of locked toolbar images or an empty `CSize` structure if the toolbar is not locked.  
  
## Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar.  
  
 This method returns a `CSize` structure with zero width and zero height if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md).  
  
 Call the [CMFCToolBar::SetLockedSizes](../vs140/cmfctoolbar--setlockedsizes.md) method to specify the locked image size.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md)   
 [CMFCToolBar::SetLockedSizes](../vs140/cmfctoolbar--setlockedsizes.md)