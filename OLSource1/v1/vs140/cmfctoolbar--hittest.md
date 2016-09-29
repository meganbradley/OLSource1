---
title: "CMFCToolBar::HitTest"
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
  - "CMFCToolBar::HitTest"
  - "CMFCToolBar.HitTest"
  - "HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: 542a5a56-7ffb-45c3-850b-7bb1c4802501
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::HitTest
Returns the index of the toolbar button that is located at the specified position.  
  
## Syntax  
  
```  
virtual int HitTest(  
   CPoint point   
);  
```  
  
#### Parameters  
 [in] `point`  
 The point to be tested, in client coordinates.  
  
## Return Value  
 The index of the button that is located at the specified position, or -1 if there is no such button or the button is a separator.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)