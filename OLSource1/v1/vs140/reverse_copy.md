---
title: "reverse_copy"
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
  - "algorithm/std::reverse_copy"
  - "std::reverse_copy"
  - "reverse_copy"
  - "std.reverse_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_copy function"
  - "reverse_copy"
ms.assetid: 84567cb2-dc19-43a0-831f-6a03a85acb66
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_copy
Reverses the order of the elements within a source range while copying them into a destination range  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position of the first element in the source range within which the elements are being permuted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bidirectional iterator pointing to the position one past the final element in the source range within which the elements are being permuted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator pointing to the position of the first element in the destination range to which elements are being copied.  
  
## Return Value  
 An output iterator pointing to the position one past the final element in the destination range to where the altered sequence of elements is being copied.  
  
## Remarks  
 The source and destination ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_reverse_copy](assetId:///85080fe0-cccb-446b-92c2-0079a3521196)  
  
-   [unchecked_reverse_copy](assetId:///08096345-e103-4af3-b278-ba47f07f8d34)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_copy](../vs140/reverse_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)