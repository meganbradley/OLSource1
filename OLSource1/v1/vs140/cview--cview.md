---
title: "CView::CView"
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
  - "CView::CView"
  - "CView.CView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "View object construction"
  - "CView class, constructors"
ms.assetid: 62c52836-1dd5-4cbd-a205-b4756e5b8a80
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::CView
Constructs a `CView` object.  
  
## Syntax  
  
```  
  
CView( );  
```  
  
## Remarks  
 The framework calls the constructor when a new frame window is created or a window is split. Override the [OnInitialUpdate](../vs140/cview--oninitialupdate.md) member function to initialize the view after the document is attached.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md)