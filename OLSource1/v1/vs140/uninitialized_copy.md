---
title: "uninitialized_copy"
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
  - "uninitialized_copy"
  - "memory/std::uninitialized_copy"
  - "std.uninitialized_copy"
  - "std::uninitialized_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uninitialized_copy"
  - "uninitialized_copy function"
ms.assetid: 23a09cb8-4116-475e-b0bb-5d3e7daca5aa
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uninitialized_copy
Copies objects from a specified source range into an uninitialized destination range.  
  
## Syntax  
  
```  
  
   template<class InputIterator, class ForwardIterator>  
ForwardIterator uninitialized_copy(  
   InputIterator _First,   
   InputIterator _Last,  
   ForwardIterator _Dest  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator addressing the first element in the source range.  
  
 `_Last`  
 An input iterator addressing the last element in the source range.  
  
 `_Dest`  
 A forward iterator addressing the first element in the destination range.  
  
## Return Value  
 A forward iterator addressing the first position beyond the destination range, unless the source range was empty and iterator addresses *_First.*  
  
## Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
```  
while ( _First!= _Last )  
   new ( ( void * )&*_Dest ++)  
      iterator_traits<InputIterator>::value_type ( *_First ++ );  
return _First;  
```  
  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Example  
  
```  
// memory_uninit_copy.cpp  
// compile with: /EHsc /W3  
#include <memory>  
#include <iostream>  
  
using namespace std;  
  
   class Integer   
   {  
   public:  
      Integer( int x ) : val( x ) {}  
      int get( ) { return val; }  
   private:  
      int val;  
   };  
  
int main( )  
{  
   int Array[] = { 10, 20, 30, 40 };  
   const int N = sizeof( Array ) / sizeof( int );  
  
   int i;  
   cout << "The initialized Array contains " << N << " elements: ";  
      for (i = 0 ; i < N; i++ )  
      {  
         cout << " " << Array [ i ];  
      }  
   cout << endl;  
  
   Integer* ArrayPtr = ( Integer* ) malloc( N * sizeof( int ) );  
   Integer* LArrayPtr = uninitialized_copy(  
      Array, Array + N, ArrayPtr);  // C4996  
  
   cout << "Address of position after the last element in the array is: "   
        << &Array[0] + N << endl;  
   cout << "The iterator returned by uninitialized_copy addresses: "   
        << ( void* )LArrayPtr << endl;  
   cout << "The address just beyond the last copied element is: "   
        << ( void* )( ArrayPtr + N ) << endl;  
  
   if ( ( &Array[0] + N ) == ( void* )LArrayPtr )  
      cout << "The return value is an iterator "  
           << "pointing just beyond the original array." << endl;  
   else  
      cout << "The return value is an iterator "  
           << "not pointing just beyond the original array." << endl;  
  
   if ( ( void* )LArrayPtr == ( void* )( ArrayPtr + N ) )  
      cout << "The return value is an iterator "  
           << "pointing just beyond the copied array." << endl;  
   else  
      cout << "The return value is an iterator "  
           << "not pointing just beyond the copied array." << endl;  
  
   free ( ArrayPtr );  
  
   cout << "Note that the exact addresses returned will vary\n"  
        << "with the memory allocation in individual computers."  
        << endl;  
}  
```  
  
## Example Output  
  
```  
The initialized Array contains 4 elements: 10 20 30 40  
Address of position after the last element in the array is: 0012FED8  
The iterator returned by uninitialized_copy addresses: 00311B88  
The address just beyond the last copied element is: 00311B88  
The return value is an iterator not pointing just beyond the original array.  
The return value is an iterator pointing just beyond the copied array.  
Note that the exact addresses returned will vary  
with  the memory allocation in individual computers.  
```  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std