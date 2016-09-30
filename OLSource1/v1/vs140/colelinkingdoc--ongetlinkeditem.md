---
title: "COleLinkingDoc::OnGetLinkedItem"
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
  - "COleLinkingDoc.OnGetLinkedItem"
  - "OnGetLinkedItem"
  - "COleLinkingDoc::OnGetLinkedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetLinkedItem method"
  - "COleLinkingDoc class, overridables"
ms.assetid: 48fd246a-ae87-451a-be9f-16d8cd01731a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleLinkingDoc::OnGetLinkedItem
Called by the framework to check whether the document contains a linked server item with the specified name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the name of the linked OLE item requested.  
  
## Return Value  
 A pointer to the specified item; **NULL** if the item is not found.  
  
## Remarks  
 The default <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> implementation always returns **NULL**. This function is overriden in the derived class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to search the list of OLE server items for a linked item with the specified name (the name comparison is case sensitive). Override this function if you have implemented your own method of storing or retrieving linked server items.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleLinkingDoc Class](../vs140/colelinkingdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::GetItemName](../vs140/coleserveritem--getitemname.md)   
 [COleServerItem::SetItemName](../vs140/coleserveritem--setitemname.md)   
 [COleLinkingDoc::OnFindEmbeddedItem](../vs140/colelinkingdoc--onfindembeddeditem.md)