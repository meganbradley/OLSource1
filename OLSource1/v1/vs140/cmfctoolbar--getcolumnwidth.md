---
title: "CMFCToolBar::GetColumnWidth"
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
  - "CMFCToolBar::GetColumnWidth"
  - "GetColumnWidth"
  - "CMFCToolBar.GetColumnWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColumnWidth method"
ms.assetid: 9909b6bb-e6b0-4df7-9b5a-5a8a2cc4f657
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetColumnWidth
Returns the width of the toolbar buttons.  
  
## Syntax  
  
```  
virtual int GetColumnWidth() const;  
```  
  
## Return Value  
 A value that specifies the width of toolbar buttons.  
  
## Remarks  
 The framework calls this method to calculate toolbar layout. Override this method in a derived class to specify a different column width for your toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)