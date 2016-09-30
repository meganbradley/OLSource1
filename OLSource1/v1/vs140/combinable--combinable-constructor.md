---
title: "combinable::combinable Constructor"
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
  - "ppl/concurrency::combinable::combinable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "combinable, constructor"
ms.assetid: c24b9603-90ea-4cb2-8cb8-13d5b9c17887
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# combinable::combinable Constructor
Constructs a new <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the initialization functor object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A function which will be called to initialize each new thread-private value of the type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. It must support a function call operator with the signature <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object to be copied into this one.  
  
## Remarks  
 The first constructor initializes new elements with the default constructor for the type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The second constructor initializes new elements using the initialization functor supplied as the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.  
  
 The third constructor is the copy constructor.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [combinable Class](../vs140/combinable-class.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)