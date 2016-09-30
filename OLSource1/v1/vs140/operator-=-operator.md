---
title: "operator&lt;= Operator"
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
  - "concurrent_vector/concurrency::operator<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<= operator"
ms.assetid: 646d93df-15e6-4cd4-9967-2465ed000fe0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= Operator
Tests if the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object on the left side of the operator is less than or equal to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The allocator type of the first <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The allocator type of the second <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the concurrent vector on the left side of the operator is less than or equal to the concurrent vector on the right side of the operator; otherwise <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 The behavior of this operator is identical to the equivalent operator for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> namespace.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)