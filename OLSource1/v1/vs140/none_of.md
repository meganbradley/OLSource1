---
title: "none_of"
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
  - "algorithm/std::none_of"
  - "std.none_of"
  - "std::none_of"
  - "none_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "none_of function"
  - "none_of"
ms.assetid: 1308303a-4ccc-44d9-aeb5-6c703cccf40e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# none_of
Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when a condition is never present among elements in the given range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start to check a range of elements for a condition.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range of elements.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition. A predicate takes a single argument and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the condition is not detected at least once in the indicated range, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the condition is detected.  
  
## Remarks  
 The template function returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> only if, for some <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the predicate <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is always <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [any_of](../vs140/any_of.md)   
 [all_of](../vs140/all_of.md)   
 [Standard Template Library](../vs140/standard-template-library.md)