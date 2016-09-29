---
title: "source_link_manager::begin Method"
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
  - "agents/concurrency::source_link_manager::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method"
ms.assetid: 245bd0c7-563b-4b0d-9e4c-ee6f7cd89cd4
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_link_manager::begin Method
Returns an iterator to the first element in the `source_link_manager` object.  
  
## Syntax  
  
```  
iterator begin();  
```  
  
## Return Value  
 An iterator addressing the first element in the `source_link_manager` object.  
  
## Remarks  
 The end state of the iterator is indicated by a `NULL` link.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_link_manager Class](../VS_csharp/source_link_manager-class.md)