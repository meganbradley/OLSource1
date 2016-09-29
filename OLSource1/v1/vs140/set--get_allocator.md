---
title: "set::get_allocator"
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
  - "std.set.get_allocator"
  - "set/std::set::get_allocator"
  - "get_allocator"
  - "std::set::get_allocator"
  - "set.get_allocator"
  - "set::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 276f8a19-5f63-47ce-ba3c-cefb0d74aa3a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::get_allocator
Returns a copy of the allocator object used to construct the set.  
  
## Syntax  
  
```  
allocator_type get_allocator( ) const;  
```  
  
## Return Value  
 The allocator used by the set to manage memory, which is the template parameter `Allocator`.  
  
 For more information on `Allocator`, see the Remarks section of the [set Class](../vs140/set-class.md) topic.  
  
## Remarks  
 Allocators for the set class specify how the class manages storage. The default allocators supplied with STL container classes is sufficient for most programming needs. Writing and using your own allocator class is an advanced C++ topic.  
  
## Example  
  
```  
// set_get_allocator.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int>::allocator_type s1_Alloc;  
   set <int>::allocator_type s2_Alloc;  
   set <double>::allocator_type s3_Alloc;  
   set <int>::allocator_type s4_Alloc;  
  
   // The following lines declare objects  
   // that use the default allocator.  
   set <int> s1;  
   set <int, allocator<int> > s2;  
   set <double, allocator<double> > s3;  
  
   s1_Alloc = s1.get_allocator( );  
   s2_Alloc = s2.get_allocator( );  
   s3_Alloc = s3.get_allocator( );  
  
   cout << "The number of integers that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << s2.max_size( ) << "." << endl;  
  
   cout << "\nThe number of doubles that can be allocated"  
        << endl << "before free memory is exhausted: "  
        << s3.max_size( ) <<  "." << endl;  
  
   // The following line creates a set s4  
   // with the allocator of multiset s1.  
   set <int> s4( less<int>( ), s1_Alloc );  
  
   s4_Alloc = s4.get_allocator( );  
  
   // Two allocators are interchangeable if  
   // storage allocated from each can be  
   // deallocated by the other  
   if( s1_Alloc == s4_Alloc )  
   {  
      cout << "\nThe allocators are interchangeable."  
           << endl;  
   }  
   else  
   {  
      cout << "\nThe allocators are not interchangeable."  
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
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)