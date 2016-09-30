---
title: "Debug Iterator Support"
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
  - "_HAS_ITERATOR_DEBUGGING symbol"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Safe Libraries"
  - "Safe Libraries, Standard C++ Library"
  - "Safe Standard C++ Library"
  - "Standard C++ Library, debug iterator support"
  - "iterators, debug iterator support"
  - "iterators, incompatible"
  - "incompatible iterators"
  - "debug iterator support"
ms.assetid: f3f5bd15-4be8-4d64-a4d0-8bc0761c68b6
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debug Iterator Support
The Visual C++ run-time library detects incorrect iterator use, and asserts and displays a dialog box at run time. To enable debug iterator support, you must use a debug version of a C run-time library to compile your program. For more information, see [C Run-Time Libraries](../vs140/crt-library-features.md). For information about how to use iterators, see [Checked Iterators](../vs140/checked-iterators.md).  
  
 The C++ standard describes how member functions might cause iterators to a container to become invalid. Two examples are:  
  
-   Erasing an element from a container causes iterators to the element to become invalid.  
  
-   Increasing the size of a [vector](../vs140/-vector-.md) (push or insert) causes iterators into the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to become invalid.  
  
## Example  
 If you compile the following program in debug mode, at run time it will assert and terminate.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 You can use the symbol [_HAS_ITERATOR_DEBUGGING](../vs140/_has_iterator_debugging.md) to turn off the iterator debugging feature in a debug build. The following program does not assert, but still triggers undefined behavior.  
  
> [!IMPORTANT]
>  Use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to control <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For more information, see [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **20**  
**-572662307**   
## Example  
 An assert also occurs if you attempt to use an iterator before it is initialized, as shown here:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following code example causes an assertion because the two iterators to the [for_each](../vs140/for_each.md) algorithm are incompatible. Algorithms check to determine whether the iterators that are supplied to them are referencing the same container.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Notice that this example uses the lambda expression <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instead of a functor. Although this choice has no bearing on the assert failure—a similar functor would cause the same failure—lambdas are a very useful way to accomplish compact function object tasks. For more information about lambda expressions, see [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md).  
  
## Example  
 Debug iterator checking also causes an iterator variable that's declared in a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> loop to be out of scope when the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> loop scope ends.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 Debug iterators have non-trivial destructors. If a destructor does not run, for whatever reason, access violations and data corruption might occur. Consider this example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [STL Overview](../vs140/c---standard-library-overview.md)