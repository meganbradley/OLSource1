---
title: "atomic_store Function"
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
  - "atomic/std::atomic_store"
dev_langs: 
  - "C++"
ms.assetid: 9c6a89c3-314d-4ad5-8144-e4d783edff94
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_store Function
Atomically stores a value in an atomic object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an atomic object that contains a value of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> stores <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the object that is pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, within the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>[memory_order](../vs140/memory_order-enum.md) constraint.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_store_explicit](../vs140/atomic_store_explicit-function.md)