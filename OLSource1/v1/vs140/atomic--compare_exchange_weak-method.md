---
title: "atomic::compare_exchange_weak Method"
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
  - "atomic/std::atomic::compare_exchange_weak"
dev_langs: 
  - "C++"
ms.assetid: e15e421a-f7a3-4272-993a-f487d2242e4f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic::compare_exchange_weak Method
Performs a *weak atomic compare and exchange* operation on <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 First [memory_order](../vs140/memory_order-enum.md) argument.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Second <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument.  
  
## Return Value  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that indicates the result of the value comparison.  
  
## Remarks  
 This *atomic compare and exchange* operation compares the value that is stored in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If the values are equal, the operation replaces the value that is stored in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> by using a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operation and applying the memory order constraints that are specified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If the values are not equal, the operation uses the value that is stored in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to replace <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and applies the memory order constraints that are specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 A *weak* atomic compare and exchange operation performs an exchange if the compared values are equal. If the values are not equal, the operation is not guaranteed to perform an exchange.  
  
 Overloads that do not have a second <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> use an implicit <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> that is based on the value of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. In all other cases, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 For overloads that take two <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameters, the value of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> must not be <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, and must not be stronger than the value of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [atomic_compare_exchange_weak_explicit](../vs140/atomic_compare_exchange_weak_explicit-function.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [\<atomic>](../vs140/-atomic-.md)   
 [memory_order](../vs140/memory_order-enum.md)