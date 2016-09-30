---
title: "CMFCToolBar::GetLockedMenuImages"
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
  - "CMFCToolBar::GetLockedMenuImages"
  - "GetLockedMenuImages"
  - "CMFCToolBar.GetLockedMenuImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLockedMenuImages method"
ms.assetid: 3f7b6f57-bcd1-489f-9616-2f2eb6d866dc
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetLockedMenuImages
Returns a pointer to the collection of locked toolbar menu images in the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the collection of locked toolbar menu images, or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the toolbar is not locked.  
  
## Remarks  
 Locked images are versions of the regular toolbar menu images that the framework uses when the user cannot customize the toolbar.  
  
 This method returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md).  
  
 Call the [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md) method to load the locked menu images.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsLocked](../vs140/cmfctoolbar--islocked.md)   
 [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)