---
title: "stable_partition"
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
  - "std.stable_partition"
  - "std::stable_partition"
  - "stable_partition"
  - "algorithm/std::stable_partition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stable_partition function"
  - "stable_partition"
ms.assetid: 224e97bf-b752-4c10-aa8c-95031dd535de
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# stable_partition
Classifies elements in a range into two disjoint sets, with those elements satisfying a unary predicate preceding those that fail to satisfy it, preserving the relative order of equivalent elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position one past the final element in the range to be partitioned.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be classified. A predicate takes single argument and returns **true** or **false**.  
  
## Return Value  
 A bidirectional iterator addressing the position of the first element in the range to not satisfy the predicate condition.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 Elements *a* and *b* are equivalent, but not necessarily equal, if both *Pr* (*a*, *b*) is false and *Pr* (*b*, *a*) if false, where *Pr* is the parameter-specified predicate. The **stable_ partition** algorithm is stable and guarantees that the relative ordering of equivalent elements will be preserved. The algorithm **partition** does not necessarily preserve this original ordering.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)