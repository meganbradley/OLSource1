---
title: "COleClientItem::Delete"
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
  - "COleClientItem::Delete"
  - "COleClientItem.Delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Delete method"
  - "COleClientItem class, general operations"
ms.assetid: b14fa6bb-fece-46e5-b633-8fbd5eaa3a6c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::Delete
Call this function to delete the OLE item from the container document.  
  
## Syntax  
  
```  
  
      void Delete(  
   BOOL bAutoDelete = TRUE   
);  
```  
  
#### Parameters  
 `bAutoDelete`  
 Specifies whether the item is to be removed from the document.  
  
## Remarks  
 This function calls the [Release](../vs140/coleclientitem--release.md) member function, which in turn deletes the C++ object for the item, permanently removing the OLE item from the document. If the OLE item is embedded, the native data for the item is deleted. It always closes a running server; therefore, if the item is an open link, this function closes it.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::Release](../vs140/coleclientitem--release.md)