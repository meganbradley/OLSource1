---
title: "CRichEditView::GetDocument"
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
  - "CRichEditView.GetDocument"
  - "CRichEditView::GetDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocument method"
  - "CRichEditView class, attributes"
ms.assetid: 318f6b2f-1523-41a3-9c16-87fea82b43fe
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::GetDocument
Call this function to get a pointer to the `CRichEditDoc` associated with this view.  
  
## Syntax  
  
```  
  
CRichEditDoc* GetDocument( ) const;  
  
```  
  
## Return Value  
 Pointer to a [CRichEditDoc](../vs140/cricheditdoc-class.md) object associated with your `CRichEditView` object.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditDoc Class](../vs140/cricheditdoc-class.md)   
 [CView::GetDocument](../vs140/cview--getdocument.md)   
 [COleClientItem::GetDocument](../vs140/coleclientitem--getdocument.md)