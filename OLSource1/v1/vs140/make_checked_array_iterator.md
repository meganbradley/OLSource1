---
title: "make_checked_array_iterator"
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
  - "make_checked_array_iterator"
  - "stdext::make_checked_array_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_checked_array_iterator"
  - "make_checked_array_iterator function"
ms.assetid: aa9e15b0-c090-49b0-b552-8afa434cf9d8
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# make_checked_array_iterator
Creates a [checked_array_iterator](../vs140/checked_array_iterator-class.md) that can be used by other algorithms.  
  
> [!NOTE]
>  This function is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the destination array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of the destination array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional index into the array.  
  
## Return Value  
 An instance of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function is defined in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> namespace.  
  
 This function takes a raw pointer—which would ordinarily cause concern about bounds overrun—and wraps it in a [checked_array_iterator](../vs140/checked_array_iterator-class.md) class that does checking. Because that class is marked as checked, the STL doesn't warn about it. For more information and code examples, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
 In the following example, a [vector](../vs140/vector-class.md) is created and populated with 10 items. The contents of the vector are copied into an array by using the copy algorithm, and then <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used to specify the destination. This is followed by an intentional violation of the bounds checking so that a debug assertion failure is triggered.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** stdext  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)