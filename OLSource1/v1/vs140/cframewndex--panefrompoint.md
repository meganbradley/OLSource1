---
title: "CFrameWndEx::PaneFromPoint"
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
  - "CFrameWndEx::PaneFromPoint"
  - "PaneFromPoint"
  - "CFrameWndEx.PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: a17cf0eb-9cc4-44ac-847b-43826b23f74e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::PaneFromPoint
Searches each pane for the given point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The screen coordinates of the point to check.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Expand the bounding rectangle of each control bar by this amount when searching for point.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to ignore the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the method searches only the control bars of the specified type.  
  
 [out] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 If successful, this parameter contains the side of the control bar that is closest to the specified point. Otherwise, this parameter is not initialized.  
  
## Return Value  
 A pointer to a control bar that contains the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if no control is found.  
  
## Remarks  
 This method searches all the control bars in your application for a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 Use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to increase the size of the search area. Use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to restrict the types of control bars that the method searches.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)