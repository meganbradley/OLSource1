---
title: "tile_static Keyword"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "tile_static_CPP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tile_static keyword"
ms.assetid: d78384d4-65d9-45cf-b3df-7e904f489d06
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tile_static Keyword
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword is used to declare a variable that can be accessed by all threads in a tile of threads. The lifetime of the variable starts when execution reaches the point of declaration and ends when the kernel function returns. For more information on using tiles, see [Using Tiles](../vs140/using-tiles.md).  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword has the following limitations:  
  
-   It can be used only on variables that are in a function that has the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier.  
  
-   It cannot be used on variables that are pointer or reference types.  
  
-   A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable cannot have an initializer. Default constructors and destructors are not invoked automatically.  
  
-   The value of an uninitialized <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable is undefined.  
  
-   If a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable is declared in a call graph that is rooted by a non-tiled call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, a warning is generated and the behavior of the variable is undefined.  
  
## Example  
 The following example shows how a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable can be used to accumulate data across several threads in a tile.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md)   
 [Overview of C++ Accelerated Massive Parallelism (C++ AMP)](../vs140/c---amp-overview.md)   
 [parallel_for_each Function](../vs140/parallel_for_each-function--c---amp-.md)   
 [Walkthrough: Matrix Multiplication](../vs140/walkthrough--matrix-multiplication.md)