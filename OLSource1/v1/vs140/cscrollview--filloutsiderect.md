---
title: "CScrollView::FillOutsideRect"
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
  - "CScrollView.FillOutsideRect"
  - "FillOutsideRect"
  - "CScrollView::FillOutsideRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "FillOutsideRect method"
ms.assetid: 0d08195d-723b-4062-b4f3-c803a31de17a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::FillOutsideRect
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to fill the area of the view that appears outside of the scrolling area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Device context in which the filling is to be done.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Brush with which the area is to be filled.  
  
## Remarks  
 Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in your scroll view's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> handler function to prevent excessive background repainting.  
  
## Example  
 [!code[NVC_MFCDocView#164](../vs140/codesnippet/CPP/cscrollview--filloutsiderect_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnEraseBkgnd](../vs140/cwnd--onerasebkgnd.md)