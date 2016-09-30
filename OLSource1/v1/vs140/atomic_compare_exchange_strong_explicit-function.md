---
title: "atomic_compare_exchange_strong_explicit Function"
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
  - "atomic/std::atomic_compare_exchange_strong_explicit"
dev_langs: 
  - "C++"
ms.assetid: 54e12e84-d6c8-4a84-a2a5-112595335e82
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_compare_exchange_strong_explicit Function
Performs an *atomic compare and exchange* operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 First [memory_order](../vs140/memory_order-enum.md) argument.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Second <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument. The value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> cannot be <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, it cannot be stronger than the value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Return Value  
 A <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that indicates the result of the value comparison.  
  
## Remarks  
 An *atomic compare and exchange operation* compares the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> against the value that is pointed to by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If the values are equal, the the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is replaced with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> by using a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operation and applying the memory order constraints that are specified by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If the values are not equal, the operation replaces the value that is pointed to by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> with the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and applies the memory order constraints that are specified by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)