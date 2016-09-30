---
title: "partition_point"
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
  - "partition_point"
  - "algorithm/std::partition_point"
  - "std.partition_point"
  - "std::partition_point"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partition_point function"
  - "partition_point"
ms.assetid: 38751968-b720-429d-aca0-865f34ffad11
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partition_point
Returns the first element in the given range that does not satisfy the condition. The elements are sorted so that those that satisfy the condition come before those that do not.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that indicates the start of a range to check for a condition.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that indicates the end of a range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be satisfied by the element being searched for. A predicate takes a single argument and returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that refers to the first element that does not fulfill the condition tested for by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if one is not found.  
  
## Remarks  
 The template function finds the first iterator <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The sequence must be ordered by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)