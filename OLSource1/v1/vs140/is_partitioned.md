---
title: "is_partitioned"
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
  - "std::is_partitioned"
  - "algorithm/std::is_partitioned"
  - "std.is_partitioned"
  - "is_partitioned"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_partitioned function"
  - "is_partitioned"
ms.assetid: a5f91d88-6f31-44e5-afe4-3fdedb18f4b2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_partitioned
Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if all the elements in the given range that test <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for a condition come before any elements that test <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator that indicates where a range starts to check for a condition.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be satisfied by the element being searched for. A predicate takes a single argument and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns true when all of the elements in the given range that test <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for a condition come before any elements that test <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and otherwise returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The template function returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> only if all elements in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> are partitioned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>; that is, all elements <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is true occur before all elements <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [is_sorted](../vs140/is_sorted.md)   
 [is_sorted_until](../vs140/is_sorted_until.md)   
 [partition_point](../vs140/partition_point.md)   
 [partition_copy](../vs140/partition_copy.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)