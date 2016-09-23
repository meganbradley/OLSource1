---
title: "multimap::reference"
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
  - multimap.reference
  - std.multimap.reference
  - multimap::reference
  - Reference
  - std::multimap::reference
  - reference
  - map/std::multimap::reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - reference method
  - reference typedef
ms.assetid: 69a6577e-f6b0-4814-ad98-2da8e6f2fe8e
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multimap::reference
A type that provides a reference to an element stored in a multimap.  
  
## Syntax  
  
```  
typedef typename allocator_type::reference reference;  
```  
  
## Example  
  
```  
// multimap_ref.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
  
   // Declare and initialize a const_reference &Ref1   
   // to the key of the first element  
   const int &Ref1 = ( m1.begin( ) -> first );  
  
   // The following line would cause an error because the   
   // non-const_reference cannot be used to access the key  
   // int &Ref1 = ( m1.begin( ) -> first );  
  
   cout << "The key of first element in the multimap is "  
        << Ref1 << "." << endl;  
  
   // Declare and initialize a reference &Ref2   
   // to the data value of the first element  
   int &Ref2 = ( m1.begin( ) -> second );  
  
   cout << "The data value of first element in the multimap is "  
        << Ref2 << "." << endl;  
  
   // The non-const_reference can be used to modify the   
   // data value of the first element  
   Ref2 = Ref2 + 5;  
   cout << "The modified data value of first element is "  
        << Ref2 << "." << endl;  
}  
```  
  
 **The key of first element in the multimap is 1.**  
**The data value of first element in the multimap is 10.**  
**The modified data value of first element is 15.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)