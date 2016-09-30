---
title: "remove_copy_if"
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
  - "algorithm/std::remove_copy_if"
  - "remove_copy_if"
  - "std.remove_copy_if"
  - "std::remove_copy_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_copy_if function"
  - "remove_copy_if"
ms.assetid: 76b1e0d6-26a8-4adb-a55e-c179fa4e2dac
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# remove_copy_if
Copies elements from a source range to a destination range, except that satisfying a predicate are not copied, without disturbing the order of the remaining elements and returning the end of a new destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the range from which elements are being removed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range to which elements are being removed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
## Return Value  
 A forward iterator addressing the new end position of the destination range, one past the final element of the remnant sequence free of the elements satisfying the predicate.  
  
## Remarks  
 The source range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 There must be enough space in the destination range to contain the remnant elements that will be copied after elements of the specified value are removed.  
  
 The order of the elements not removed remains stable.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) comparisons for equality and at most (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) assignments.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_remove_copy_if](assetId:///ef1b5d4a-61e2-4000-a991-3a8c4512b574)  
  
-   [unchecked_remove_copy_if](assetId:///dd0a223e-572b-4595-aa7f-d8aa6c4558b8)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [remove_copy_if](../vs140/remove_copy_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)