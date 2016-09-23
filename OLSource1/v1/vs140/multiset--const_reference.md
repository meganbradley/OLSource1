---
title: "multiset::const_reference"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - set/std::multiset::const_reference
  - const_reference
  - multiset::const_reference
  - std.multiset.const_reference
  - multiset.const_reference
  - std::multiset::const_reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_reference method
  - const_reference typedef
ms.assetid: 70055d6d-dc27-414b-a838-c8f947747e02
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::const_reference
A type that provides a reference to a **const** element stored in a multiset for reading and performing **const** operations.  
  
## Syntax  
  
```  
typedef typename allocator_type::const_reference const_reference;  
```  
  
## Example  
  
```  
// multiset_const_ref.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multiset <int> ms1;  
  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
  
   // Declare and initialize a const_reference &Ref1   
   // to the 1st element  
   const int &Ref1 = *ms1.begin( );  
  
   cout << "The first element in the multiset is "  
        << Ref1 << "." << endl;  
  
   // The following line would cause an error because the   
   // const_reference cannot be used to modify the multiset  
   // Ref1 = Ref1 + 5;  
}  
```  
  
 **The first element in the multiset is 10.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)