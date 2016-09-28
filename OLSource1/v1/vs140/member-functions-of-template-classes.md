---
title: "Member Functions of Template Classes"
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
  - "member function templates"
  - "templates, member function"
ms.assetid: 296430a6-c6a5-4c83-8569-4d85433eb8a1
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Member Functions of Template Classes
Member functions can be defined inside or outside of a class template. They are defined like function templates if defined outside the class template.  
  
## Example  
  
```  
// member_function_templates1.cpp  
template<class T, int i> class MyStack  
{  
    T*  pStack;  
    T StackBuffer[i];  
    static const int cItems = i * sizeof(T);  
public:   
    MyStack( void );  
    void push( const T item );  
    T& pop( void );  
};  
  
template< class T, int i > MyStack< T, i >::MyStack( void )  
{  
};  
  
template< class T, int i > void MyStack< T, i >::push( const T item )  
{  
};  
  
template< class T, int i > T& MyStack< T, i >::pop( void )  
{  
};  
  
int main()  
{  
}  
```  
  
 Note that just as with any template class member function, the definition of the class's constructor member function includes the template argument list twice.  
  
## Example  
 Member functions can themselves be function templates, specifying additional parameters, as in the following example.  
  
```  
// member_templates.cpp  
template<typename T>  
class X  
{  
public:  
   template<typename U>  
   void mf(const U &u);  
};  
  
template<typename T> template <typename U>  
void X<T>::mf(const U &u)  
{  
}  
  
int main()  
{  
}  
```  
  
## See Also  
 [Class Templates](../vs140/class-templates.md)