---
title: "COleLinkingDoc::OnFindEmbeddedItem"
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
  - "OnFindEmbeddedItem"
  - "COleLinkingDoc.OnFindEmbeddedItem"
  - "COleLinkingDoc::OnFindEmbeddedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFindEmbeddedItem method"
  - "COleLinkingDoc class, overridables"
ms.assetid: a227dbc7-0bcc-4352-9ccf-cb1ef4295e60
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleLinkingDoc::OnFindEmbeddedItem
Called by the framework to determine whether the document contains an embedded OLE item with the specified name.  
  
## Syntax  
  
```  
  
      virtual COleClientItem* OnFindEmbeddedItem(  
   LPCTSTR lpszItemName   
);  
```  
  
#### Parameters  
 `lpszItemName`  
 Pointer to the name of the embedded OLE item requested.  
  
## Return Value  
 A pointer to the specified item; **NULL** if the item is not found.  
  
## Remarks  
 The default implementation searches the list of embedded items for an item with the specified name (the name comparison is case sensitive). Override this function if you have your own method of storing or naming embedded OLE items.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleLinkingDoc Class](../vs140/colelinkingdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [COleLinkingDoc::OnGetLinkedItem](../vs140/colelinkingdoc--ongetlinkeditem.md)