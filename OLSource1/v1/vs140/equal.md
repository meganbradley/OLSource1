---
title: "equal"
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
  - "istreambuf_iterator.equal"
  - "std.istreambuf_iterator.equal"
  - "equal"
  - "xutility/std::equal"
  - "std::equal"
  - "streambuf/std::istreambuf_iterator::equal"
  - "istreambuf_iterator::equal"
  - "std::istreambuf_iterator::equal"
  - "std.equal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal"
  - "equal method"
  - "equal function"
ms.assetid: 56533afd-b696-40a0-8fa9-d366539e49ae
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# equal
Compares two ranges element by element for equality or equivalence in a sense specified by a binary predicate.  
  
 Use std::equal when comparing elements in different container types (for example vector and list) or when comparing different element types, or when you need to compare sub-ranges of containers. Otherwise, when comparing elements of the same type in the same container type, use the non-member operator== that is provided for each container.  
  
 Use the dual-range overloads in C++14 code because the overloads that only take a single iterator for the second range will not detect differences if the second range is longer than the first range, and will result in undefined behavior if the second range is shorter than the first range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first range to be tested.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first range to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second range to be tested.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator addressing the position of one past the last element in the second range to be tested.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 **true** if and only if the ranges are identical or equivalent under the binary predicate when compared element by element; otherwise, **false**.  
  
## Remarks  
 The range to be searched must be valid; all iterators must be dereferenceable and the last position is reachable from the first by incrementation.  
  
 If the two ranges are equal length, then the time complexity of the algorithm is linear in the number of elements contained in the range. Otherwise the function immediately returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Neither the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> nor the user-defined predicate is required to impose an equivalence relation that symmetric, reflexive and transitive between its operands.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)