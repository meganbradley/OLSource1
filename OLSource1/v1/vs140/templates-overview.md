---
title: "Templates Overview"
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
  - "templates, about templates"
  - "types [C++], parameterized"
  - "parameterized types"
  - "Visual C++, templates"
ms.assetid: a8a5779b-ba5c-42ed-bec3-0e4a672128f5
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Templates Overview
Templates, which are sometimes called parameterized types, are mechanisms for generating functions and classes based on type parameters. By using templates, you can design a single class or function that operates on data of many types, instead of having to create a separate class for each type.  
  
## Remarks  
 For example, to create a typesafe function that returns the minimum of two parameters without using templates, you would write a set of overloaded functions like this:  
  
```  
// what_are_templates1.cpp  
// compile with: /c  
// min for ints  
int min( int a, int b ) {  
   return ( a < b ) ? a : b;  
}  
  
// min for longs  
long min( long a, long b ) {  
   return ( a < b ) ? a : b;  
}  
  
// min for chars  
char min( char a, char b ) {  
   return ( a < b ) ? a : b;  
}  
```  
  
 By using templates, you can reduce this duplication to a single function template that will work for any built-in type or any class that overloads the < operator:  
  
```  
// what_are_templates2.cpp  
// compile with: /c  
template <class T> T min( T a, T b ) {  
   return ( a < b ) ? a : b;  
}  
```  
  
 Templates can significantly reduce source code size and increase code flexibility without reducing type safety.  
  
 There are two main types of templates: function templates and class templates. In the previous example, `min` is a function template. A class template is a class with a parameter, such as:  
  
```  
// what_are_templates3.cpp  
template <class T> class A {  
   T m_t;  
   public:  
      A(T t): m_t(t) {}   
      void f(T t);  
};  
  
int main() {  
   A<int> a(10);  
}  
```  
  
 Templates are declared and defined somewhat like ordinary classes or functions except that you precede the class declaration with a template declaration. Inside the definition, you use the template parameter(s) wherever a concrete type will be substuted when a user instantiates the tempalte. with some major differences. A template declaration does not fully define a function or class; it only defines a syntactical skeleton for a class or function. An actual class or function is created from a template by a process called instantiation. The individual classes or functions created are referred to as instantiated. For example, a class template:  
  
```  
template <class T> struct A { . . . };  
```  
  
 can be used to instantiate classes for `A<int>`, `A<char>`, `A<int*>`, `A<MyClass*>`, and so on.  
  
 Instantiation of classes or functions can be done explicitly or implicitly. Explicit instantiation is a way of calling out in code what versions of the template are to be generated. Implicit instantiation allows templates to be instantiated as needed at the point where they are first used.  
  
 Templates can also be parameterized by a value parameter, in which case the template parameter is declared like the parameter to a function. A value parameter can be any integral type including constants in a named or unnamed enum. Floating-point types and class types are not allowed as value parameters.  
  
```  
// what_are_templates4.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
template <int i> class A {  
   int array[i];  
public:  
   A() { memset(array, 0, i*sizeof(int)); }  
};  
  
int main() {  
   A<10> a;  
}  
```  
  
 A common problem with templates is that they can be a one-size-fits-all solution, meaning that the same code applies to all types. If you need to customize the behavior of the template for a particular type, then you can use specialization. Using explicit specialization, a template can be specialized for a particular real type, not a generic type. A class template can also be partially specialized, which is useful if you have a template with multiple type parameters and you only want to customize the behavior with respect to some but not all parameters. A partial specialization is still generic and needs real template arguments to produce an actual instantiated class.  
  
## See Also  
 [Templates](../vs140/templates--c---.md)