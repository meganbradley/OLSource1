---
title: "copy_if"
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
  - "algorithm/std::copy_if"
  - "copy_if"
  - "std.copy_if"
  - "std::copy_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_if function"
  - "copy_if"
ms.assetid: 56694c4a-6e99-414e-9748-6992a81c78a6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_if
In a range of elements, copies the elements that are <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for the specified condition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator that indicates the start of a range to check for the condition.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of the range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The output iterator that indicates the destination for the copied elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The condition against which every element in the range is tested. This condition is provided by a user-defined predicate function object. A predicate takes one argument and returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 An output iterator that equals <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> incremented once for each element that fulfills the condition. In other words, the return value minus <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> equals the number of copied elements.  
  
## Remarks  
 The template function evaluates  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 once for each <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> starting with the lowest value. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)