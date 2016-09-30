---
title: "CDocument::RemoveView"
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
  - "CDocument::RemoveView"
  - "RemoveView"
  - "CDocument.RemoveView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "views, removing"
  - "RemoveView method"
  - "removing document views"
  - "document views, removing"
  - "CDocument class, operations"
ms.assetid: 3b4d8ec0-9ce2-4647-aa20-57a2262347a8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::RemoveView
Call this function to detach a view from a document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the view being removed.  
  
## Remarks  
 This function removes the specified view from the list of views associated with the document; it also sets the view's document pointer to **NULL**. This function is called by the framework when a frame window is closed or a pane of a splitter window is closed.  
  
 Call this function only if you are manually detaching a view. Typically you will let the framework detach documents and views by defining a [CDocTemplate](../vs140/cdoctemplate-class.md) object to associate a document class, view class, and frame window class.  
  
 See the example at [AddView](../vs140/cdocument--addview.md) for a sample implementation.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::AddView](../vs140/cdocument--addview.md)   
 [CDocument::GetFirstViewPosition](../vs140/cdocument--getfirstviewposition.md)   
 [CDocument::GetNextView](../vs140/cdocument--getnextview.md)