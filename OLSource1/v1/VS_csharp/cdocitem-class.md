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
  
```  
class CDocItem : public CCmdTarget  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocItem::GetDocument](#cdocitem__getdocument)|Returns the document that contains the item.|  
|[CDocItem::IsBlank](#cdocitem__isblank)|Determines whether the item contains any information.|  
  
## Remarks  
 `CDocItem` objects are used to represent OLE items in both client and server documents.  
  
 For more information, see the article [Containers: Implementing a Container](../VS_csharp/containers--implementing-a-container.md).  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 `CDocItem`  
  
## Requirements  
 **Header:** afxole.h  
  
##  <a name="cdocitem__getdocument"></a>  CDocItem::GetDocument  
 Call this function to get the document that contains the item.  
  
```  
CDocument* GetDocument( ) const;  
  
```  
  
### Return Value  
 A pointer to the document that contains the item; **NULL**, if the item is not part of a document.  
  
### Remarks  
 This function is overridden in the derived classes [COleClientItem](../VS_csharp/coleclientitem-class.md) and [COleServerItem](../VS_csharp/coleserveritem-class.md), returning a pointer to either a [COleDocument](../VS_csharp/coledocument-class.md), a [COleLinkingDoc](../VS_csharp/colelinkingdoc-class.md), or a [COleServerDoc](../VS_csharp/coleserverdoc-class.md) object.  
  
##  <a name="cdocitem__isblank"></a>  CDocItem::IsBlank  
 Called by the framework when default serialization occurs.  
  
```  
virtual BOOL IsBlank( ) const;  
  
```  
  
### Return Value  
 Nonzero if the item contains no information; otherwise 0.  
  
### Remarks  
 By default, `CDocItem` objects are not blank. [COleClientItem](../VS_csharp/coleclientitem-class.md) objects are sometimes blank because they derive directly from `CDocItem`. However, [COleServerItem](../VS_csharp/coleserveritem-class.md) objects are always blank. By default, OLE applications containing `COleClientItem` objects that have no x or y extent are serialized. This is done by returning **TRUE** from an override of `IsBlank` when the item has no x or y extent.  
  
 Override this function if you want to implement other actions during serialization.  
  
## See Also  
 [Base Class](../VS_csharp/ccmdtarget-class.md)   
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [COleDocument](../VS_csharp/coledocument-class.md)   
 [COleServerItem](../VS_csharp/coleserveritem-class.md)   
 [COleClientItem](../VS_csharp/coleclientitem-class.md)