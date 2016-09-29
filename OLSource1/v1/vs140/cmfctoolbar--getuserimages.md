---
title: "CMFCToolBar::GetUserImages"
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
  - "CMFCToolBar::GetUserImages"
  - "GetUserImages"
  - "CMFCToolBar.GetUserImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUserImages method"
ms.assetid: d91c7c85-64c2-4858-97fe-1a9771da9162
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetUserImages
Returns a pointer to the collection of user-defined toolbar button images in the application.  
  
## Syntax  
  
```  
static CMFCToolBarImages* GetUserImages();  
```  
  
## Return Value  
 A pointer to the collection of user-defined toolbar button images for all toolbars in the application.  
  
## Remarks  
 Call the [CMFCToolBar::SetUserImages](../vs140/cmfctoolbar--setuserimages.md) method to set the collection of user-defined images in the application.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [CMFCToolBar::SetUserImages](../vs140/cmfctoolbar--setuserimages.md)