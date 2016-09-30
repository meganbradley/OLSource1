---
title: "nth_element"
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
  - "algorithm/std::nth_element"
  - "std.nth_element"
  - "nth_element"
  - "std::nth_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nth_element function"
  - "nth_element"
ms.assetid: eda88e94-8840-4568-a83b-d03deeda9cf6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nth_element
Partitions a range of elements, correctly locating the *n*th element of the sequence in the range so that all the elements in front of it are less than or equal to it and all the elements that follow it in the sequence are greater than or equal to it.  
  
## Syntax  
  
```  
  
      template<class RandomAccessIterator>  
   void nth_element(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Nth,   
      RandomAccessIterator _Last  
   );  
template<class RandomAccessIterator, class BinaryPredicate>  
   void nth_element(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Nth,   
      RandomAccessIterator _Last,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A random-access iterator addressing the position of the first element in the range to be partitioned.  
  
 *_Nth*  
 A random-access iterator addressing the position of element to be correctly ordered on the boundary of the partition.  
  
 `_Last`  
 A random-access iterator addressing the position one past the final element in the range to be partitioned.  
  
 `_Comp`  
 User-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The `nth_element` algorithm does not guarantee that elements in the sub-ranges either side of the *n*th element are sorted. It thus makes fewer guarantees than `partial_sort`, which orders the elements in the range below some chosen element, and may be used as a faster alternative to `partial_sort` when the ordering of the lower range is not required.  
  
 Elements are equivalent, but not necessarily equal, if neither is less than the other.  
  
 The average of a sort complexity is linear with respect to *_Last – _First*.  
  
## Example  
  
```  
// alg_nth_elem.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>      // For greater<int>( )  
#include <iostream>  
  
// Return whether first element is greater than the second  
bool UDgreater ( int elem1, int elem2 ) {  
   return elem1 > elem2;  
}  
  
int main() {  
   using namespace std;  
   vector <int> v1;  
   vector <int>::iterator Iter1;  
  
   int i;  
   for ( i = 0 ; i <= 5 ; i++ )  
      v1.push_back( 3 * i );  
  
   int ii;  
   for ( ii = 0 ; ii <= 5 ; ii++ )  
      v1.push_back( 3 * ii + 1 );  
  
   int iii;  
   for ( iii = 0 ; iii <= 5 ; iii++ )  
      v1.push_back( 3 * iii +2 );  
  
   cout << "Original vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   nth_element(v1.begin( ), v1.begin( ) + 3, v1.end( ) );  
   cout << "Position 3 partitioned vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // To sort in descending order, specify binary predicate  
   nth_element( v1.begin( ), v1.begin( ) + 4, v1.end( ),  
          greater<int>( ) );  
   cout << "Position 4 partitioned (greater) vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   random_shuffle( v1.begin( ), v1.end( ) );  
   cout << "Shuffled vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
  
   // A user-defined (UD) binary predicate can also be used  
   nth_element( v1.begin( ), v1.begin( ) + 5, v1.end( ), UDgreater );  
   cout << "Position 5 partitioned (UDgreater) vector:\n v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")" << endl;  
}  
```  
  
## Sample Output  
  
```  
Original vector:  
 v1 = ( 0 3 6 9 12 15 1 4 7 10 13 16 2 5 8 11 14 17 )  
Position 3 partitioned vector:  
 v1 = ( 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 )  
Position 4 partitioned (greater) vector:  
 v1 = ( 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1 0 )  
Shuffled vector:  
 v1 = ( 5 16 8 15 17 6 10 0 13 2 9 12 3 4 7 1 11 14 )  
Position 5 partitioned (UDgreater) vector:  
 v1 = ( 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1 0 )  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [nth_element](../vs140/nth_element--stl-samples-.md)   
 [Predicate Version of nth_element](../vs140/predicate-version-of-nth_element.md)   
 [Standard Template Library](../vs140/standard-template-library.md)