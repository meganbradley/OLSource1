---
title: "any_of"
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
  - "any_of"
  - "algorithm/std::any_of"
  - "std.any_of"
  - "std::any_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "any_of function"
  - "any_of"
ms.assetid: c0a685f6-8242-42c6-b1bc-3956d25ae535
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# any_of
Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when a condition is present at least once in the specified range of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start checking a range of elements for a condition.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of the range of elements to check for a condition.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A condition to test for. This is provided by a user-defined predicate function object. The predicate defines the condition to be satisfied by the element being tested. A predicate takes a single argument and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the condition is detected at least once in the indicated range, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the condition is never detected.  
  
## Remarks  
 The template function returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> only if, for some <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the range  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the predicate <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is true.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [none_of](../vs140/none_of.md)   
 [all_of](../vs140/all_of.md)   
 [Standard Template Library](../vs140/standard-template-library.md)