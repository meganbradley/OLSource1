---
title: "atomic_compare_exchange_strong Function"
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
  - "atomic/std::atomic_compare_exchange_strong"
dev_langs: 
  - "C++"
ms.assetid: a2bebb09-78f5-4d15-bc60-6290e96e0f7f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_compare_exchange_strong Function
Performs an atomic compare and exchange operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that indicates the result of the value comparison.  
  
## Remarks  
 This method performs an atomic compare and exchange operation by using implicit <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>[memory_order](../vs140/memory_order-enum.md) arguments. For more information, see [atomic_compare_exchange_strong_explicit Function](../vs140/atomic_compare_exchange_strong_explicit-function.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)