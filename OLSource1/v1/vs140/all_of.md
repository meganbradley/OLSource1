---
title: "all_of"
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
  - "algorithm/std::all_of"
  - "std::all_of"
  - "std.all_of"
  - "all_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "all_of function"
  - "all_of"
ms.assetid: 11770601-c597-4b1a-9796-88490853c385
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# all_of
Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when a condition is present at each element in the given range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start to check for a condition. The iterator marks where a range of elements starts.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of the range of elements to check for a condition.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A condition to test for. This is a user-defined predicate function object that defines the condition to be satisfied by an element being checked. A predicate takes a single argument and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the condition is detected at each element in the indicated range, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the condition is not detected at least one time.  
  
## Remarks  
 The template function returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> only if, for each <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the predicate <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [any_of](../vs140/any_of.md)   
 [none_of](../vs140/none_of.md)   
 [Standard Template Library](../vs140/standard-template-library.md)