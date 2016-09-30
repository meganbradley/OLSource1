---
title: "find_if"
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
  - "std::find_if"
  - "algorithm/std::find_if"
  - "std.find_if"
  - "find_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find_if function"
  - "find_if"
ms.assetid: aa8ff698-e47e-4ff8-8c88-cbda4b102a4a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# find_if
Locates the position of the first occurrence of an element in a range that satisfies a specified condition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 User-defined predicate function object or [lambda expression](../vs140/lambda-expressions-in-c--.md) that defines the condition to be satisfied by the element being searched for. A predicate takes single argument and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (satisfied) or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (not satisfied). The signature of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must effectively be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a type to which <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be implicitly converted when dereferenced. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword is shown only to illustrate that the function object or lambda should not modify the argument.  
  
## Return Value  
 An input iterator that refers to the first element in the range that satisfies the condition specified by the predicate (the predicate results in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>). If no element is found to satisfy the predicate, returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 This template function is a generalization of the algorithm [find](../vs140/find--stl-.md), replacing the predicate "equals a specific value" with any predicate. For the logical opposite (find the first element that does not satisfy the predicate), see [find_if_not](../vs140/find_if_not.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **array x[] contents: (1) (2) (3) (4) (5) (6) (7) (8) (9) (10)Test std::find() with array...value 10 found.value 42 not found.Test std::find_if() with array...first odd integer found: 1first even integer found: 2vector v contents: (10) (20) (30) (40) (50) (60) (70) (80) (90) (100)Test std::find() with vector...value 20 found.value 12 not found.Test std::find_if() with vector...odd integer not found.first even integer found: 10**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [adjacent_find](../vs140/adjacent_find.md)   
 [find](../vs140/find--stl-.md)   
 [find_if_not](../vs140/find_if_not.md)   
 [find_end](../vs140/find_end.md)   
 [mismatch](../vs140/mismatch.md)   
 [search](../vs140/search.md)