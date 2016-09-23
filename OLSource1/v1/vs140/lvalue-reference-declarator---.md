---
title: "Lvalue Reference Declarator: &amp;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - &
dev_langs: 
  - C++
helpviewer_keywords: 
  - reference operator
  - & operator, reference operator
ms.assetid: edf0513d-3dcc-4663-b276-1269795dda51
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Lvalue Reference Declarator: &amp;
Holds the address of an object but behaves syntactically like an object.  
  
## Syntax  
  
```  
  
type-id & cast-expression  
```  
  
## Remarks  
 You can think of an lvalue reference as another name for an object. An lvalue reference declaration consists of an optional list of specifiers followed by a reference declarator. A reference must be initialized and cannot be changed.  
  
 Any object whose address can be converted to a given pointer type can also be converted to the similar reference type. For example, any object whose address can be converted to type `char *` can also be converted to type `char &`.  
  
 Do not confuse reference declarations with use of the [address-of operator](../vs140/address-of-operator---.md). When the `&`*identifier* is preceded by a type, such as `int` or `char`, *identifier* is declared as a reference to the type. When `&`*identifier* is not preceded by a type, the usage is that of the address-of operator.  
  
## Example  
 The following example demonstrates the reference declarator by declaring a `Person` object and a reference to that object. Because `rFriend` is a reference to `myFriend`, updating either variable changes the same object.  
  
```  
// reference_declarator.cpp  
// compile with: /EHsc  
// Demonstrates the reference declarator.  
#include <iostream>  
using namespace std;  
  
struct Person  
{  
    char* Name;  
    short Age;  
};  
  
int main()  
{  
   // Declare a Person object.  
   Person myFriend;  
  
   // Declare a reference to the Person object.  
   Person& rFriend = myFriend;  
  
   // Set the fields of the Person object.  
   // Updating either variable changes the same object.  
   myFriend.Name = "Bill";  
   rFriend.Age = 40;  
  
   // Print the fields of the Person object to the console.  
   cout << rFriend.Name << " is " << myFriend.Age << endl;  
}  
```  
  
 **Bill is 40**   
## See Also  
 [References (C++)](../vs140/references--c---.md)   
 [Reference-Type Function Arguments](../vs140/reference-type-function-arguments.md)   
 [Reference-Type Function Returns](../vs140/reference-type-function-returns.md)   
 [References to Pointers](../vs140/references-to-pointers.md)