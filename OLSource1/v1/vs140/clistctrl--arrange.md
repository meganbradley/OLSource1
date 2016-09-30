---
title: "CListCtrl::Arrange"
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
  - "LVA_DEFAULT"
  - "LVA_SNAPTOGRID"
  - "Arrange"
  - "CListCtrl::Arrange"
  - "LVA_ALIGNTOP"
  - "LVA_ALIGNLEFT"
  - "CListCtrl.Arrange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVA_ALIGNTOP"
  - "LVA_ALIGNLEFT"
  - "LVA_DEFAULT"
  - "LVA_SNAPTOGRID"
  - "Arrange method"
ms.assetid: 43235a7a-58d3-4780-8bcd-99b35c60eca0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::Arrange
Repositions items in an icon view so that they align on a grid.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the alignment style for the items. It can be one of the following values:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Aligns items along the left edge of the window.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Aligns items along the top edge of the window.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Aligns items according to the list view's current alignment styles (the default value).  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Snaps all icons to the nearest grid position.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter specifies the alignment style.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#2](../vs140/codesnippet/CPP/clistctrl--arrange_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::EnsureVisible](../vs140/clistctrl--ensurevisible.md)