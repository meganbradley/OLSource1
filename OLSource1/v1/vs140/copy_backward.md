---
title: "copy_backward"
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
  - "std::copy_backward"
  - "xutility/std::copy_backward"
  - "std.copy_backward"
  - "copy_backward"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_backward"
  - "copy_backward function"
ms.assetid: ddfab855-25a3-44db-a3cd-2b05ae97ea20
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_backward
Assigns the values of elements from a source range to a destination range, iterating through the source sequence of elements and assigning them new positions in a backward direction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of the first element in the source range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position that is one past the final element in the source range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A bidirectional iterator addressing the position of one past the final element in the destination range.  
  
## Return Value  
 An output iterator addressing the position that is one past the final element in the destination range, that is, the iterator addresses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> – (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> ).  
  
## Remarks  
 The source range must be valid and there must be sufficient space at the destination to hold all the elements being copied.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> algorithm imposes more stringent requirements than that the copy algorithm. Both its input and output iterators must be bidirectional.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and [move_backward](../vs140/move_backward.md) algorithms are the only Standard Template Library algorithms designating the output range with an iterator pointing to the end of the destination range.  
  
 Because the algorithm copies the source elements in order beginning with the last element, the destination range can overlap with the source range provided the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> position of the source range is not contained in the destination range. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can be used to shift elements to the right but not the left, unless there is no overlap between the source and destination ranges. To shift to the left any number of positions, use the [copy](../vs140/copy.md) algorithm.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> algorithm only modifies values pointed to by the iterators, assigning new values to elements in the destination range. It cannot be used to create new elements and cannot insert elements into an empty container directly.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [move_backward](../vs140/move_backward.md)   
 [Standard Template Library](../vs140/standard-template-library.md)