---
title: "multimap::const_reference"
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
  - "map/std::multimap::const_reference"
  - "std.multimap.const_reference"
  - "const_reference"
  - "multimap::const_reference"
  - "multimap.const_reference"
  - "std::multimap::const_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reference method"
  - "const_reference typedef"
ms.assetid: 8961012f-3565-4605-9ca7-d408dfbb99b8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::const_reference
A type that provides a reference to a **const** element stored in a multimap for reading and performing **const** operations.  
  
## Syntax  
  
```  
typedef typename allocator_type::const_reference const_reference;  
```  
  
## Example  
  
```  
// multimap_const_ref.cpp  
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
  
   cout << "The key of the first element in the multimap is "  
        << Ref1 << "." << endl;  
  
   // Declare and initialize a reference &Ref2   
   // to the data value of the first element  
   int &Ref2 = ( m1.begin( ) -> second );  
  
   cout << "The data value of the first element in the multimap is "  
        << Ref2 << "." << endl;  
}  
```  
  
 **The key of the first element in the multimap is 1.**  
**The data value of the first element in the multimap is 10.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)