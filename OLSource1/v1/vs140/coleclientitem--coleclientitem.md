---
title: "COleClientItem::COleClientItem"
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
  - "COleClientItem::COleClientItem"
  - "COleClientItem.COleClientItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, constructor"
ms.assetid: 00886648-ccb5-4f20-9715-5b7271f7ef97
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::COleClientItem
Constructs a `COleClientItem` object and adds it to the container document's collection of document items, which constructs only the C++ object and does not perform any OLE initialization.  
  
## Syntax  
  
```  
  
      COleClientItem(  
   COleDocument* pContainerDoc = NULL   
);  
```  
  
#### Parameters  
 `pContainerDoc`  
 Pointer to the container document that will contain this item. This can be any [COleDocument](../vs140/coledocument-class.md) derivative.  
  
## Remarks  
 If you pass a **NULL** pointer, no addition is made to the container document. You must explicitly call [COleDocument::AddItem](../vs140/coledocument--additem.md).  
  
 You must call one of the following creation member functions before you use the OLE item:  
  
-   [CreateFromClipboard](../vs140/coleclientitem--createfromclipboard.md)  
  
-   [CreateFromData](../vs140/coleclientitem--createfromdata.md)  
  
-   [CreateFromFile](../vs140/coleclientitem--createfromfile.md)  
  
-   [CreateStaticFromClipboard](../vs140/coleclientitem--createstaticfromclipboard.md)  
  
-   [CreateStaticFromData](../vs140/coleclientitem--createstaticfromdata.md)  
  
-   [CreateLinkFromClipboard](../vs140/coleclientitem--createlinkfromclipboard.md)  
  
-   [CreateLinkFromData](../vs140/coleclientitem--createlinkfromdata.md)  
  
-   [CreateLinkFromFile](../vs140/coleclientitem--createlinkfromfile.md)  
  
-   [CreateNewItem](../vs140/coleclientitem--createnewitem.md)  
  
-   [CreateCloneFrom](../vs140/coleclientitem--createclonefrom.md)  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument Class](../vs140/coledocument-class.md)   
 [COleDocument::AddItem](../vs140/coledocument--additem.md)