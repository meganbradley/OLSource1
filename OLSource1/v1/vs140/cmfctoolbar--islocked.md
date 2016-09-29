---
title: "CMFCToolBar::IsLocked"
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
  - "CMFCToolBar::IsLocked"
  - "IsLocked"
  - "CMFCToolBar.IsLocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsLocked method"
ms.assetid: e16a9849-7355-41df-a970-dfa5d2425365
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsLocked
Determines whether the toolbar is locked.  
  
## Syntax  
  
```  
BOOL IsLocked() const;  
```  
  
## Return Value  
 `TRUE` if the toolbar is locked; otherwise, `FALSE`.  
  
## Remarks  
 This method returns `TRUE` when the user cannot perform customization tasks such as repositioning toolbar buttons.  
  
 Locked toolbars use separate image lists. For more information about these image lists, see [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::LoadBitmapEx](../vs140/cmfctoolbar--loadbitmapex.md)