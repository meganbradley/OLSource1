---
title: "CRichEditView::GetSelectedItem"
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
  - "CRichEditView.GetSelectedItem"
  - "CRichEditView::GetSelectedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, attributes"
  - "GetSelectedItem method"
ms.assetid: aa2f3e58-cbae-486a-ad35-ed9c47f6727f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::GetSelectedItem
Call this function to retrieve the OLE item (a `CRichEditCntrItem` object) currently selected in this `CRichEditView` object.  
  
## Syntax  
  
```  
  
CRichEditCntrItem* GetSelectedItem( ) const;  
  
```  
  
## Return Value  
 Pointer to a [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object selected in the `CRichEditView` object; **NULL** if no item is selected in this view.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCntrItem Class](../vs140/cricheditcntritem-class.md)   
 [CRichEditView::GetInPlaceActiveItem](../vs140/cricheditview--getinplaceactiveitem.md)