---
title: "atomic::fetch_sub Method"
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
  - "atomic/std::atomic::fetch_sub"
dev_langs: 
  - "C++"
ms.assetid: 8cc80d4b-0942-45a3-9db8-bbf339a903e4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::fetch_sub Method
Subtracts a specified value from the stored value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that contains the result of the subtraction.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method performs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operation to atomically subtract <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from the stored value in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, within the memory constraints that are specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_sub_explicit](../vs140/atomic_fetch_sub_explicit-function.md)