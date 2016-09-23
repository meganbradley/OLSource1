---
title: "CRichEditDoc::GetView"
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
  - CRichEditDoc.GetView
  - GetView
  - CRichEditDoc::GetView
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetView method
ms.assetid: ed84e2e4-9e8b-420a-9881-c32294156ce4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditDoc::GetView
Call this function to access the [CRichEditView](../vs140/cricheditview-class.md) object associated with this `CRichEditDoc` object.  
  
## Syntax  
  
```  
  
virtual CRichEditView* GetView( ) const;  
  
```  
  
## Return Value  
 Pointer to the `CRichEditView` object associated with the document.  
  
## Remarks  
 The text and formatting information are contained within the `CRichEditView` object. The `CRichEditDoc` object maintains the OLE items for serialization. There should be only one `CRichEditView` for each `CRichEditDoc`.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditDoc Class](../vs140/cricheditdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [CDocument::GetNextView](../vs140/cdocument--getnextview.md)