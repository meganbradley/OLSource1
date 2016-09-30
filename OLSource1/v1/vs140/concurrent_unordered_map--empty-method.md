---
title: "concurrent_unordered_map::empty Method"
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
  - "internal_concurrent_hash/concurrency::concurrent_unordered_map::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: bfeb81c7-3dff-4a4e-95c9-2cddc95886b8
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::empty Method
Tests whether no elements are present. This method is concurrency safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the concurrent container is empty, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 In the presence of concurrent inserts, whether or not the concurrent container is empty may change immediately after calling this function, before the return value is even read.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)