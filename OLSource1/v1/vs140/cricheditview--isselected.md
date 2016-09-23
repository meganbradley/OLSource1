---
title: "CRichEditView::IsSelected"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRichEditView.IsSelected
  - IsSelected
  - CRichEditView::IsSelected
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsSelected method
  - CRichEditView class, overridables
ms.assetid: ca0a29f7-8de2-4e49-b59e-5fbb6cf614f9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditView::IsSelected
Call this function to determine if the specified OLE item is currently selected in this view.  
  
## Syntax  
  
```  
  
      virtual BOOL IsSelected(  
   const CObject* pDocItem   
) const;  
```  
  
#### Parameters  
 `pDocItem`  
 Pointer to an object in the view.  
  
## Return Value  
 Nonzero if the object is selected; otherwise 0.  
  
## Remarks  
 Override this function if your derived view class has a different method for handling selection of OLE items.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetSelectedItem](../vs140/cricheditview--getselecteditem.md)   
 [CRichEditView::GetInPlaceActiveItem](../vs140/cricheditview--getinplaceactiveitem.md)