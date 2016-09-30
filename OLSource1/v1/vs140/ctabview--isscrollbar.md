---
title: "CTabView::IsScrollBar"
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
  - "IsScrollBar"
  - "CTabView::IsScrollBar"
  - "CTabView.IsScrollBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsScrollBar method"
ms.assetid: d0821a08-b609-49b5-9ad3-ba3c18055914
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabView::IsScrollBar
Called by the framework when creating a tab view to determine whether the tab view has a shared horizontal scroll bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the tab view should be created together with a shared scroll bar. Otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method when a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is being created.  
  
 Override the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived class and return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if you want to create a view that has a shared horizontal scroll bar.  
  
## Requirements  
 **Header:** afxTabView.h  
  
## See Also  
 [CTabView Class](../vs140/ctabview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)