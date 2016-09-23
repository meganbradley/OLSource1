---
title: "CMFCToolBar::DoPaint"
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
  - CMFCToolBar::DoPaint
  - CMFCToolBar.DoPaint
  - DoPaint
dev_langs: 
  - C++
helpviewer_keywords: 
  - DoPaint method
ms.assetid: 96ffa004-fb8b-4b1d-b056-bc89620715de
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::DoPaint
Repaints a toolbar.  
  
## Syntax  
  
```  
virtual void DoPaint(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
## Remarks  
 This method is called by the framework when a part of the toolbar must be repainted.  
  
 Override this method to customize the appearance of an object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)