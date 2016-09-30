---
title: "atomic::fetch_add Method"
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
  - "atomic/std::atomic::fetch_add"
dev_langs: 
  - "C++"
ms.assetid: c68b91f2-6e8a-4ffa-8991-6bb6d466e1f3
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_add Method
Fetches the value stored in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and then adds a specified value to the stored value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that contains the value stored in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> prior to the addition.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method performs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operation to atomically add <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the stored value in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and applies the memory constraints that are specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_add_explicit](../vs140/atomic_fetch_add_explicit-function.md)