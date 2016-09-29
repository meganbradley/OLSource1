---
title: "set::const_reference"
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
  - "set/std::set::const_reference"
  - "std::set::const_reference"
  - "set::const_reference"
  - "const_reference"
  - "set.const_reference"
  - "std.set.const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
  - "const_reference typedef"
ms.assetid: 4fd27d91-9c49-404d-a4df-92e07922cad4
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::const_reference
A type that provides a reference to a **const** element stored in a set for reading and performing **const** operations.  
  
## Syntax  
  
```  
typedef typename allocator_type::const_reference const_reference;  
```  
  
## Example  
  
```  
// set_const_ref.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1;  
  
   s1.insert( 10 );  
   s1.insert( 20 );  
  
   // Declare and initialize a const_reference &Ref1   
   // to the 1st element  
   const int &Ref1 = *s1.begin( );  
  
   cout << "The first element in the set is "  
        << Ref1 << "." << endl;  
  
   // The following line would cause an error because the   
   // const_reference cannot be used to modify the set  
   // Ref1 = Ref1 + 5;  
}  
```  
  
 **The first element in the set is 10.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)