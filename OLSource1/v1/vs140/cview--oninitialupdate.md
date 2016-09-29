---
title: "CView::OnInitialUpdate"
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
  - "CView.OnInitialUpdate"
  - "CView::OnInitialUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "initial update of view"
  - "updating views"
  - "CView class, overridables"
  - "OnInitialUpdate method"
ms.assetid: fb0a209e-4b2e-41b2-b4f9-de89e817fec0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnInitialUpdate
Called by the framework after the view is first attached to the document, but before the view is initially displayed.  
  
## Syntax  
  
```  
  
virtual void OnInitialUpdate( );  
```  
  
## Remarks  
 The default implementation of this function calls the [OnUpdate](../vs140/cview--onupdate.md) member function with no hint information (that is, using the default values of 0 for the `lHint` parameter and **NULL** for the `pHint` parameter). Override this function to perform any one-time initialization that requires information about the document. For example, if your application has fixed-sized documents, you can use this function to initialize a view's scrolling limits based on the document size. If your application supports variable-sized documents, use [OnUpdate](../vs140/cview--onupdate.md) to update the scrolling limits every time the document changes.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnUpdate](../vs140/cview--onupdate.md)