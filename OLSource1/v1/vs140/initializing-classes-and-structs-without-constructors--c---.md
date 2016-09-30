---
title: "Initializing classes and structs without constructors (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 3e55c3d6-1c6b-4084-b9e5-221b151402f4
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializing classes and structs without constructors (C++)
It is not always necessary to define a constructor for a class, especially ones that are relatively simple. Users can initialize objects of a class or struct by using uniform initialization, as shown in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that when a class or struct has no constructor, you provide the list elements in the order that the members are declared in the class. If the class has a constructor, provide the elements in the order of the parameters.  
  
## See Also  
 [Classes and Structs](../vs140/classes-and-structs--c---.md)   
 [Constructors (C++)](../vs140/constructors--c---.md)