---
title: "concurrent_queue::unsafe_size Method"
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
  - "concurrent_queue/concurrency::concurrent_queue::unsafe_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsafe_size method"
ms.assetid: cea93331-3c14-4db3-96ca-3a3f8ed75c9b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_queue::unsafe_size Method
Returns the number of items in the queue. This method is not concurrency-safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The size of the concurrent queue.  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is not concurrency-safe and can produce incorrect results if called concurrently with calls to the methods <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_queue.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_queue Class](../vs140/concurrent_queue-class.md)