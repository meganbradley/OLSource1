---
title: "hash_set::reference"
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
  - stdext::hash_set::reference
  - std::hash_set::reference
  - hash_set/stdext::hash_set::reference
  - hash_set::reference
  - Reference
  - reference
  - std.hash_set.reference
  - hash_set.reference
  - stdext.hash_set.reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - reference method
  - reference typedef
ms.assetid: 1712f9a1-3f0b-4cd5-b0e8-374067dc3404
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::reference
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a reference to an element stored in a hash_set.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::reference reference;  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_reference.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
  
   hs1.insert( 10 );  
   hs1.insert( 20 );  
  
   // Declare and initialize a reference &Ref1 to the 1st element  
   int &Ref1 = *hs1.begin( );  
  
   cout << "The first element in the hash_set is "  
        << Ref1 << "." << endl;  
  
   // The value of the 1st element of the hash_set can be changed  
   // by operating on its (non-const) reference  
   Ref1 = Ref1 + 5;  
  
   cout << "The first element in the hash_set is now "  
        << *hs1.begin() << "." << endl;  
}  
```  
  
 **The first element in the hash_set is 10.**  
**The first element in the hash_set is now 15.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)