---
title: "CMFCListCtrl::OnCompareItems"
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
  - "CMFCListCtrl.OnCompareItems"
  - "OnCompareItems"
  - "CMFCListCtrl::OnCompareItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCompareItems method"
ms.assetid: e82216f7-a10e-4d49-9989-16f27c8d447b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCListCtrl::OnCompareItems
The framework calls this method when it compares two items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first item to compare.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second item to compare.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The index of the column that this method is sorting.  
  
## Return Value  
 An integer that indicates the relative position of the two items. A negative value indicates that the first item should precede the second, positive value indicates that the first item should follow the second, and zero means that the two items are equivalent.  
  
## Remarks  
 The default implementation always returns 0. You must override this function to provide a sorting algorithm.  
  
## Requirements  
 **Header:** afxlistctrl.h  
  
## See Also  
 [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)