---
title: "CDocument::OnChangedViewList"
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
  - "CDocument.OnChangedViewList"
  - "CDocument::OnChangedViewList"
  - "OnChangedViewList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocument class, overridables"
  - "views, document"
  - "removing views"
  - "OnChangedViewList method"
  - "document views"
ms.assetid: 75c402df-1b5d-4e43-8479-bac9385864c4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnChangedViewList
Called by the framework after a view is added to or removed from the document.  
  
## Syntax  
  
```  
  
virtual void OnChangedViewList( );  
```  
  
## Remarks  
 The default implementation of this function checks whether the last view is being removed and, if so, deletes the document. Override this function if you want to perform special processing when the framework adds or removes a view. For example, if you want a document to remain open even when there are no views attached to it, override this function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::AddView](../vs140/cdocument--addview.md)   
 [CDocument::RemoveView](../vs140/cdocument--removeview.md)