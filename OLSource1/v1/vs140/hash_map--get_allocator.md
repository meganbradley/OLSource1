---
title: "hash_map::get_allocator"
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
  - "hash_map::get_allocator"
  - "get_allocator"
  - "std::hash_map::get_allocator"
  - "hash_map/stdext::hash_map::get_allocator"
  - "std.hash_map.get_allocator"
  - "hash_map.get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: b736a227-74b2-43eb-baa0-2dffbd4999e8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::get_allocator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a copy of the allocator object used to construct the hash_map.  
  
## Syntax  
  
```  
  
Allocator get_allocator( ) const;  
  
```  
  
## Return Value  
 The allocator used by the hash_map.  
  
## Remarks  
 Allocators for the hash_map class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_get_allocator.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int>::allocator_type hm1_Alloc;  
   hash_map <int, int>::allocator_type hm2_Alloc;  
   hash_map <int, double>::allocator_type hm3_Alloc;  
   hash_map <int, int>::allocator_type hm4_Alloc;  
  
   // The following lines declare objects  
   // that use the default allocator.  
   hash_map <int, int> hm1;  
   hash_map <int, int> hm2;  
   hash_map <int, double> hm3;  
  
   hm1_Alloc = hm1.get_allocator( );  
   hm2_Alloc = hm2.get_allocator( );  
   hm3_Alloc = hm3.get_allocator( );  
  
   cout << "The number of integers that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << hm2.max_size( ) << "." << endl;  
  
   cout << "The number of doubles that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << hm3.max_size( ) <<  "." << endl;  
  
   // The following line creates a hash_map hm4  
   // with the allocator of hash_map hm1.  
   hash_map <int, int> hm4( less<int>( ), hm1_Alloc );  
  
   hm4_Alloc = hm4.get_allocator( );  
  
   // Two allocators are interchangeable if  
   // storage allocated from each can be  
   // deallocated with the other  
   if( hm1_Alloc == hm4_Alloc )  
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
before free memory is exhausted: 536870911.  
The number of doubles that can be allocated  
before free memory is exhausted: 268435455.  
The allocators are interchangeable.  
```  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)