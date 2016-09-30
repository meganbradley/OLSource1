---
title: "CScrollView::ResizeParentToFit"
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
  - "CScrollView::ResizeParentToFit"
  - "ResizeParentToFit"
  - "CScrollView.ResizeParentToFit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "ResizeParentToFit method"
ms.assetid: 17382950-a2bf-4710-870c-73b384b28f5e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::ResizeParentToFit
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to let the size of your view dictate the size of its frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *bShrinkOnly*  
 The kind of resizing to perform. The default value, **TRUE**, shrinks the frame window if appropriate. Scroll bars will still appear for large views or small frame windows. A value of **FALSE** causes the view always to resize the frame window exactly. This can be somewhat dangerous since the frame window could get too big to fit inside the multiple document interface (MDI) frame window or the screen.  
  
## Remarks  
 This is recommended only for views in MDI child frame windows. Use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> handler function of your derived <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class. For an example of this member function, see [CScrollView::SetScrollSizes](../vs140/cscrollview--setscrollsizes.md).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> assumes that the size of the view window has been set. If the view window size has not been set when <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called, you will get an assertion. To ensure that this does not happen, make the following call before calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCDocView#165](../vs140/codesnippet/CPP/cscrollview--resizeparenttofit_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md)   
 [CScrollView::SetScrollSizes](../vs140/cscrollview--setscrollsizes.md)