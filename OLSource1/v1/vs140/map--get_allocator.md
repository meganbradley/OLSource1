---
title: "map::get_allocator"
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
  - "map.get_allocator"
  - "std.map.get_allocator"
  - "map/std::map::get_allocator"
  - "get_allocator"
  - "std::map::get_allocator"
  - "map::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 1d17b404-7d76-4626-8bb1-f14bdc8f2722
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# map::get_allocator
Returns a copy of the allocator object used to construct the map.  
  
## Syntax  
  
```  
allocator_type get_allocator( ) const;  
```  
  
## Return Value  
 The allocator used by the map.  
  
## Remarks  
 Allocators for the map class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
```  
// map_get_allocator.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   map <int, int>::allocator_type m1_Alloc;  
   map <int, int>::allocator_type m2_Alloc;  
   map <int, double>::allocator_type m3_Alloc;  
   map <int, int>::allocator_type m4_Alloc;  
  
   // The following lines declare objects  
   // that use the default allocator.  
   map <int, int> m1;  
   map <int, int, allocator<int> > m2;  
   map <int, double, allocator<double> > m3;  
  
   m1_Alloc = m1.get_allocator( );  
   m2_Alloc = m2.get_allocator( );  
   m3_Alloc = m3.get_allocator( );  
  
   cout << "The number of integers that can be allocated\n"  
        << "before free memory is exhausted: "  
        << m2.max_size( ) << ".\n" << endl;  
  
   cout << "The number of doubles that can be allocated\n"  
        << "before free memory is exhausted: "  
        << m3.max_size( ) <<  ".\n" << endl;  
  
   // The following line creates a map m4  
   // with the allocator of map m1.  
   map <int, int> m4( less<int>( ), m1_Alloc );  
  
   m4_Alloc = m4.get_allocator( );  
  
   // Two allocators are interchangeable if  
   // storage allocated from each can be  
   // deallocated with the other  
   if( m1_Alloc == m4_Alloc )     
   {  
      cout << "The allocators are interchangeable." << endl;  
   }  
   else     
   {  
      cout << "The allocators are not interchangeable." << endl;  
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
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)