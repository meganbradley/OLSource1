---
title: "fill_n"
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
  - "std::fill_n"
  - "fill_n"
  - "xutility/std::fill_n"
  - "std.fill_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fill_n"
  - "fill_n function"
ms.assetid: ebcda70f-d82c-4f43-b4c8-c7e7cbbccb69
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fill_n
Assigns a new value to a specified number of elements in a range beginning with a particular element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the range to be assigned the value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A signed or unsigned integer type specifying the number of elements to be assigned the value.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The value to be assigned to elements in the range [<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, *First + Count*).  
  
## Return Value  
 An iterator to the element that follows the last element filled if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> > zero, otherwise the first element.  
  
## Remarks  
 The destination range must be valid; all pointers must be dereferenceable, and the last position is reachable from the first by incrementation. The complexity is linear with the size of the range.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has two related forms:  
  
-   [checked_fill_n](assetId:///2870ee35-44f5-499a-b27b-e127199405cd)  
  
-   [unchecked_fill_n](assetId:///8cb92524-9e3a-4207-b405-6db10e3f35d0)  
  
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