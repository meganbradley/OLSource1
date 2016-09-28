---
title: "CView::IsSelected"
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
  - "CView.IsSelected"
  - "IsSelected"
  - "CView::IsSelected"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "documents, selecting"
  - "IsSelected method"
  - "CView class, overridables"
ms.assetid: 9763d7ee-b3b2-4b64-8c9d-8e8d191ad1a4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::IsSelected
Called by the framework to check whether the specified document item is selected.  
  
## Syntax  
  
```  
  
      virtual BOOL IsSelected(  
   const CObject* pDocItem   
) const;  
```  
  
#### Parameters  
 `pDocItem`  
 Points to the document item being tested.  
  
## Return Value  
 Nonzero if the specified document item is selected; otherwise 0.  
  
## Remarks  
 The default implementation of this function returns **FALSE**. Override this function if you are implementing selection using [CDocItem](../vs140/cdocitem-class.md) objects. You must override this function if your view contains OLE items.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocItem Class](../vs140/cdocitem-class.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)