---
title: "CRichEditView::GetInPlaceActiveItem"
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
  - "CRichEditView.GetInPlaceActiveItem"
  - "CRichEditView::GetInPlaceActiveItem"
  - "GetInPlaceActiveItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInPlaceActiveItem method"
  - "CRichEditView class, attributes"
ms.assetid: 00bb819a-0dd3-40c5-9803-fbb078e9bb0f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::GetInPlaceActiveItem
Call this function to get the OLE item that is currently activated in place in this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the single, in-place active [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object in this rich edit view; **NULL** if there is no OLE item currently in the in-place active state.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::GetInPlaceActiveItem](../vs140/coledocument--getinplaceactiveitem.md)   
 [CRichEditCntrItem Class](../vs140/cricheditcntritem-class.md)   
 [CRichEditView::GetSelectedItem](../vs140/cricheditview--getselecteditem.md)