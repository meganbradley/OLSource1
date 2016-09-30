---
title: "copy"
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
  - "xutility/std::copy"
  - "std::_Char_traits::copy"
  - "_Char_traits.copy"
  - "std::copy"
  - "iosfwd/std::char_traits::copy"
  - "std::basic_string::copy"
  - "iosfwd/std::_Char_traits::copy"
  - "std.copy"
  - "basic_string::copy"
  - "std._Char_traits.copy"
  - "xstring/std::basic_string::copy"
  - "std.basic_string.copy"
  - "_Char_traits::copy"
  - "std::char_traits::copy"
  - "basic_string.copy"
  - "char_traits::copy"
  - "std.char_traits.copy"
  - "char_traits.copy"
  - "copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy"
  - "copy function"
  - "copy method"
ms.assetid: f1fec7da-e01b-40f1-b5bd-6b81e304cae1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy
Assigns the values of elements from a source range to a destination range, iterating through the source sequence of elements and assigning them new positions in a forward direction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the source range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the position that is one past the final element in the source range.  
  
 *_DestBeg*  
 An output iterator addressing the position of the first element in the destination range.  
  
## Return Value  
 An output iterator addressing the position that is one past the final element in the destination range, that is, the iterator addresses <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> + (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> ).  
  
## Remarks  
 The source range must be valid and there must be sufficient space at the destination to hold all the elements being copied.  
  
 Because the algorithm copies the source elements in order beginning with the first element, the destination range can overlap with the source range provided the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> position of the source range is not contained in the destination range. **copy** can be used to shift elements to the left but not the right, unless there is no overlap between the source and destination ranges. To shift to the right any number of positions, use the [copy_backward](../vs140/copy_backward.md) algorithm.  
  
 The **copy** algorithm only modifies values pointed to by the iterators, assigning new values to elements in the destination range. It cannot be used to create new elements and cannot insert elements into an empty container directly.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_copy](assetId:///37481d6e-dcfe-4c27-b8f6-e9040e431d5f)  
  
-   [unchecked_copy](assetId:///0ac4f6f5-5d84-4244-88a3-691d18c1ff7f)  
  
 For information on how these functions behave, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For another sample showing how to use copy, see [accumulate, copy, and vector::push_back](../vs140/accumulate--copy--and-vector--push_back.md).  
  
 **v1 = ( 0 10 20 30 40 50 )**  
**v2 = ( 0 3 6 9 12 15 18 21 24 27 30 )**  
**v2 with v1 insert = ( 0 3 6 9 0 10 20 21 24 27 30 )**  
**v2 with shifted insert = ( 0 3 0 10 20 10 20 21 24 27 30 )**   
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)