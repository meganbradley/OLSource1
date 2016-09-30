---
title: "Function Objects in the STL"
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
helpviewer_keywords: 
  - "functors"
  - "Standard C++ Library, functors"
  - "Standard C++ Library, function objects"
  - "function objects"
ms.assetid: 85f8a735-2c7b-4f10-9c4d-95c666ec4192
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Objects in the STL
A *function object*, or *functor*, is any type that implements operator(). This operator is referred to as the *call operator* or sometimes the *application operator*. The Standard Template Library uses function objects primarily as sorting criteria for containers and in algorithms.  
  
 Function objects provide two main advantages over a straight function call. The first is that a function object can contain state. The second is that a function object is a type and therefore can be used as a template parameter.  
  
## Creating a Function Object  
 To create a function object, create a type and implement operator(), such as:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The last line of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function shows how you call the function object. This call looks like a call to a function, but it is actually calling operator() of the Functor type. This similarity between calling a function object and a function is how the term function object came about.  
  
## Function Objects and Containers  
 The Standard Template Library contains several function objects in the [\<functional>](../vs140/-functional-.md) header file. One use of these function objects is as a sorting criterion for containers. For example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> container is declared as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The second template argument is the function object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This function object returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the first parameter passed to it is less than the second parameter passed. Since some containers sort their elements, the container needs a way of comparing two elements, and this is accomplished using the function object. You can define your own sorting criteria for containers by creating a function object and specifying it in the template list for the container.  
  
## Function Objects and Algorithms  
 Another use of functional objects is in algorithms. For example, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> algorithm is declared as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The last argument to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a function object that returns a boolean value (a *predicate*). If the result of the function object is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, then the element is removed from the container being accessed by the iterators <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. You can use any of the function objects declared in the [\<functional>](../vs140/-functional-.md) header for the argument <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or you can create your own.  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)