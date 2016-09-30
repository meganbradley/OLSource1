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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 User-defined predicate function object or [lambda expression](../vs140/lambda-expressions-in-c--.md) that defines the condition to be not satisfied by the element being searched for. A predicate takes single argument and returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (satisfied) or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (not satisfied). The signature of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must effectively be <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a type to which <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can be implicitly converted when dereferenced. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword is shown only to illustrate that the function object or lambda should not modify the argument.  
  
## Return Value  
 An input iterator that refers to the first element in the range that does not satisfy the condition specified by the predicate (the predicate results in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>). If all elements satisfy the predicate (the predicate results in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for every element), returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 This template function is a generalization of the algorithm [find](../vs140/find--stl-.md), replacing the predicate "equals a specific value" with any predicate. For the logical opposite (find the first element that does satisfy the predicate), see [find_if](../vs140/find_if.md).  
  
 For a code example readily adaptable to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [find_if()](../vs140/find_if.md).  
  
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