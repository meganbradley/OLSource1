---
title: "CMFCToolBar::AdjustSize"
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
  - "CMFCToolBar::AdjustSize"
  - "CMFCToolBar.AdjustSize"
  - "AdjustSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AdjustSize method"
ms.assetid: 0d157738-fe0d-4e90-b12a-c6cf7a0529fa
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::AdjustSize
Recalculates the size of the toolbar.  
  
## Syntax  
  
```  
void AdjustSize();  
```  
  
## Remarks  
 This method makes sure that the toolbar fits in the bounds of the parent frame. This method does nothing if the toolbar has no parent frame.  
  
 The [CMFCToolBar::AdjustLayout](../vs140/cmfctoolbar--adjustlayout.md) method calls this method to recalculate the size if the parent of the toolbar is not a `CMFCReBar` object.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::AdjustLayout](../vs140/cmfctoolbar--adjustlayout.md)   
 [CMFCReBar Class](../vs140/cmfcrebar-class.md)