---
title: "Compiler Error CS1540"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1540"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1540"
ms.assetid: f35bbeb9-e2b2-4644-a7e6-cc2dbce1bd44
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1540
Cannot access protected member 'member' via a qualifier of type 'type1'; the qualifier must be of type 'type2' (or derived from it)  
  
 A derived [class](../vs140/class--csharp-reference-.md) cannot access protected members of its base class through an instance of the base class. An instance of the base class declared in the derived class might, at run time, be an instance of another type that is derived from the same base but is not otherwise related to the derived class. Because protected members can be accessed only by derived types, any attempts to access protected members that might not be valid at run time are marked by the compiler as not valid.  
  
 In the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class in the following example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> both have type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> at compile time, but <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> at run time. Because <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, it cannot access the protected members of the base class, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, through an instance of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class. The compiler cannot determine what the run-time type of the two <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects will be. Therefore, both the call from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and the call from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> cause compiler error CS1540.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Inheritance (C# Programming Guide)](../vs140/inheritance--csharp-programming-guide-.md)   
 [Polymorphism (C# Programming Guide)](../vs140/polymorphism--csharp-programming-guide-.md)   
 [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [Abstract and Sealed Classes and Class Members (C# Programming Guide)](../vs140/abstract-and-sealed-classes-and-class-members--csharp-programming-guide-.md)