---
title: "Changes in Constructor Initialization Order"
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
  - "constructors, C++"
ms.assetid: 8892c38d-6bf7-4cf7-ac8f-15e052135a79
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Changes in Constructor Initialization Order
The order of initialization for class constructors has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
## Comparison of Constructor Initialization Order  
 Under Managed Extensions for C++, constructor initialization occurred in the following order:  
  
1.  The constructor of the base class, if any, is invoked.  
  
2.  The initialization list of the class is evaluated.  
  
3.  The code body of the class constructor is executed.  
  
 This order of execution follows the same conventions as in native C++ programming. The new Visual C++ language prescribes the following execution order for CLR classes:  
  
1.  The initialization list of the class is evaluated.  
  
2.  The constructor of the base class, if any, is invoked.  
  
3.  The code body of the class constructor is executed.  
  
 Note this change applies only to CLR classes; native classes in [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)] still follow the previous conventions. In both cases, these rules cascade upward throughout the whole hierarchy chain of a given class.  
  
 Consider the following code example using Managed Extensions for C++:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Following the constructor initialization order prescribed above, we should see the following order of execution when new instances of class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are constructed:  
  
1.  The constructor of the base class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is invoked. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member is initialized to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
2.  The initialization list for class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is evaluated. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member is initialized to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
3.  The code body of class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is executed.  
  
 Now consider the same code in the new Visual C++ syntax:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The order of execution when new instances of class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are constructed under the new syntax is:  
  
1.  The initialization list for class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is evaluated. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member is initialized to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the uninitialized value of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class member).  
  
2.  The constructor of the base class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is invoked. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> member is initialized to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
3.  The code body of class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is executed.  
  
 Note that a similar syntax produces different results for these code examples. The constructor of class <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> depends on a value from base class <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to initialize its member. However, the constructor for class <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> has not yet been invoked. Such a dependency can be especially dangerous when the inherited class depends on a memory or resource allocation to occur in the base class constructor.  
  
## What This Means Going from Managed Extensions for C++ to Visual C++ 2010  
 In many cases the changes to the execution order of class constructors should be transparent to the programmer because base classes have no notion of the behavior of inherited classes. However, as these code examples illustrate, the constructors of inherited classes can be greatly affected when their initialization lists depend on the values of base class members. When you move your code from Managed Extensions for C++ to the new syntax, consider moving such constructs to the body of the class constructor, where execution is guaranteed to occur last.  
  
## See Also  
 [The Managed Types](../vs140/managed-types--c---cl-.md)   
 [Constructors (C++)](../vs140/constructors--c---.md)   
 [Constructor Initializers](../vs140/constructor-initializers.md)