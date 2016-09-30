---
title: "atomic_exchange Function"
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
  - "atomic/std::atomic_exchange"
dev_langs: 
  - "C++"
ms.assetid: c4d665b8-5749-4f00-910b-9d9aee30d5f7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_exchange Function
Uses <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to replace the stored value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 The stored value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> before the exchange.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operation to exchange the value that is stored in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[memory_order](../vs140/memory_order-enum.md).  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_exchange_explicit](../vs140/atomic_exchange_explicit-function.md)