---
title: "remove_copy"
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
  - "std::remove_copy"
  - "remove_copy"
  - "std.remove_copy"
  - "algorithm/std::remove_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_copy function"
  - "remove_copy"
ms.assetid: 04a5af2c-4d15-483e-9ee0-39812fb344c4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# remove_copy
Copies elements from a source range to a destination range, except that elements of a specified value are not copied, without disturbing the order of the remaining elements and returning the end of a new destination range.  
  
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
 The value that is to be removed from the range.  
  
## Return Value  
 A forward iterator addressing the new end position of the destination range, one past the final element of the copy of the remnant sequence free of the specified value.  
  
## Remarks  
 The source and destination ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 There must be enough space in the destination range to contain the remnant elements that will be copied after elements of the specified value are removed.  
  
 The order of the elements not removed remains stable.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> used to determine the equality between elements must impose an equivalence relation between its operands.  
  
 The complexity is linear; there are (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) comparisons for equality and at most (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) assignments.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_remove_copy](assetId:///1379d7c3-cad6-4599-b642-2d6102d739b4)  
  
-   [unchecked_remove_copy](assetId:///b4366b16-f494-49cf-b383-a82bbfe9de58)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [remove_copy](../vs140/remove_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)