---
title: "Virtual Functions"
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
helpviewer_keywords: 
  - "functions [C++], virtual functions"
  - "derived classes, virtual functions"
  - "virtual functions"
ms.assetid: b3e1ed88-2a90-4af8-960a-16f47deb3452
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Virtual Functions
A virtual function is a member function that you expect to be redefined in derived classes. When you refer to a derived class object using a pointer or a reference to the base class, you can call a virtual function for that object and execute the derived class's version of the function.  
  
 Virtual functions ensure that the correct function is called for an object, regardless of the expression used to make the function call.  
  
 Suppose a base class contains a function declared as [virtual](../vs140/virtual--c---.md) and a derived class defines the same function. The function from the derived class is invoked for objects of the derived class, even if it is called using a pointer or reference to the base class. The following example shows a base class that provides an implementation of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function and two derived classes  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding code, the calls to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are identical, except for the object <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> points to. Because <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is virtual, the version of the function defined for each object is called. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function in the derived classes <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> "override" the function in the base class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 If a class is declared that does not provide an overriding implementation of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function, the default implementation from the base class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is used.  
  
 Functions in derived classes override virtual functions in base classes only if their type is the same. A function in a derived class cannot differ from a virtual function in a base class in its return type only; the argument list must differ as well.  
  
 When calling a function using pointers or references, the following rules apply:  
  
-   A call to a virtual function is resolved according to the underlying type of object for which it is called.  
  
-   A call to a nonvirtual function is resolved according to the type of the pointer or reference.  
  
 The following example shows how virtual and nonvirtual functions behave when called through pointers:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Note that regardless of whether the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function is invoked through a pointer to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or a pointer to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, it calls the function for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. It calls the function for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a virtual function, and both <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> point to an object of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 Because virtual functions are called only for objects of class types, you cannot declare global or static functions as **virtual**.  
  
 The **virtual** keyword can be used when declaring overriding functions in a derived class, but it is unnecessary; overrides of virtual functions are always virtual.  
  
 Virtual functions in a base class must be defined unless they are declared using the *pure-specifier*. (For more information about pure virtual functions, see [Abstract Classes](../vs140/abstract-classes--c---.md).)  
  
 The virtual function-call mechanism can be suppressed by explicitly qualifying the function name using the scope-resolution operator (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>). Consider the earlier example involving the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class. To call <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in the base class, use code such as the following:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Both calls to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in the preceding example suppress the virtual function-call mechanism.  
  
## See Also  
 [Access to Virtual Functions](../vs140/access-to-virtual-functions.md)