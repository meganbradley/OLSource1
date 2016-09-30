---
title: "uninitialized_fill"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "memory/std::uninitialized_fill"
  - "std.uninitialized_fill"
  - "uninitialized_fill"
  - "std::uninitialized_fill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uninitialized_fill function"
  - "uninitialized_fill"
ms.assetid: 6eadc810-1513-440a-9993-09d997215489
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uninitialized_fill
Copies objects of a specified value into an uninitialized destination range.  
  
## Syntax  
  
```  
  
   template<class ForwardIterator, class Type>  
void uninitialized_fill(  
   ForwardIterator _First,   
   ForwardIterator _Last,  
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_First`  
 A forward iterator addressing the first element in the destination range that is to be initiated.  
  
 `_Last`  
 A forward iterator addressing the last element in the destination range that is to be initiated.  
  
 `_Val`  
 The value to be used to initialize the destination range.  
  
## Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
```  
while ( _First!= _Last )  
   new ( (void *)&*_First ++)  
      iterator_traits<ForwardIterator>::value_type ( _Val );  
```  
  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Example  
  
```  
// memory_uninit_fill.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
  
using namespace std;  
  
   class Integer {         // No default constructor  
   public:  
      Integer( int x ) : val( x ) {}  
      int get( ) { return val; }  
   private:  
      int val;  
   };  
  
int main( )  
{  
   const int N = 10;  
   Integer val ( 25 );  
   Integer* Array = ( Integer* ) malloc( N * sizeof( int ) );  
   uninitialized_fill( Array, Array + N, val );  
   int i;  
   cout << "The initialized Array contains: ";  
      for ( i = 0 ; i < N; i++ )  
      {  
         cout << Array [ i ].get( ) << " ";  
      }  
   cout << endl;  
}  
```  
  
 **The initialized Array contains: 25 25 25 25 25 25 25 25 25 25**    
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std