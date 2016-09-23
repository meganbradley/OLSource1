---
title: "hash_multiset::get_allocator"
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
  - hash_set/stdext::hash_multiset::get_allocator
  - hash_multiset::get_allocator
  - get_allocator
  - hash_multiset.get_allocator
  - std.hash_multiset.get_allocator
  - std::hash_multiset::get_allocator
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_allocator method
ms.assetid: 49bca9b1-eb32-4956-936c-cce2992941a4
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multiset::get_allocator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a copy of the allocator object used to construct the hash_multiset.  
  
## Syntax  
  
```  
  
Allocator get_allocator( ) const;  
  
```  
  
## Return Value  
 The allocator used by the hash_multiset to manage memory, which is the class's template parameter `Allocator`.  
  
 For more information on `Allocator`, see the Remarks section of the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
## Remarks  
 Allocators for the hash_multiset class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_get_allocator.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
  
   // The following lines declare objects  
   // that use the default allocator.  
   hash_multiset <int, hash_compare <int, less<int> > > hms1;  
   hash_multiset <int, hash_compare <int, greater<int> > > hms2;  
   hash_multiset <double, hash_compare <double,  
      less<double> >, allocator<double> > hms3;  
  
   hash_multiset <int, hash_compare <int,  
      greater<int> > >::allocator_type hms2_Alloc;  
   hash_multiset <double>::allocator_type hms3_Alloc;  
   hms2_Alloc = hms2.get_allocator( );  
  
   cout << "The number of integers that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << hms1.max_size( ) << "." << endl;  
  
   cout << "The number of doubles that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << hms3.max_size( ) <<  "." << endl;  
  
   // The following lines create a hash_multiset hms4  
   // with the allocator of hash_multiset hms1.  
   hash_multiset <int>::allocator_type hms4_Alloc;  
   hash_multiset <int> hms4;  
   hms4_Alloc = hms2.get_allocator( );  
  
   // Two allocators are interchangeable if  
   // storage allocated from each can be  
   // deallocated by the other  
   if( hms2_Alloc == hms4_Alloc )  
   {  
      cout << "The allocators are interchangeable."  
           << endl;  
   }  
   else  
   {  
      cout << "The allocators are not interchangeable."  
           << endl;  
   }  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The number of integers that can be allocated  
before free memory is exhausted: 1073741823.  
The number of doubles that can be allocated  
before free memory is exhausted: 536870911.  
The allocators are interchangeable.  
```  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)