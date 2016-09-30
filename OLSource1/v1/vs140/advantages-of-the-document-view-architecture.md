---
title: "Advantages of the Document-View Architecture"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Advantages of the Document/View Architecture"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "views, advantages"
  - "document/view architecture, advantages of"
ms.assetid: 0bc27071-e120-4889-939c-ce1e61fb9cb3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Advantages of the Document-View Architecture
The key advantage to using the MFC document/view architecture is that the architecture supports multiple views of the same document particularly well. (If you don't need multiple views and the small overhead of document/view is excessive in your application, you can avoid the architecture. [Alternatives to the Document/View Architecture](../vs140/alternatives-to-the-document-view-architecture.md).)  
  
 Suppose your application lets users view numerical data either in spreadsheet form or in chart form. A user might want to see simultaneously both the raw data, in spreadsheet form, and a chart that results from the data. You display these separate views in separate frame windows or in splitter panes within a single window. Now suppose the user can edit the data in the spreadsheet and see the changes instantly reflected in the chart.  
  
 In MFC, the spreadsheet view and the chart view would be based on different classes derived from CView. Both views would be associated with a single document object. The document stores the data (or perhaps obtains it from a database). Both views access the document and display the data they retrieve from it.  
  
 When a user updates one of the views, that view object calls <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. That function notifies all of the document's views, and each view updates itself using the latest data from the document. The single call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> synchronizes the different views.  
  
 This scenario would be difficult to code without the separation of data from view, particularly if the views stored the data themselves. With document/view, it's easy. The framework does most of the coordination work for you.  
  
## What do you want to know more about?  
  
-   [Alternatives to document/view](../vs140/alternatives-to-the-document-view-architecture.md)  
  
-   [CDocument](../vs140/cdocument-class.md)  
  
-   [CView](../vs140/cview-class.md)  
  
-   [CDocument::UpdateAllViews](../vs140/cdocument--updateallviews.md)  
  
-   [CView::GetDocument](../vs140/cview--getdocument.md)  
  
## See Also  
 [Document/View Architecture](../vs140/document-view-architecture.md)