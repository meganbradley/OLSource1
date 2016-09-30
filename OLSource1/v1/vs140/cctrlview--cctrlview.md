---
title: "CCtrlView::CCtrlView"
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
  - "CCtrlView.CCtrlView"
  - "CCtrlView::CCtrlView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCtrlView class, constructor"
ms.assetid: b2426fe8-80e5-42a4-9864-bd516b12849a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCtrlView::CCtrlView
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Windows class name of the view class.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Style of the view class.  
  
## Remarks  
 The framework calls the constructor when a new frame window is created or a window is split. Override [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md) to initialize the view after the document is attached. Call [CWnd::Create](../vs140/cwnd--create.md) or [CWnd::CreateEx](../vs140/cwnd--createex.md) to create the Windows object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCtrlView Class](../vs140/cctrlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::PreCreateWindow](../vs140/cwnd--precreatewindow.md)