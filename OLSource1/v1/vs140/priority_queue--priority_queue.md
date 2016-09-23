---
title: "priority_queue::priority_queue"
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
  - priority_queue.priority_queue
  - std.priority_queue.priority_queue
  - priority_queue
  - std::priority_queue::priority_queue
  - priority_queue::priority_queue
dev_langs: 
  - C++
helpviewer_keywords: 
  - priority_queue class, constructor
  - priority_queue method
ms.assetid: 1761ee2e-4e18-4f39-bf9f-910404d46a2c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# priority_queue::priority_queue
Constructs a priority_queue that is empty or that is a copy of a range of a base container object or of another priority_queue.  
  
## Syntax  
  
```  
  
      priority_queue( );   
explicit priority_queue(  
   const Traits& __Comp  
);  
priority_queue(  
   const Traits& __Comp,  
   const container_type& _Cont  
);  
priority_queue(  
   const priority_queue& _Right  
);  
template<class InputIterator>  
   priority_queue(  
      InputIterator _First,   
      InputIterator _Last  
);  
template<class InputIterator>  
   priority_queue(  
      InputIterator _First,   
      InputIterator _Last,  
      const Traits& __Comp  
);  
template<class InputIterator>  
   priority_queue(  
      InputIterator _First,   
      InputIterator _Last,  
      const Traits& __Comp,   
      const container_type& _Cont  
);  
```  
  
#### Parameters  
 *__Comp*  
 The comparison function of type **constTraits** used to order the elements in the priority_queue, which defaults to compare function of the base container.  
  
 `_Cont`  
 The base container of which the constructed priority_queue is to be a copy.  
  
 `_Right`  
 The priority_queue of which the constructed set is to be a copy.  
  
 `_First`  
 The position of the first element in the range of elements to be copied.  
  
 `_Last`  
 The position of the first element beyond the range of elements to be copied.  
  
## Remarks  
 Each of the first three constructors specifies an empty initial priority_queue, the second also specifying the type of comparison function (`_Comp`) to be used in establishing the order of the elements and the third explicitly specifying the `container_type` (`_Cont`) to be used. The keyword **explicit** suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the priority_queue `_Right`.  
  
 The last three constructors copy the range [*_First, _Last*) of some container and use the values to initialize a priority_queue with increasing explicitness in specifying the type of comparison function of class **Traits** and `container_type`.  
  
## Example  
  
```  
// pqueue_ctor.cpp  
// compile with: /EHsc  
#include <queue>  
#include <vector>  
#include <deque>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // The first member function declares priority_queue  
   // with a default vector base container  
   priority_queue <int> q1;  
   cout << "q1 = ( ";  
   while ( !q1.empty( ) )  
   {  
      cout << q1.top( ) << " ";  
      q1.pop( );  
   }  
   cout << ")" << endl;  
  
   // Explicitly declares a priority_queue with nondefault  
   // deque base container  
   priority_queue <int, deque <int> > q2;  
   q2.push( 5 );  
   q2.push( 15 );  
   q2.push( 10 );  
   cout << "q2 = ( ";  
   while ( !q2.empty( ) )  
   {  
      cout << q2.top( ) << " ";  
      q2.pop( );  
   }  
   cout << ")" << endl;  
  
   // This method of printing out the elements of a priority_queue  
   // removes the elements from the priority queue, leaving it empty  
   cout << "After printing, q2 has " << q2.size( ) << " elements." << endl;  
  
   // The third member function declares a priority_queue   
   // with a vector base container and specifies that the comparison   
   // function greater is to be used for ordering elements  
   priority_queue <int, vector<int>, greater<int> > q3;  
   q3.push( 2 );  
   q3.push( 1 );  
   q3.push( 3 );  
   cout << "q3 = ( ";  
   while ( !q3.empty( ) )  
   {  
      cout << q3.top( ) << " ";  
      q3.pop( );  
   }  
   cout << ")" << endl;  
  
   // The fourth member function declares a priority_queue and  
   // initializes it with elements copied from another container:  
   // first, inserting elements into q1, then copying q1 elements into q4  
   q1.push( 100 );  
   q1.push( 200 );  
   priority_queue <int> q4( q1 );  
   cout << "q4 = ( ";     
   while ( !q4.empty( ) )  
   {  
      cout << q4.top( ) << " ";  
      q4.pop( );  
   }  
   cout << ")" << endl;  
  
   // Creates an auxiliary vector object v5 to be used to initialize q5  
   vector <int> v5;  
   vector <int>::iterator v5_Iter;  
   v5.push_back( 10 );  
   v5.push_back( 30 );  
   v5.push_back( 20 );  
   cout << "v5 = ( " ;  
   for ( v5_Iter = v5.begin( ) ; v5_Iter != v5.end( ) ; v5_Iter++ )  
      cout << *v5_Iter << " ";  
   cout << ")" << endl;  
  
   // The fifth member function declares and  
   // initializes a priority_queue q5 by copying the  
   // range v5[_First, _Last) from vector v5  
   priority_queue <int> q5( v5.begin( ), v5.begin( ) + 2 );  
   cout << "q5 = ( ";  
   while ( !q5.empty( ) )  
   {  
      cout << q5.top( ) << " ";  
      q5.pop( );  
   }  
   cout << ")" << endl;  
  
   // The sixth member function declares a priority_queue q6  
   // with a comparison function greater and initializes q6  
   // by copying the range v5[_First, _Last) from vector v5  
   priority_queue <int, vector<int>, greater<int> >   
      q6( v5.begin( ), v5.begin( ) + 2 );  
   cout << "q6 = ( ";  
   while ( !q6.empty( ) )  
   {  
      cout << q6.top( ) << " ";  
      q6.pop( );  
   }  
   cout << ")" << endl;  
}  
```  
  
## Output  
  
```  
q1 = ( )  
q2 = ( 15 10 5 )  
After printing, q2 has 0 elements.  
q3 = ( 1 2 3 )  
q4 = ( 200 100 )  
v5 = ( 10 30 20 )  
q5 = ( 30 10 )  
q6 = ( 10 30 )  
```  
  
## Requirements  
 **Header:** <queue\>  
  
 **Namespace:** std  
  
## See Also  
 [priority_queue Class](../vs140/priority_queue-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)