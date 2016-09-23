---
title: "Default Arguments for Class Templates"
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
  - class templates, default arguments
ms.assetid: 358144eb-a8b1-4666-8007-fb6f1a11aaa0
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Default Arguments for Class Templates
Class templates can have default arguments for type or value parameters. Specify default arguments with the equal (**=**) sign followed by the type name or value. For multiple template arguments, all arguments after the first default argument must have default arguments. When declaring a template class object with default arguments, omit the arguments to accept the default argument. If there are no nondefault arguments, do not omit the empty angle brackets.  
  
 A template that is multiply declared cannot specify a default argument more than once. The following code demonstrates an error:  
  
```  
template <class T = long> class A;  
template <class T = long> class A { /* . . . */ }; // Generates C4348.  
```  
  
## Example  
 In the following example, an array class template is defined with a default type `int` for the array element and a default value for the template parameter specifying the size.  
  
```  
// template_default_arg.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
template <class T = int, int size = 10> class Array  
{  
   T* array;  
public:  
   Array()  
   {  
      array = new T[size];  
      memset(array, 0, size * sizeof(T));  
   }  
   T& operator[](int i)  
   {  
      return *(array + i);  
   }  
   const int Length() { return size; }  
   void print()  
   {  
      for (int i = 0; i < size; i++)  
      {  
         cout << (*this)[i] << " ";  
      }  
      cout << endl;  
   }  
};  
  
int main()  
{  
   // Explicitly specify the template arguments:  
   Array<char, 26> ac;  
   for (int i = 0; i < ac.Length(); i++)  
   {  
      ac[i] = 'A' + i;  
   }  
   ac.print();  
  
   // Accept the default template arguments:  
   Array<> a; // You must include the angle brackets.  
   for (int i = 0; i < a.Length(); i++)  
   {  
      a[i] = i*10;  
   }  
   a.print();  
}  
```  
  
 **A B C D E F G H I J K L M N O P Q R S T U V W X Y Z**   
**0 10 20 30 40 50 60 70 80 90**    
## See Also  
 [Default Arguments](../vs140/default-arguments.md)