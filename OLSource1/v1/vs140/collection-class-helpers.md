---
title: "Collection Class Helpers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.mfc.macros.classes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DestructElements function"
  - "ConstructElements function"
  - "SerializeElements function"
  - "collection classes, helper functions"
  - "helper functions collection class"
ms.assetid: bc3a2368-9edd-4748-9e6a-13cba79517ca
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collection Class Helpers
The collection classes `CMap`, `CList`, and `CArray` use templated global helper functions for such purposes as comparing, copying, and serializing elements. As part of your implementation of classes based on `CMap`, `CList`, and `CArray`, you must override these functions as necessary with versions tailored to the type of data stored in your map, list, or array. For information on overriding helper functions such as `SerializeElements`, see the article [Collections: How to Make a Type-Safe Collection](../vs140/how-to--make-a-type-safe-collection.md). Note that **ConstructElements** and **DestructElements** have been deprecated.  
  
 The Microsoft Foundation Class Library provides the following global functions to help you customize your collection classes:  
  
### Collection Class Helpers  
  
|||  
|-|-|  
|[CompareElements](../vs140/compareelements.md)|Indicates whether elements are the same.|  
|[CopyElements](../vs140/copyelements.md)|Copies elements from one array to another.|  
|[DumpElements](../vs140/dumpelements.md)|Provides stream-oriented diagnostic output.|  
|[HashKey](../vs140/hashkey.md)|Calculates a hash key.|  
|[SerializeElements](../vs140/serializeelements.md)|Stores or retrieves elements to or from an archive.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CMap Class](../vs140/cmap-class.md)   
 [CList Class](../vs140/clist-class.md)   
 [CArray Class](../vs140/carray-class.md)