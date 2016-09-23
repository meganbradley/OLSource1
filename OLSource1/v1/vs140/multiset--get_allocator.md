---
title: "multiset::get_allocator"
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
  - set/std::multiset::get_allocator
  - get_allocator
  - multiset.get_allocator
  - multiset::get_allocator
  - std.multiset.get_allocator
  - std::multiset::get_allocator
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_allocator method
ms.assetid: 2a5b182f-be8e-4746-9500-efcaa4f39458
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::get_allocator
Returns a copy of the allocator object used to construct the multiset.  
  
## Syntax  
  
```  
allocator_type get_allocator( ) const;  
```  
  
## Return Value  
 The allocator used by the multiset.  
  
## Remarks  
 Allocators for the multiset class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
```  
// multiset_get_allocator.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multiset <int>::allocator_type ms1_Alloc;  
   multiset <int>::allocator_type ms2_Alloc;  
   multiset <double>::allocator_type ms3_Alloc;  
   multiset <int>::allocator_type ms4_Alloc;  
  
   // The following lines declare objects  
   // that use the default allocator.  
   multiset <int> ms1;  
   multiset <int, allocator<int> > ms2;  
   multiset <double, allocator<double> > ms3;  
  
   cout << "The number of integers that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << ms2.max_size( ) << "." << endl;  
  
   cout << "The number of doubles that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << ms3.max_size( ) <<  "." << endl;  
  
   // The following lines create a multiset ms4  
   // with the allocator of multiset ms1  
   ms1_Alloc = ms1.get_allocator( );  
   multiset <int> ms4( less<int>( ), ms1_Alloc );  
   ms4_Alloc = ms4.get_allocator( );  
  
   // Two allocators are interchangeable if  
   // storage allocated from each can be  
   // deallocated with the other  
   if( ms1_Alloc == ms4_Alloc )     
   {  
      cout << "Allocators are interchangeable."  
           << endl;     
   }  
   else     
   {  
      cout << "Allocators are not interchangeable."  
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
Allocators are interchangeable.  
```  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)