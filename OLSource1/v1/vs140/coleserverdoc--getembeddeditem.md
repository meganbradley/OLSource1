---
title: "COleServerDoc::GetEmbeddedItem"
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
  - "COleServerDoc.GetEmbeddedItem"
  - "GetEmbeddedItem"
  - "COleServerDoc::GetEmbeddedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, attributes"
  - "GetEmbeddedItem method"
ms.assetid: 38a42500-dbbb-42fd-8e2a-6eb5cb453819
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::GetEmbeddedItem
Call this function to get a pointer to an item representing the entire document.  
  
## Syntax  
  
```  
  
COleServerItem* GetEmbeddedItem( );  
```  
  
## Return Value  
 A pointer to an item representing the entire document; **NULL** if the operation failed.  
  
## Remarks  
 It calls [COleServerDoc::OnGetEmbeddedItem](../vs140/coleserverdoc--ongetembeddeditem.md), a virtual function with no default implementation.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::OnGetEmbeddedItem](../vs140/coleserverdoc--ongetembeddeditem.md)