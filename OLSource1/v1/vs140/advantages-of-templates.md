---
title: "Advantages of Templates"
ms.custom: na
ms.date: "09/21/2016"
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
  - "templates, advantages"
ms.assetid: 7a280702-bf36-4df5-8189-f0d443ba5202
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Advantages of Templates
You can use templates to:  
  
-   Create a typesafe collection class (for example, a stack) that can operate on data of any type.  
  
-   Add extra type checking for functions that would otherwise take `void` pointers.  
  
-   Encapsulate groups of operator overrides to modify type behavior (such as smart pointers).  
  
 Most of these uses can be implemented without templates; however, templates offer several advantages:  
  
-   Templates are easier to write. You create only one generic version of your class or function instead of manually creating specializations.  
  
-   Templates can be easier to understand, since they can provide a straightforward way of abstracting type information.  
  
-   Templates are typesafe. Because the types that templates act upon are known at compile time, the compiler can perform type checking before errors occur.  
  
 For more information, see:  
  
-   [Templates and Macros](#_core_When_Should_You_Use_Templates.3fAnchor1)  
  
-   [Templates and Void Pointers](#_core_When_Should_You_Use_Templates.3fAnchor2)  
  
-   [Templates and Smart Pointers](#_core_When_Should_You_Use_Templates.3fAnchor4)  
  
-   [Templates and Collection Classes](#_core_When_Should_You_Use_Templates.3fAnchor3)  
  
##  <a name="_core_When_Should_You_Use_Templates.3fAnchor1"></a> Templates and Macros  
 In many ways, templates work like preprocessor macros, replacing the templated variable with the given type. However, there are many differences between a macro like this:  
  
```  
#define min(i, j) (((i) < (j)) ? (i) : (j))  
```  
  
 and a template:  
  
```  
template<class T> T min (T i, T j) { return ((i < j) ? i : j) }  
```  
  
 Here are some problems with the macro:  
  
-   There is no way for the compiler to verify that the macro parameters are of compatible types. The macro is expanded without any special type checking.  
  
-   The `i` and `j` parameters are evaluated twice. For example, if either parameter has a postincremented variable, the increment is performed two times.  
  
-   Because macros are expanded by the preprocessor, compiler error messages will refer to the expanded macro, rather than the macro definition itself. Also, the macro will show up in expanded form during debugging.  
  
##  <a name="_core_When_Should_You_Use_Templates.3fAnchor2"></a> Templates and Void Pointers  
 Many functions that are now implemented with void pointers can be implemented with templates. Void pointers are often used to allow functions to operate on data of an unknown type. When using void pointers, the compiler cannot distinguish types, so it cannot perform type checking or type-specific behavior such as using type-specific operators, operator overloading, or constructors and destructors.  
  
 With templates, you can create functions and classes that operate on typed data. The type looks abstracted in the template definition. However, at compile time the compiler creates a separate version of the function for each specified type. This enables the compiler to treat class and function templates as if they acted on specific types. Templates can also improve coding clarity, because you do not need to create special cases for complex types such as structures.  
  
##  <a name="_core_When_Should_You_Use_Templates.3fAnchor4"></a> Templates and Smart Pointers  
 C++ allows you to create smart pointer classes that encapsulate pointers and override pointer operators to add new functionality to pointer operations. Templates allow you to create generic wrappers to encapsulate pointers of almost any type.  
  
 The following code outlines a simple reference count garbage collector. The template class `Ptr<T>` implements a garbage collecting pointer to any class derived from `RefCount`.  
  
## Example  
  
### Code  
  
```  
// templates_and_smart_pointers.cpp  
#include <stdio.h>  
  
#define TRACE printf  
  
class RefCount {  
   int crefs;  
public:  
   RefCount(void) {  
      crefs = 0;  
   }  
  
   ~RefCount() {  
      TRACE("goodbye(%d)\n", crefs);   
   }  
  
   void upcount(void) {  
      ++crefs;   
      TRACE("up to %d\n", crefs);  
   }  
  
   void downcount(void)  
   {  
      if (--crefs == 0)  
         delete this;  
   else  
      TRACE("downto %d\n", crefs);  
   }  
};  
  
class Sample : public RefCount {  
public:  
   void doSomething(void) {  
      TRACE("Did something\n");  
   }  
};  
  
template <class T> class Ptr {  
   T* p;  
public:  
   Ptr(T* p_) : p(p_) {   
      p->upcount();  
   }  
  
   ~Ptr(void) {  
      p->downcount();  
   }  
  
   operator T*(void) {  
      return p;  
   }  
  
   T& operator*(void) {  
      return *p;  
   }  
  
   T* operator->(void) {  
      return p;  
   }  
  
   Ptr& operator=(Ptr<T> &p_) {  
      return operator=((T *) p_);  
   }  
  
   Ptr& operator=(T* p_) {  
      p_->upcount();  
      p->downcount();  
      p = p_;  
      return *this;  
   }  
  
   Ptr(const Ptr<T> &p_) {  
      p = p_.p;  
      p->upcount();  
   };  
};  
  
int main() {  
   Ptr<Sample> p  = new Sample; // sample #1  
   Ptr<Sample> p2 = new Sample; // sample #2  
   p = p2; // #1 will have 0 crefs, so it is destroyed;  
         // #2 will have 2 crefs.  
   p->doSomething();  
   return 0;  
   // As p2 and p go out of scope, their destructors call  
   // downcount. The cref variable of #2 goes to 0, so #2 is  
   // destroyed  
}  
```  
  
## Output  
  
```  
up to 1  
up to 1  
up to 2  
goodbye(0)  
Did something  
downto 1  
goodbye(0)  
```  
  
 Classes `RefCount` and `Ptr<T>` together provide a simple garbage collection solution for any class that can afford the `int` per instance overhead to inherit from `RefCount`. Note that the primary benefit of using a parametric class like `Ptr<T>` instead of a more generic class like `Ptr` is that the former is completely typesafe. The preceding code ensures that a `Ptr<T>` can be used almost anywhere a `T*` is used; in contrast, a generic `Ptr` would only provide implicit conversions to `void*`.  
  
 For example, consider a class used to create and manipulate garbage collected files, symbols, strings, and so forth. From the class template `Ptr<T>`, the compiler will create template classes `Ptr<File>`, `Ptr<Symbol>`, `Ptr<String>`, and so on, and their member functions: `Ptr<File>::~Ptr()`, `Ptr<File>::operator File*()`, `Ptr<String>::~Ptr()`, `Ptr<String>::operator String*()`, and so on.  
  
###  <a name="_core_When_Should_You_Use_Templates.3fAnchor3"></a> Templates and Collection Classes  
 Templates are a good way of implementing collection classes.  
  
## Example  
  
### Code  
  
```  
// templates_and_collection_classes.cpp  
template <class T, int i> class MyStack  
{  
   T StackBuffer[i];  
   int cItems;  
public:  
   MyStack( void ) : cItems( i )  
   {  
   };  
   void push( const T item );  
   T pop( void );  
};  
  
template <class T, int i> void MyStack< T, i >::push( const T item )  
{  
   if( cItems > 0 )  
      StackBuffer[--cItems] = item;  
   else  
      throw "Stack overflow error.";  
}  
  
template <class T, int i> T MyStack< T, i >::pop( void )  
{  
   if( cItems < i )  
      return StackBuffer[cItems++]  
   else  
      throw "Stack underflow error.";  
}  
  
int main()  
{  
   MyStack<char , 1> v;  
   v.push('a');  
}  
```  
  
### Comments  
 The `MyStack` collection is a simple implementation of a stack. The two template parameters, `T` and `i`, specify the type of elements in the stack and the maximum number of that item in the stack. The `push` and `pop` member functions add and remove items on the stack, with the stack growing from the bottom.