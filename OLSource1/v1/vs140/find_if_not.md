---
title: "find_if_not"
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
  - "find_if_not"
  - "algorithm/std::find_if_not"
  - "std.find_if_not"
  - "std::find_if_not"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_if_not"
  - "find_if_not function"
ms.assetid: 50d719ac-d395-4fad-a8cd-05beb844ee0f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# find_if_not
Returns the first element in the indicated range that does not satisfy a condition.  
  
## Syntax  
  
```  
template<class InputIterator, class Predicate>  
InputIterator find_if_not(InputIterator first, InputIterator last,   
      Predicate pred);  
```  
  
#### Parameters  
 `first`  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 `last`  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 `pred`  
 User-defined predicate function object or [lambda expression](../vs140/lambda-expressions-in-c--.md) that defines the condition to be not satisfied by the element being searched for. A predicate takes single argument and returns `true` (satisfied) or `false` (not satisfied). The signature of `pred` must effectively be `bool pred(const T& arg);`, where `T` is a type to which `InputIterator` can be implicitly converted when dereferenced. The `const` keyword is shown only to illustrate that the function object or lambda should not modify the argument.  
  
## Return Value  
 An input iterator that refers to the first element in the range that does not satisfy the condition specified by the predicate (the predicate results in `false`). If all elements satisfy the predicate (the predicate results in `true` for every element), returns `last`.  
  
## Remarks  
 This template function is a generalization of the algorithm [find](../vs140/find--stl-.md), replacing the predicate "equals a specific value" with any predicate. For the logical opposite (find the first element that does satisfy the predicate), see [find_if](../vs140/find_if.md).  
  
 For a code example readily adaptable to `find_if_not()`, see [find_if()](../vs140/find_if.md).  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [adjacent_find](../vs140/adjacent_find.md)   
 [find](../vs140/find--stl-.md)   
 [find_if](../vs140/find_if.md)   
 [find_end](../vs140/find_end.md)   
 [mismatch](../vs140/mismatch.md)   
 [search](../vs140/search.md)