---
title: "How to: Iterate Over a User-Defined Collection with for each"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "collections, iterating over"
ms.assetid: 0efd9e3c-d7bb-4f6c-9938-e0e65d191433
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Iterate Over a User-Defined Collection with for each
For a class to be a managed collection, it needs a non-private GetEnumerator function that returns a handle to an Enumerator class or an interface.  An enumerator class must contain the declaration for non-static MoveNext function and Current property.  
  
## Example  
 Simple user defined collection with reference types.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Return Code: 0**   
## See Also  
 [for each, in](../vs140/for-each--in.md)