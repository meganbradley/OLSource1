---
title: "hash_multimap::reference"
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
  - "hash_multimap.reference"
  - "std::hash_multimap::reference"
  - "stdext::hash_multimap::reference"
  - "Reference"
  - "reference"
  - "stdext.hash_multimap.reference"
  - "hash_map/stdext::hash_multimap::reference"
  - "std.hash_multimap.reference"
  - "hash_multimap::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference method"
  - "reference typedef"
ms.assetid: dc6da624-5309-4ddd-8a0d-4392bdd2ca4b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::reference
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a reference to an element stored in a hash_multimap.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::reference reference;  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_reference.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
  
   // Declare and initialize a const_reference &Ref1   
   // to the key of the first element  
   const int &Ref1 = ( hm1.begin( ) -> first );  
  
   // The following line would cause an error as the   
   // non-const_reference cannot be used to access the key  
   // int &Ref1 = ( hm1.begin( ) -> first );  
  
   cout << "The key of first element in the hash_multimap is "  
        << Ref1 << "." << endl;  
  
   // Declare and initialize a reference &Ref2   
   // to the data value of the first element  
   int &Ref2 = ( hm1.begin( ) -> second );  
  
   cout << "The data value of first element in the hash_multimap is "  
        << Ref2 << "." << endl;  
  
   //The non-const_reference can be used to modify the   
   //data value of the first element  
   Ref2 = Ref2 + 5;  
   cout << "The modified data value of first element is "  
        << Ref2 << "." << endl;  
}  
```  
  
 **The key of first element in the hash_multimap is 1.**  
**The data value of first element in the hash_multimap is 10.**  
**The modified data value of first element is 15.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)