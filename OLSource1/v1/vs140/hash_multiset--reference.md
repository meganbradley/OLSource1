---
title: "hash_multiset::reference"
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
  - "hash_multiset::reference"
  - "Reference"
  - "std::hash_multiset::reference"
  - "reference"
  - "std.hash_multiset.reference"
  - "stdext.hash_multiset.reference"
  - "hash_set/stdext::hash_multiset::reference"
  - "hash_multiset.reference"
  - "stdext::hash_multiset::reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference method"
  - "reference typedef"
ms.assetid: 5d450d99-c22d-453d-acef-2a78a67f7598
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::reference
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a reference to an element stored in a hash_multiset.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::reference reference;  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_reference.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   using namespace stdext;  
   hash_multiset <int> hms1;  
  
   hms1.insert( 10 );  
   hms1.insert( 20 );  
  
   // Declare and initialize a reference &Ref1 to the 1st element  
   int &Ref1 = *hms1.begin( );  
  
   cout << "The first element in the hash_multiset is "  
        << Ref1 << "." << endl;  
  
   // The value of the 1st element of the hash_multiset can be  
   // changed by operating on its (non const) reference  
   Ref1 = Ref1 + 5;  
  
   cout << "The first element in the hash_multiset is now "  
        << *hms1.begin() << "." << endl;  
}  
```  
  
 **The first element in the hash_multiset is 10.**  
**The first element in the hash_multiset is now 15.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)