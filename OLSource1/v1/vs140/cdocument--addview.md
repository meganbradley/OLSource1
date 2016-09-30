---
title: "CDocument::AddView"
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
  - "CDocument::AddView"
  - "CDocument.AddView"
  - "AddView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddView method"
  - "views, document"
  - "CDocument class, operations"
  - "document views"
ms.assetid: 7bcd7c7a-39b8-4359-bb7c-2c1b49683269
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::AddView
Call this function to attach a view to the document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the view being added.  
  
## Remarks  
 This function adds the specified view to the list of views associated with the document; the function also sets the view's document pointer to this document. The framework calls this function when attaching a newly created view object to a document; this occurs in response to a File New, File Open, or New Window command or when a splitter window is split.  
  
 Call this function only if you are manually creating and attaching a view. Typically you will let the framework connect documents and views by defining a [CDocTemplate](../vs140/cdoctemplate-class.md) object to associate a document class, view class, and frame window class.  
  
## Example  
 [!code[NVC_MFCDocViewSDI#12](../vs140/codesnippet/CPP/cdocument--addview_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [CDocument::GetFirstViewPosition](../vs140/cdocument--getfirstviewposition.md)   
 [CDocument::GetNextView](../vs140/cdocument--getnextview.md)   
 [CDocument::RemoveView](../vs140/cdocument--removeview.md)   
 [CView::GetDocument](../vs140/cview--getdocument.md)