---
title: "CDockablePane::CalcFixedLayout"
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
  - CDockablePane.CalcFixedLayout
  - CalcFixedLayout
  - CDockablePane::CalcFixedLayout
dev_langs: 
  - C++
helpviewer_keywords: 
  - CalcFixedLayout method
ms.assetid: 55711725-db9e-4244-a931-5ba10a1c6f0a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::CalcFixedLayout
Returns the size of the pane rectangle.  
  
## Syntax  
  
```  
virtual CSize CalcFixedLayout(  
   BOOL bStretch,  
   BOOL bHorz  
);  
```  
  
#### Parameters  
 [in] `bStretch`  
 Not used.  
  
 [in] `bHorz`  
 Not used.  
  
## Return Value  
 A `CSize` object that contains the size of the pane rectangle.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)