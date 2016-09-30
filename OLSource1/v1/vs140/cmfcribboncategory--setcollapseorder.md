---
title: "CMFCRibbonCategory::SetCollapseOrder"
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
  - "CMFCRibbonCategory.SetCollapseOrder"
  - "SetCollapseOrder"
  - "CMFCRibbonCategory::SetCollapseOrder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCollapseOrder method"
ms.assetid: ff4f65a8-7312-4d2a-8fa8-e98bf17fc6d1
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::SetCollapseOrder
Defines the order in which the ribbon panels of the ribbon category collapse.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the collapse order. The array contains zero-based indexes of ribbon panels.  
  
## Remarks  
 The library defines the collapse order. However, you can customize this behavior by providing the category with the list of indexes that specifies the collapse order.  
  
 When the category detects that it has to collapse a ribbon panel, it looks for the next element in the specified list. If the list is empty, or you have not specified enough elements, then the category uses the internal algorithm.  
  
 For example, the category has three ribbon panels and can be collapsed several times until all panels are in the fully collapsed state. You can set the following collapse order: 0, 0, 2, 2. In this case, the category will collapse the panel 0 two times, the panel 2 two times. The panel that has the index of 1 remains uncollapsed.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class. The example shows how to construct an array for the collapse order, and how to set the collapse order to the ribbon category.  
  
 [!code[NVC_MFC_RibbonApp#13](../vs140/codesnippet/CPP/cmfcribboncategory--setcollapseorder_1.cpp)]  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)