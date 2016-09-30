---
title: "multiset::reference"
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
  - "multiset::reference"
  - "set/std::multiset::reference"
  - "Reference"
  - "reference"
  - "multiset.reference"
  - "std.multiset.reference"
  - "std::multiset::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference method"
  - "reference typedef"
ms.assetid: 60f7a580-1c79-49c4-901f-c27f26a69cbc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::reference
A type that provides a reference to an element stored in a multiset.  
  
## Syntax  
  
```  
typedef typename allocator_type::reference reference;  
```  
  
## Example  
  
```  
// multiset_ref.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   multiset <int> ms1;  
  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
  
   // Declare and initialize a reference &Ref1 to the 1st element  
   const int &Ref1 = *ms1.begin( );  
  
   cout << "The first element in the multiset is "  
        << Ref1 << "." << endl;  
}  
```  
  
 **The first element in the multiset is 10.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)