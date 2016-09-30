---
title: "rotate_copy"
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
  - "std.rotate_copy"
  - "algorithm/std::rotate_copy"
  - "std::rotate_copy"
  - "rotate_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rotate_copy function"
  - "rotate_copy"
ms.assetid: 06c5bb1d-3b44-4c06-8f39-e926c0829bae
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rotate_copy
Exchanges the elements in two adjacent ranges within a source range and copies the result to a destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator addressing the position of the first element in the range to be rotated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator defining the boundary within the range that addresses the position of the first element in the second part of the range whose elements are to be exchanged with those in the first part of the range.  
  
 _ <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A forward iterator addressing the position one past the final element in the range to be rotated.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range.  
  
## Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The complexity is linear with at most (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) swaps.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_rotate_copy](assetId:///a0f70a3e-a86d-4edb-90d6-728457fe8759)  
  
-   [unchecked_rotate_copy](assetId:///6556e8d8-f3a9-4931-bbcc-704f0f0a1b34)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [rotate_copy](../vs140/rotate_copy--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)