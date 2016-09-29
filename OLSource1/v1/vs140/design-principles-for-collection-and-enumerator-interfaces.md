---
title: "Design Principles for Collection and Enumerator Interfaces"
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
  - "enumerator interfaces"
  - "collection interfaces"
ms.assetid: ea19a39e-6333-41a1-be62-5435c236640e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Design Principles for Collection and Enumerator Interfaces
There are different design principles behind each type of interface:  
  
-   A collection interface provides *random* access to a *single* item in the collection via the **Item** method, it lets clients discover how many items are in the collection via the **Count** property, and often allows clients to add and remove items.  
  
-   An enumerator interface provides *serial* access to *multiple* items in a collection, it doesn't allow the client to discover how many items are in the collection (until the enumerator stops returning items), and it doesn't provide any way of adding or removing items.  
  
 Each type of interface plays a different role in providing access to the elements in a collection.  
  
## See Also  
 [Collections and Enumerators](../vs140/atl-collections-and-enumerators.md)