---
title: "for_each"
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
  - for_each
  - algorithm/std::for_each
  - std::for_each
  - std.for_each
dev_langs: 
  - C++
helpviewer_keywords: 
  - for_each function
  - for_each
ms.assetid: 8cb2ae72-bef6-488b-b011-0475c0787e33
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# for_each
Applies a specified function object to each element in a forward order within a range and returns the function object.  
  
## Syntax  
  
```  
  
   template<class InputIterator, class Function>  
Function for_each(  
   InputIterator _First,   
   InputIterator _Last,   
   Function _Func  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator addressing the position of the first element in the range to be operated on.  
  
 `_Last`  
 An input iterator addressing the position one past the final element in the range operated on.  
  
 `_Func`  
 User-defined function object that is applied to each element in the range.  
  
## Return Value  
 A copy of the function object after it has been applied to all of the elements in the range.  
  
## Remarks  
 The algorithm `for_each` is very flexible, allowing the modification of each element within a range in different, user-specified ways. Templatized functions may be reused in a modified form by passing different parameters. User-defined functions may accumulate information within an internal state that the algorithm may return after processing all of the elements in the range.  
  
 The range referenced must be valid; all pointers must be dereferenceable and, within the sequence, the last position must be reachable from the first by incrementation.  
  
 The complexity is linear with at most (`_Last` – `_First`) comparisons.  
  
## Example  
  
```  
// alg_for_each.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
// The function object multiplies an element by a Factor  
template <class Type>  
class MultValue  
{  
private:  
   Type Factor;   // The value to multiply by  
public:  
   // Constructor initializes the value to multiply by  
   MultValue ( const Type& _Val ) : Factor ( _Val ) {  
   }  
  
   // The function call for the element to be multiplied  
   void operator ( ) ( Type& elem ) const  
   {  
      elem *= Factor;  
   }  
};  
  
// The function object to determine the average  
class Average  
{  
private:  
   long num;      // The number of elements  
   long sum;      // The sum of the elements  
public:  
   // Constructor initializes the value to multiply by  
   Average ( ) : num ( 0 ) , sum ( 0 )  
   {  
   }  
  
   // The function call to process the next elment  
   void operator ( ) ( int elem ) \  
   {  
      num++;      // Increment the element count  
      sum += elem;   // Add the value to the partial sum  
   }  
  
   // return Average  
   operator double ( )  
   {  
      return  static_cast <double> (sum) /  
      static_cast <double> (num);  
   }  
};  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
  
   // Constructing vector v1  
   int i;  
   for ( i = -4 ; i <= 2 ; i++ )  
   {  
      v1.push_back(  i );  
   }  
  
   cout << "Original vector  v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Using for_each to multiply each element by a Factor  
   for_each ( v1.begin ( ) , v1.end ( ) , MultValue<int> ( -2 ) );  
  
   cout << "Multiplying the elements of the vector v1\n "  
        <<  "by the factor -2 gives:\n v1mod1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // The function object is templatized and so can be  
   // used again on the elements with a different Factor  
   for_each (v1.begin ( ) , v1.end ( ) , MultValue<int> (5 ) );  
  
   cout << "Multiplying the elements of the vector v1mod\n "  
        <<  "by the factor 5 gives:\n v1mod2 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // The local state of a function object can accumulate  
   // information about a sequence of actions that the  
   // return value can make available, here the Average  
   double avemod2 = for_each ( v1.begin ( ) , v1.end ( ) ,  
      Average ( ) );  
   cout << "The average of the elements of v1 is:\n Average ( v1mod2 ) = "  
        << avemod2 << "." << endl;  
}  
```  
  
 **Original vector  v1 = ( -4 -3 -2 -1 0 1 2 ).**  
**Multiplying the elements of the vector v1**  
 **by the factor -2 gives:**  
 **v1mod1 = ( 8 6 4 2 0 -2 -4 ).**  
**Multiplying the elements of the vector v1mod**  
 **by the factor 5 gives:**  
 **v1mod2 = ( 40 30 20 10 0 -10 -20 ).**  
**The average of the elements of v1 is:**  
 **Average ( v1mod2 ) = 10.**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [for_each](../vs140/for_each--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)