---
title: "replace_copy_if"
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
  - "std::replace_copy_if"
  - "std.replace_copy_if"
  - "replace_copy_if"
  - "algorithm/std::replace_copy_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_copy_if"
  - "replace_copy_if function"
ms.assetid: 3541f157-b8e0-4f83-bfdf-3e786ed26a3b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_copy_if
Examines each element in a source range and replaces it if it satisfies a specified predicate while copying the result into a new destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator pointing to the position of the first element in the destination range to which elements are being copied.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The unary predicate that must be satisfied is the value of an element is to be replaced.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The new value being assigned to the elements whose old value satisfies the predicate.  
  
## Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
## Remarks  
 The source and destination ranges referenced must not overlap and must both be valid: all pointers must be dereferenceable and within the sequences the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) comparisons for equality and at most (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) assignments of new values.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_replace_copy_if](assetId:///f483ca68-2ca7-443b-8920-6a2d01af33e4)  
  
-   [unchecked_replace_copy_if](assetId:///6eb746dd-c2c6-4b22-ae04-c135124665fc)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace_copy_if](../vs140/replace_copy_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)