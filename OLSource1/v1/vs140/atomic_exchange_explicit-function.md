---
title: "atomic_exchange_explicit Function"
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
  - "atomic/std::atomic_exchange_explicit"
dev_langs: 
  - "C++"
ms.assetid: a49ec590-e1c0-4a98-95ce-22a5c0276aaa
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_exchange_explicit Function
Replaces the stored value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 The stored value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> before the exchange.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operation to exchange the value that is stored in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, within the memory constraints that are specified by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)