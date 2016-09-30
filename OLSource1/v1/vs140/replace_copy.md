---
title: "replace_copy"
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
  - "std::replace_copy"
  - "algorithm/std::replace_copy"
  - "replace_copy"
  - "std.replace_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_copy"
  - "replace_copy function"
ms.assetid: 2493e702-894c-4798-87a1-0138cc348e6f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_copy
Examines each element in a source range and replaces it if it matches a specified value while copying the result into a new destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator pointing to the position of the first element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator pointing to the position one past the final element in the range from which elements are being replaced.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator pointing to the first element in the destination range to where the altered sequence of elements is being copied.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The old value of the elements being replaced.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The new value being assigned to the elements with the old value.  
  
## Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
## Remarks  
 The source and destination ranges referenced must not overlap and must both be valid: all pointers must be dereferenceable and within the sequences the last position is reachable from the first by incrementation.  
  
 The order of the elements not replaced remains stable.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear: there are (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) comparisons for equality and at most (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) assignments of new values.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_replace_copy](assetId:///303b3494-5409-4d68-80ad-8224da992f73)  
  
-   [unchecked_replace_copy](assetId:///67d61275-b132-4d32-bdc7-a2b8eb5aa48f)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [replace_copy](../vs140/replace_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)