---
title: "Nested Class Templates"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - class templates, nested
  - nested class templates
ms.assetid: b3b53e03-950d-4699-b07b-41219dbc2d9f
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Nested Class Templates
Templates can be defined within classes or class templates, in which case they are referred to as member templates. Member templates that are classes are referred to as nested class templates. Member templates that are functions are discussed in [Member Function Templates](../vs140/member-function-templates.md).  
  
 Nested class templates are declared as class templates inside the scope of the outer class. They can be defined inside or outside of the enclosing class.  
  
## Example  
 The following code demonstrates a nested class template inside an ordinary class.  
  
```  
// nested_class_template1.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
class X  
{  
  
   template <class T>  
   struct Y  
   {  
      T m_t;  
      Y(T t): m_t(t) { }     
   };  
  
   Y<int> yInt;  
   Y<char> yChar;  
  
public:  
   X(int i, char c) : yInt(i), yChar(c) { }  
   void print()  
   {  
      cout << yInt.m_t << " " << yChar.m_t << endl;  
   }  
};  
  
int main()  
{  
   X x(1, 'a');  
   x.print();  
}  
```  
  
## Output  
  
```  
1 a  
```  
  
## Example  
 When nested class templates are defined outside of their enclosing class, they must be prefaced by the template parameters for both the class template (if they are members of a class template) and template parameters for the member template.  
  
```  
// nested_class_template2.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
template <class T>  
class X  
{  
   template <class U> class Y  
   {  
      U* u;  
   public:  
      Y();  
      U& Value();  
      void print();  
      ~Y();  
   };  
  
   Y<int> y;  
public:  
   X(T t) { y.Value() = t; }  
   void print() { y.print(); }  
};  
  
template <class T>   
template <class U>  
X<T>::Y<U>::Y()  
{  
   cout << "X<T>::Y<U>::Y()" << endl;  
   u = new U();  
}  
  
template <class T>   
template <class U>  
U& X<T>::Y<U>::Value()  
{  
   return *u;  
}  
  
template <class T>   
template <class U>  
void X<T>::Y<U>::print()  
{  
   cout << this->Value() << endl;  
}  
  
template <class T>   
template <class U>  
X<T>::Y<U>::~Y()  
{  
   cout << "X<T>::Y<U>::~Y()" << endl;  
   delete u;  
}  
  
int main()  
{  
   X<int>* xi = new X<int>(10);  
   X<char>* xc = new X<char>('c');  
   xi->print();  
   xc->print();  
   delete xi;  
   delete xc;  
}  
```  
  
## Output  
  
```  
X<T>::Y<U>::Y()  
X<T>::Y<U>::Y()  
10  
99  
X<T>::Y<U>::~Y()  
X<T>::Y<U>::~Y()  
```  
  
 Local classes are not allowed to have member templates.  
  
## See Also  
 [Class Templates](../vs140/class-templates.md)   
 [Member Function Templates](../vs140/member-function-templates.md)