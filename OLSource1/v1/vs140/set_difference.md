---
title: "set_difference"
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
  - "set_difference"
  - "std::set_difference"
  - "std.set_difference"
  - "algorithm/std::set_difference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_difference function"
  - "set_difference"
ms.assetid: cd96abfe-5028-47de-ae29-cb9aa4a0acf3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_difference
Unites all of the elements that belong to one sorted source range, but not to a second sorted source range, into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first of two sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in the first of two sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the last element in second of two consecutive sorted source ranges to be united and sorted into a single range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range where the two source ranges are to be united into a single sorted range representing the difference of the two source ranges.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the sense in which one element is greater than another. The binary predicate takes two arguments and should return **true** when the first element is less than the second element and **false** otherwise.  
  
## Return Value  
 An output iterator addressing the position one past the last element in the sorted destination range representing the difference of the two source ranges.  
  
## Remarks  
 The sorted source ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The destination range should not overlap either of the source ranges and should be large enough to contain the first source range.  
  
 The sorted source ranges must each be arranged as a precondition to the application of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> algorithm in accordance with the same ordering as is to be used by the algorithm to sort the combined ranges.  
  
 The operation is stable as the relative order of elements within each range is preserved in the destination range. The source ranges are not modified by the algorithm merge.  
  
 The value types of the input iterators need be less-than-comparable to be ordered, so that, given two elements, it may be determined either that they are equivalent (in the sense that neither is less than the other) or that one is less than the other. This results in an ordering between the nonequivalent elements. When there are equivalent elements in both source ranges, the elements in the first range precede the elements from the second source range in the destination range. If the source ranges contain duplicates of an element such that there are more in the first source range than in the second, then the destination range will contain the number by which the occurrences of those elements in the first source range exceed the occurrences of those elements in the second source range.  
  
 The complexity of the algorithm is linear with at most 2 \* ( (*last1 – first1*) – (*last2 – first2*) ) – 1 comparisons for nonempty source ranges.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_set_difference](assetId:///6f5dc1d6-4a1f-4fdb-be14-22cef40eb84d)  
  
-   [unchecked_set_difference](assetId:///6e5abff6-9e79-48ef-9607-7ca2bd2b5434)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)