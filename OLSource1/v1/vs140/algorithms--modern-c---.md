---
title: "Algorithms (Modern C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 6f758d3c-a7c7-4a50-92bb-97b2f6d4ab27
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Algorithms (Modern C++)
For modern C++ programming, we recommend that you use the algorithms in the [Standard Template Library](../vs140/c---standard-library-reference.md) (STL). Here are some important examples:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is the default traversal algorithm. (Also <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for not-in-place semantics.)  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which is the default search algorithm.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and the other default sorting and searching algorithms.  
  
 To write a comparator, use strict <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and use  *named lambdas* when you can.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Loops  
 When possible, use range-based <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> loops or algorithm calls, or both, instead of hand-written loops.<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and others like them are much better than handwritten loops because their intent is obvious and they make it easier to write bug-free code. Also, many STL algorithms have implementation optimizations that make them more efficient.  
  
 Instead of old C++ like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Use modern C++ like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Range-based for loops  
 The range-based <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> loop is a C++11 language feature, not an STL algorithm. But it deserves mention in this discussion about loops. Range-based <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> loops are an extension of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword and provide a convenient and efficient way to write loops that iterate over a range of values. STL containers, strings, and arrays are ready-made for range-based <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> loops. To enable this new iteration syntax for your user-defined type, add the following support:  
  
-   A <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method that returns an iterator to the beginning of the structure and an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method that returns an iterator to the end of the structure.  
  
-   Support in the iterator for these methods: <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (prefix version).  
  
 These methods can be either members or stand-alone functions.  
  
## Random Numbers  
 It's no secret that the old CRT <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function has many flaws, which have been discussed at length in the C++ community. In modern C++, you don't have to deal with those shortcomings—nor do you have to invent your own uniformly distributed random number generator—because the tools for quickly and easily creating them are available in the STL, as shown in [\<random>](../vs140/-random-.md).  
  
## See Also  
 [Welcome Back to C++](../vs140/welcome-back-to-c----modern-c---.md)   
 [C++ Language Reference](../vs140/c---language-reference.md)   
 [Standard C++ Library](../vs140/c---standard-library-reference.md)