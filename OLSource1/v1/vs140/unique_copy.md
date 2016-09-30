---
title: "unique_copy"
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
  - "unique_copy"
  - "std::unique_copy"
  - "std.unique_copy"
  - "algorithm/std::unique_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique_copy function"
  - "unique_copy"
ms.assetid: cdbc77b9-81d8-4453-88f5-e701b6dae02d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_copy
Copies elements from a source range into a destination range except for the duplicate elements that are adjacent to each other.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the source range to be copied.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the source range to be copied.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range that is receiving the copy with consecutive duplicates removed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the copy with consecutive duplicates removed.  
  
## Remarks  
 Both forms of the algorithm remove the second duplicate of a consecutive pair of equal elements.  
  
 The operation of the algorithm is stable so that the relative order of the undeleted elements is not changed.  
  
 The ranges referenced must be valid; all pointers must be dereferenceable and within a sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear, requiring (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) comparisons.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_unique_copy](assetId:///e2fa08a7-9eff-4f3f-ba42-7bdff0a57b76)  
  
-   [unchecked_unique_copy](assetId:///408c5952-abc0-4374-8145-5d9c720bcc43)  
  
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