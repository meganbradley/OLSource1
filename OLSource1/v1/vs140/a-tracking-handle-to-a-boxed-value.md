---
title: "A Tracking Handle to a Boxed Value"
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
  - "boxed value types, tracking handle to"
ms.assetid: 16c92048-5b74-47d5-8eca-dfea3d38879a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A Tracking Handle to a Boxed Value
The usage of a tracking handle to reference a value type has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 Boxing is a peculiarity of the CLR unified type system. Value types directly contain their state, while reference types are an implicit pair: the named entity is a handle to an unnamed object allocated on the managed heap. Any initialization or assignment of a value type to an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, for example, requires that the value type be placed within the CLR heap – this is where the image of boxing it arises – first by allocating the associated memory, then by copying the value type’s state, and then returning the address of this anonymous Value/Reference hybrid. Thus, when one writes in C#  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 there is a great deal more going on than is made apparent by the simplicity of the code. The design of C# hides the complexity not only of what operations are taking place under the hood, but also of the abstraction of boxing itself. Managed Extensions for C++, on the other hand, concerned that this would lead to a false sense of efficiency, puts it in the user’s face by requiring an explicit instruction:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Boxing is implicit in [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)]:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword serves a vital service within Managed Extensions, one that is absent by design from languages such as C# and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]: it provides both a vocabulary and tracking handle for directly manipulating a boxed instance on the managed heap. For example, consider the following small program:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The underlying code generated for the three invocations of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> show the various costs of accessing the value of a boxed value type (thanks to Yves Dolce for pointing out these differences), where the indicated lines show the overhead associated with each invocation.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Passing the boxed value type directly to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> eliminates both the boxing and the need to invoke <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. (Of course, there is the earlier boxing to initialize <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, so we don’t gain anything unless we really put <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to work.  
  
 In the new syntax, the support for boxed value types is considerably more elegant and integrated within the type system while retaining its power. For example, here is the translation of the earlier small program:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Value Types and Their Behaviors](../vs140/value-types-and-their-behaviors--c---cli-.md)   
 [How to: Explicitly Request Boxing](../vs140/how-to--explicitly-request-boxing.md)