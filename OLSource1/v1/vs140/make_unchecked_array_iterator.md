---
title: "make_unchecked_array_iterator"
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
  - "make_unchecked_array_iterator"
  - "stdext::make_unchecked_array_iterator"
dev_langs: 
  - "C++"
ms.assetid: 10422011-d246-466f-bb5d-1729497ec47e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_unchecked_array_iterator
Creates an [unchecked_array_iterator](../vs140/unchecked_array_iterator-class.md) that can be used by other algorithms.  
  
> [!NOTE]
>  This function is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the destination array.  
  
## Return Value  
 An instance of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function is defined in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> namespace.  
  
 This function takes a raw pointer and wraps it in a class that performs no checking and therefore optimizes away to nothing, but it also silences compiler warnings such as [C4996](../vs140/compiler-warning--level-3--c4996.md). Therefore, this is a targeted way to deal with unchecked-pointer warnings without globally silencing them or incurring the cost of checking. For more information and code examples, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
 In the following example, a [vector](../vs140/vector-class.md) is created and populated with 10 items. The contents of the vector are copied into an array by using the copy algorithm, and then <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is used to specify the destination.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** stdext  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)