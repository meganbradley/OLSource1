---
title: "Implicit Boxing of Value Types"
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
  - "boxing, Visual C++"
  - "__box keyword"
  - "boxing"
  - "boxing, __box keyword"
  - "value types, boxed"
ms.assetid: 9597c92f-a3fe-44af-ad80-f9d656847a35
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implicit Boxing of Value Types
The boxing of value types has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 In language design, we imposed a philosophical position in lieu of practical experience with the feature and, in practice, it was a mistake. As an analogy, in the original multiple inheritance language design, Stroustrup decided that a virtual base class sub-object could not be initialized within a derived class constructor, and therefore the language required that any class serving as a virtual base class must define a default constructor. It is that default constructor that would be invoked by any subsequent virtual derivation.  
  
 The problem of a virtual base class hierarchy is that responsibility for the initialization of the shared virtual sub-object shifts with each subsequent derivation. For example, if I define a base class for which initialization requires the allocation of a buffer, the user-specified size of that buffer might be passed as an argument to the constructor. If I then provide two subsequent virtual derivations, call them <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, each provides a particular value to the base class constructor. Now, when I derived an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class from both <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, neither of those values to the shared virtual base class sub-object can sensibly be allowed to evaluate.  
  
 Therefore, in the original language design, Stroustrup disallowed the explicit initialization of a virtual base class within the member initialization list of the derived class constructor. While this solved the problem, in practice the inability to direct the initialization of the virtual base class proved impracticable. Keith Gorlen of the National Institute of Health, who had implemented a freeware version of the SmallTalk collection library called nihcl, was a principle voice in convincing Stroustrup that he had to come up with a more flexible language design.  
  
 A principle of Object-Oriented hierarchical design holds that a derived class should concern itself only with the non-private implementation of its immediate base classes. In order to support a flexible initialization design for virtual inheritance, Stroustrup had to violate this principle. The most derived class in a hierarchy assumes responsibility for all virtual sub-object initialization regardless of how deep into the hierarchy it occurs. For example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are both responsible for explicitly initializing their immediate virtual base class. When <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> derives from both <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> becomes responsible for the initialization of the once removed virtual base class, and the initialization made explicit within <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is suppressed.  
  
 This provides the flexibility required by language developers, but at the cost of a complicated semantics. This burden of complication is stripped away if we restrict a virtual base class to be without state and simply allow it to specify an interface. This is a recommended design idiom within C++. Within CLR programming, it is raised to policy with the Interface type.  
  
 Here is a simple code sample– and in this case, the explicit boxing is unnecessary:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 As you can see, there is a whole lot of boxing going on. Under [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)], value type boxing is implicit:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Value Types and Their Behaviors](../vs140/value-types-and-their-behaviors--c---cli-.md)   
 [Implicit Boxing](../vs140/boxing---c---component-extensions-.md)