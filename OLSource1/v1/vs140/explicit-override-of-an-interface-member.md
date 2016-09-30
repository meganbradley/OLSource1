---
title: "Explicit Override of an Interface Member"
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
  - "virtual functions, explicit overrides"
  - "overriding functions"
  - "interface members, explicit overrides"
  - "functions [C++], overriding"
  - "explicit override of virtual function"
ms.assetid: 46f1f536-bf43-4311-9a17-ff2282e528a9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Override of an Interface Member
The syntax for declaring an explicit override of an interface member within a class has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 You often want to provide two instances of an interface member within a class that implements the interface – one that is used when class objects are manipulated through an interface handle, and one that is used when class objects are used through the class interface. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In Managed Extensions we do this by providing an explicit declaration of the interface method with the method's name qualified with the name of the interface. The class-specific instance is unqualified. This eliminates the need to downcast the return value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, in this example, when explicit called through an instance of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 In the new syntax, a general overriding mechanism has been introduced that replaces the Managed Extensions syntax. Our example would be rewritten as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This revision requires that the interface member being explicitly overridden be given a unique name within the class. Here, I've provided the awkward name of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The behavior is still the same – an invocation through the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface invokes the renamed <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> while a call through an object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> invokes the second <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> instance.  
  
## See Also  
 [Member Declarations within a Class or Interface](../vs140/member-declarations-within-a-class-or-interface--c---cli-.md)   
 [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md)