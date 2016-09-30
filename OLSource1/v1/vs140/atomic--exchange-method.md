---
title: "atomic::exchange Method"
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
  - "atomic/std::atomic::exchange"
dev_langs: 
  - "C++"
ms.assetid: a1a72697-2a2a-45b4-a299-93bbffebe1c5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::exchange Method
Uses a specified value to replace the stored value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 The stored value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> before the exchange.  
  
## Remarks  
 This operation performs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operation to use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to replace the value that is stored in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, within the memory constraints that are specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_exchange_explicit](../vs140/atomic_exchange_explicit-function.md)