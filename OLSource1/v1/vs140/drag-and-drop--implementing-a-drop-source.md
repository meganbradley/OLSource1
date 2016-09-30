---
title: "Drag and Drop: Implementing a Drop Source"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE drag and drop, initiating drag operations"
  - "drag and drop, calling DoDragDrop"
  - "OLE drag and drop, drop source"
  - "OLE drag and drop, calling DoDragDrop"
  - "drag and drop, initiating drag operations"
  - "drag and drop, drop source"
ms.assetid: 0ed2fda0-63fa-4b1e-b398-f1f142f40035
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Drag and Drop: Implementing a Drop Source
This article explains how to get your application to provide data to a drag-and-drop operation.  
  
 Basic implementation of a drop source is relatively simple. The first step is to determine what events begin a drag operation. Recommended user interface guidelines define the beginning of a drag operation as the selection of data and a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> event occurring on a point inside the selected data. The MFC OLE samples [OCLIENT](../vs140/visual-c---samples.md) and [HIERSVR](../vs140/visual-c---samples.md) follow these guidelines.  
  
 If your application is a container and the selected data is a linked or an embedded object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, call its <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function. Otherwise, construct a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object, initialize it with the selection, and call the data source object's <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function. If your application is a server, use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For information about customizing standard drag-and-drop behavior, see the article [Drag and Drop: Customizing](../vs140/drag-and-drop--customizing.md).  
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, delete the source data from the source document immediately. No other return value from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has any effect on a drop source.  
  
 For more information, see:  
  
-   [Implementing a Drop Target](../vs140/drag-and-drop--implementing-a-drop-target.md)  
  
-   [Customizing Drag and Drop](../vs140/drag-and-drop--customizing.md)  
  
-   [Creating and Destroying OLE Data Objects and Data Sources](../vs140/data-objects-and-data-sources--creation-and-destruction.md)  
  
-   [Manipulating OLE Data Objects and Data Sources](../vs140/data-objects-and-data-sources--manipulation.md)  
  
## See Also  
 [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md)   
 [COleDataSource::DoDragDrop](../vs140/coledatasource--dodragdrop.md)   
 [COleClientItem::DoDragDrop](../vs140/coleclientitem--dodragdrop.md)   
 [CView::OnDragLeave](../vs140/cview--ondragleave.md)