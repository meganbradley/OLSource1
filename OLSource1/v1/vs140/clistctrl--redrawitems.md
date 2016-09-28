---
title: "CListCtrl::RedrawItems"
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
  - "CListCtrl::RedrawItems"
  - "RedrawItems"
  - "CListCtrl.RedrawItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RedrawItems method"
ms.assetid: d4670cd1-9eca-46db-b067-5170efa1e134
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::RedrawItems
Forces a list view control to repaint a range of items.  
  
## Syntax  
  
```  
  
      BOOL RedrawItems(  
   int nFirst,  
   int nLast   
);  
```  
  
#### Parameters  
 `nFirst`  
 Index of the first item to be repainted.  
  
 `nLast`  
 Index of the last item to be repainted.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The specified items are not actually repainted until the list view window receives a `WM_PAINT` message. To repaint immediately, call the Windows [UpdateWindow](http://msdn.microsoft.com/library/windows/desktop/dd145167) function after using this function.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::DrawItem](../vs140/clistctrl--drawitem.md)