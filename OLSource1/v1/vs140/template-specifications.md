---
title: "Template Specifications"
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
  - "template_cpp"
  - "template"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "templates, common compiler errors"
  - "templates, syntax"
  - "templates, C++"
  - "template keyword [C++]"
ms.assetid: 8c31924a-5c08-4d2d-aa54-543d7f744753
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Template Specifications
The `template` declaration specifies a set of parameterized classes or functions.  
  
## Syntax  
  
```  
template < template-parameter-list > declaration  
```  
  
## Remarks  
 The *template-parameter-list* is a comma-separated list of template parameters, which may be types (in the form **class***identifier*, **typename***identifier*, or **template <** *template-parameter-list* **> class** *identifier*) or non-type parameters to be used in the template body. The syntax for a template parameter is one of the following:  
  
```  
parameter-declaration  
class identifier [ = typename ]   
typename identifier [ = typename ]  
template < template-parameter-list > class [identifier][= name]  
```  
  
 You can instantiate a class template much like you would instantiate a normal class, but you must include the template arguments within angle brackets (**<>**). These template arguments can be any type if the template argument list contains the class or **typename** keyword, or a value of the appropriate type if the argument is a non-type argument. No special syntax is required to call a function template, although the angle brackets and template arguments can be required if the template parameters cannot be deduced from the arguments to the function.  
  
 The *template-parameter-list* is a list of parameters used by the template function that specifies which parts of the following code will vary. For example:  
  
```  
template< class T, int i > class MyStack...  
```  
  
 In this case, the template can receive a type (`class T`) and a constant parameter (`int i`). The template will use type `T` and the constant integer `i` upon instantiation. Within the body of the `MyStack` declaration, you must refer to the `T` identifier.  
  
 A template declaration itself does not generate code; it specifies a family of classes or functions, one or more of which will be generated when referenced by other code.  
  
 Template declarations have global, namespace, or class scope. They cannot be declared within a function.  
  
 The following example illustrates the declaration, definition, and instantiation of a class template with a type parameter `T` and a non-type template parameter `i`.  
  
```  
// template_specifications1.cpp  
template <class T, int i> class TestClass   
{  
public:  
   char buffer[i];  
   T testFunc(T* p1 );  
};  
  
template <class T, int i>  
T TestClass<T,i>::testFunc(T* p1)   
{  
    return *(p1++)  
};  
  
// To create an instance of TestClass  
TestClass<char, 5> ClassInst;  
int main()  
{  
}  
```  
  
## Non-type template arguments  
 Non-type template parameters must be of integral, enumeration, pointer, reference, or pointer to member type, and must be constant at compile time. They can be qualified as const or volatile types. Floating point values are not allowed as template parameters. Objects of class, struct or union type are not allowed as non-type template parameters, although pointers to such objects are allowed. Arrays passed as non-type template parameters are converted into pointers. Functions passed as non-type parameters are treated as function pointers. String literals are not allowed as template parameters.  
  
## Using typename in a Template Declaration  
 The [typename](../vs140/typename.md) keyword can be used in the template parameter list. The following template declarations are identical:  
  
```  
template< class T1, class T2 > class X...  
template< typename T1, typename T2 > class X...  
```  
  
## Default Arguments for Template Parameters  
 Class templates can have default arguments specified using the **=** sign followed by the default type or value. Function templates cannot have default arguments. For more information, see [Default Arguments for Class Templates](../vs140/default-arguments-for-class-templates.md) .:  
  
```  
template<typename Type> class allocator {};  
template<typename Type,   
   typename Allocator = allocator<Type> > class stack   
{  
};  
stack<int> MyStack;  
```  
  
## Reuse of Template Parameters  
 Template parameters can be reused in the template parameter list. For example, the following code is allowed:  
  
```  
// template_specifications2.cpp  
  
class Y   
{  
};  
template<class T, T* pT> class X1   
{  
};  
template<class T1, class T2 = T1> class X2   
{  
};  
  
Y aY;  
  
X1<Y, &aY> x1;  
X2<int> x2;  
  
int main()  
{  
}  
```  
  
## Templates as template parameters  
 Template parameters can themselves be templates. This construct means that the argument must itself be a template, not a class constructed from template. In the following example, the name `A` of the template parameter for a template template parameter can be omitted, because there is no way that it can be used.  
  
```  
// template_specifications3.cpp  
#include <stdio.h>  
  
template <class T> struct str1  
{  
   T t;  
};  
  
template <template<class A> class T> struct str2  
{  
    T<int> t;  
};  
  
int main()  
{  
    str2<str1> mystr2;  
    mystr2.t.t = 5;  
    printf_s("%d\n", mystr2.t.t);  
}  
```  
  
### Output  
  
```  
5  
```  
  
## References as Template Parameters  
 Visual Studio .NET 2003 introduced the ability to use references as non-type template parameters. This was not allowed in previous versions.  
  
```  
// references__supported_as_nontype_template_parameters.cpp  
#include <stdio.h>  
  
extern "C" int printf_s(const char*,...);  
template <int & ri> struct S  
{  
   S()  
   {  
      printf_s("ri is %d\n", ri);  
   }  
  
   ~S()  
   {  
      printf_s("ri is %d\n", ri);  
   }  
};  
  
int i = 1;  
  
int main()  
{  
   S<i> s;  
   i = 0;  
}  
```  
  
### Output  
  
```  
ri is 1  
ri is 0  
```  
  
## Nested Template Instances  
 Versions of Visual Studio prior to Visual Studio 2005 required that whitespace be inserted between template parameter lists when nested template instances were declared. The following syntax is now allowed:  
  
```  
// template_specifications4.cpp   
  
template <typename T>   
class A  
{  
};  
  
template <int n>   
class B   
{  
};  
  
int main()   
{  
   A<B<22>>();  
}  
```  
  
## See Also  
 [Templates](../vs140/templates--c---.md)   
 [C++ Keywords](../vs140/keywords--c---.md)