---
title: "concurrent_unordered_map::at Method"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map::at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
ms.assetid: e64bf194-8ea3-4344-bbbd-73d528394654
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::at Method
Finds an element in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with a specified key value.. This method is concurrency-safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key value to find.  
  
## Return Value  
 A reference to the data value of the element found.  
  
## Remarks  
 If the argument key value is not found, the function throws an object of class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)