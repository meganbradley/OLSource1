---
title: "hash_set::const_reference"
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
  - hash_set.const_reference
  - const_reference
  - std::hash_set::const_reference
  - stdext.hash_set.const_reference
  - hash_set::const_reference
  - stdext::hash_set::const_reference
  - hash_set/stdext::hash_set::const_reference
  - std.hash_set.const_reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - const_reference method
  - const_reference typedef
ms.assetid: 70b56128-7cc1-47df-b8bb-8297cbb8a5e2
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::const_reference
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a reference to a **const** element stored in a hash_set for reading and performing **const** operations.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::const_reference const_reference;  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_const_ref.cpp  
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
  
   // Declare and initialize a const_reference &Ref1   
   // to the 1st element  
   const int &Ref1 = *hs1.begin( );  
  
   cout << "The first element in the hash_set is "  
        << Ref1 << "." << endl;  
  
   // The following line would cause an error because the   
   // const_reference cannot be used to modify the hash_set  
   // Ref1 = Ref1 + 5;  
}  
```  
  
 **The first element in the hash_set is 10.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)