---
title: "uninitialized_fill_n"
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
  - "memory/std::uninitialized_fill_n"
  - "uninitialized_fill_n"
  - "std::uninitialized_fill_n"
  - "std.uninitialized_fill_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uninitialized_fill_n"
  - "uninitialized_fill_n function"
ms.assetid: 4b14460b-fd5e-4fbc-a606-a447a74a65ef
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# uninitialized_fill_n
Copies objects of a specified value into specified number of elements into an uninitialized destination range.  
  
## Syntax  
  
```  
  
   template<class FwdIt, class Size, class Type>  
void uninitialized_fill_n(  
   ForwardIterator _First,   
   Size _Count,  
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_First`  
 A forward iterator addressing the first element in the destination range to be initiated.  
  
 `_Count`  
 The number of elements to be initialized.  
  
 `_Val`  
 The value to be used to initialize the destination range.  
  
## Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
```  
while ( 0 < count-- )  
   new ( ( void * )&*_First ++ )  
      iterator_traits<ForwardIterator>::value_type( _Val );  
```  
  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Example  
  
```  
// memory_uninit_fill_n.cpp  
// compile with: /EHsc /W3  
#include <memory>  
#include <iostream>  
  
using namespace std;  
  
class Integer {   // No default constructor  
public:  
   Integer( int x ) : val( x ) {}  
   int get( ) { return val; }  
private:  
   int val;  
};  
  
int main() {  
   const int N = 10;  
   Integer val ( 60 );  
   Integer* Array = ( Integer* ) malloc( N * sizeof( int ) );  
   uninitialized_fill_n( Array, N, val );  // C4996  
   int i;  
   cout << "The uninitialized Array contains: ";  
   for ( i = 0 ; i < N; i++ )  
      cout << Array [ i ].get( ) <<  " ";  
}  
```  
  
## Output  
  
```  
The uninitialized Array contains: 60 60 60 60 60 60 60 60 60 60   
```  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std