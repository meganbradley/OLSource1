---
title: "concurrent_unordered_set::begin Method"
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
ms.assetid: 7cb17281-f30d-4f23-9662-cc655a920267
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set::begin Method
Returns an iterator pointing to the first element in the concurrent container. This method is concurrency safe.  
  
## Syntax  
  
```  
iterator begin();  
  
const_iterator begin() const;  
```  
  
## Return Value  
 An iterator to the first element in the concurrent container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)