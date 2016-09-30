---
title: "atomic_store_explicit Function"
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
  - "atomic/std::atomic_store_explicit"
dev_langs: 
  - "C++"
ms.assetid: daae6724-56d9-43d7-a174-c208b5dea3a3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_store_explicit Function
Atomically stores a value in an atomic object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that contains a value of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/memory_order-enum.md). Do not use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> stores <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the object that is pointed to by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, within the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that is specified by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)