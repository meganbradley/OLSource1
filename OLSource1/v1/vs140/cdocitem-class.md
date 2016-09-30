---
title: "CDocItem Class"
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
  - "CDocItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "items, document"
  - "document items"
  - "server documents, document items"
  - "CDocItem class"
  - "container document items"
  - "client document items"
  - "OLE documents, items"
  - "server documents"
ms.assetid: 84fb8610-a4c8-4211-adc0-e70e8d002c11
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocItem Class
The base class for document items, which are components of a document's data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocItem::GetDocument](#cdocitem__getdocument)|Returns the document that contains the item.|  
|[CDocItem::IsBlank](#cdocitem__isblank)|Determines whether the item contains any information.|  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects are used to represent OLE items in both client and server documents.  
  
 For more information, see the article [Containers: Implementing a Container](../vs140/containers--implementing-a-container.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxole.h  
  
##  \<a name="cdocitem__getdocument">\</a>  CDocItem::GetDocument  
 Call this function to get the document that contains the item.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the document that contains the item; **NULL**, if the item is not part of a document.  
  
### Remarks  
 This function is overridden in the derived classes [COleClientItem](../vs140/coleclientitem-class.md) and [COleServerItem](../vs140/coleserveritem-class.md), returning a pointer to either a [COleDocument](../vs140/coledocument-class.md), a [COleLinkingDoc](../vs140/colelinkingdoc-class.md), or a [COleServerDoc](../vs140/coleserverdoc-class.md) object.  
  
##  \<a name="cdocitem__isblank">\</a>  CDocItem::IsBlank  
 Called by the framework when default serialization occurs.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the item contains no information; otherwise 0.  
  
### Remarks  
 By default, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects are not blank. [COleClientItem](../vs140/coleclientitem-class.md) objects are sometimes blank because they derive directly from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. However, [COleServerItem](../vs140/coleserveritem-class.md) objects are always blank. By default, OLE applications containing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects that have no x or y extent are serialized. This is done by returning **TRUE** from an override of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when the item has no x or y extent.  
  
 Override this function if you want to implement other actions during serialization.  
  
## See Also  
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument](../vs140/coledocument-class.md)   
 [COleServerItem](../vs140/coleserveritem-class.md)   
 [COleClientItem](../vs140/coleclientitem-class.md)