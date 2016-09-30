---
title: "Initializing Arrays"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "initializing arrays"
  - "arrays [C++], initializing"
ms.assetid: 41efe5f0-15b5-4f49-9196-c4902f8fc705
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializing Arrays
If a class has a constructor, arrays of that class are initialized by a constructor. If there are fewer items in the initializer list than elements in the array, the default constructor is used for the remaining elements. If no default constructor is defined for the class, the initializer list must be complete — that is, there must be one initializer for each element in the array.  
  
 Consider the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class that defines two constructors:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The first element of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is constructed using the constructor <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; the remaining two elements are constructed using the default constructor.  
  
 Static member arrays (whether **const** or not) can be initialized in their definitions (outside the class declaration). For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [(NOTINBUILD)Special Member Functions](assetId:///82223d73-64cb-4923-b678-78f9568ff3ca)