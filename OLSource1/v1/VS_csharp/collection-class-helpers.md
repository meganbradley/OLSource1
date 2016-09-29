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
The collection classes `CMap`, `CList`, and `CArray` use templated global helper functions for such purposes as comparing, copying, and serializing elements. As part of your implementation of classes based on `CMap`, `CList`, and `CArray`, you must override these functions as necessary with versions tailored to the type of data stored in your map, list, or array. For information on overriding helper functions such as `SerializeElements`, see the article [Collections: How to Make a Type-Safe Collection](../VS_csharp/how-to--make-a-type-safe-collection.md). Note that **ConstructElements** and **DestructElements** have been deprecated.  
  
 The Microsoft Foundation Class Library provides the following global functions to help you customize your collection classes:  
  
### Collection Class Helpers  
  
|||  
|-|-|  
|[CompareElements](../VS_csharp/compareelements.md)|Indicates whether elements are the same.|  
|[CopyElements](../VS_csharp/copyelements.md)|Copies elements from one array to another.|  
|[DumpElements](../VS_csharp/dumpelements.md)|Provides stream-oriented diagnostic output.|  
|[HashKey](../VS_csharp/hashkey.md)|Calculates a hash key.|  
|[SerializeElements](../VS_csharp/serializeelements.md)|Stores or retrieves elements to or from an archive.|  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [CMap Class](../VS_csharp/cmap-class.md)   
 [CList Class](../VS_csharp/clist-class.md)   
 [CArray Class](../VS_csharp/carray-class.md)