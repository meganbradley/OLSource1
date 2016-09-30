---
title: "CDocObjectServerItem Class"
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
  - "CDocObjectServerItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document object server"
  - "CDocObjectServerItem class"
  - "servers [C++], ActiveX documents"
  - "docobject server"
  - "servers [C++], doc objects"
  - "ActiveX documents [C++], document server"
ms.assetid: 530f7156-50c8-4806-9328-602c9133f622
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServerItem Class
Implements OLE server verbs specifically for DocObject servers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDocObjectServerItem::CDocObjectServerItem](#cdocobjectserveritem__cdocobjectserveritem)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocObjectServerItem::GetDocument](#cdocobjectserveritem__getdocument)|Retrieves a pointer to the document that contains the item.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDocObjectServerItem::OnHide](#cdocobjectserveritem__onhide)|Throws an exception if the framework tries to hide a DocObject item.|  
|[CDocObjectServerItem::OnShow](#cdocobjectserveritem__onshow)|Called by the framework to make the DocObject item in-place active. If the item is not a DocObject, calls [COleServerItem::OnShow](../vs140/coleserveritem-class.md#coleserveritem__onshow).|  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> defines overridable member functions: [OnHide](#cdocobjectserveritem__onhide), [OnOpen](assetId:///7a9b1363-6ad8-4732-9959-4e35c07644fd), and [OnShow](#cdocobjectserveritem__onshow).  
  
 To use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, assure that the [OnGetEmbeddedItem](../vs140/coleserverdoc-class.md#coleserverdoc__ongetembeddeditem) override in your <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived class returns a new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. If you need to change any functionality in your item, you can create a new instance of your own <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>-derived class.  
  
 For further information on DocObjects, see [CDocObjectServer](../vs140/cdocobjectserver-class.md) and [COleCmdUI](../vs140/colecmdui-class.md) in the                 *MFC Reference*. Also see [Internet First Steps: Active Documents](../vs140/active-documents-on-the-internet.md) and [Active Documents](../vs140/active-documents-on-the-internet.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CDocItem](../vs140/cdocitem-class.md)  
  
 [COleServerItem](../vs140/coleserveritem-class.md)  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdocob.h  
  
##  \<a name="cdocobjectserveritem__cdocobjectserveritem">\</a>  CDocObjectServerItem::CDocObjectServerItem  
 Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A pointer to the document that will contain the new DocObject item.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Indicates whether the object can be deleted when a link to it is released. Set the argument to **FALSE** if the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object is an integral part of your document's data. Set it to **TRUE** if the object is a secondary structure used to identify a range in your document's data that can be deleted by the framework.  
  
##  \<a name="cdocobjectserveritem__getdocument">\</a>  CDocObjectServerItem::GetDocument  
 Retrieves a pointer to the document that contains the item.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the document that contains the item; **NULL** if the item is not part of a document.  
  
### Remarks  
 This allows access to the server document that you passed as an argument to the [CDocObjectServerItem](#cdocobjectserveritem__cdocobjectserveritem) constructor.  
  
##  \<a name="cdocobjectserveritem__onhide">\</a>  CDocObjectServerItem::OnHide  
 Called by the framework to hide the item.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation throws an exception if the item is a DocObject. You cannot hide an active DocObject item because it takes the whole view. You must deactivate the DocObject item to make it disappear. If the item is not a DocObject, the default implementation calls [COleServerItem::OnHide](../vs140/coleserveritem-class.md#coleserveritem__onhide).  
  
##  \<a name="cdocobjectserveritem__onshow">\</a>  CDocObjectServerItem::OnShow  
 Called by the framework to instruct the server application to make the DocObject item in-place active.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 If the item is not a DocObject, the default implementation calls [COleServerItem::OnShow](../vs140/coleserveritem-class.md#coleserveritem__onopen). Override this function if you want to perform special processing when opening a DocObject item.  
  
## See Also  
 [Base Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServer](../vs140/cdocobjectserver-class.md)   
 [COleDocObjectItem](../vs140/coledocobjectitem-class.md)