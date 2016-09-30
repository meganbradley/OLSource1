---
title: "partial_sort_copy"
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
  - "std.partial_sort_copy"
  - "algorithm/std::partial_sort_copy"
  - "std::partial_sort_copy"
  - "partial_sort_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partial_sort_copy function"
  - "partial_sort_copy"
ms.assetid: cf137213-7eb6-4109-a94b-3b3d572e19ce
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial_sort_copy
Copies elements from a source range into a destination range where the source elements are ordered by either less than or another specified binary predicate.  
  
## Syntax  
  
```  
  
      template<class InputIterator, class RandomAccessIterator>  
   RandomAccessIterator partial_sort_copy(  
      InputIterator _First1,   
      InputIterator _Last1,  
      RandomAccessIterator _First2,   
      RandomAccessIterator _Last2  
   );  
template<class InputIterator, class RandomAccessIterator, class BinaryPredicate>  
   RandomAccessIterator partial_sort_copy(  
      InputIterator _First1,   
      InputIterator _Last1,  
      RandomAccessIterator _First2,   
      RandomAccessIterator _Last2,  
      BinaryPredicate _Comp  
   );  
```  
  
#### Parameters  
 `_First1`  
 An input iterator addressing the position of the first element in the source range.  
  
 `_Last1`  
 An input iterator addressing the position one past the final element in the source range.  
  
 `_First2`  
 A random-access iterator addressing the position of the first element in the sorted destination range.  
  
 `_Last2`  
 A random-access iterator addressing the position one past the final element in the sorted destination range.  
  
 `_Comp`  
 User-defined predicate function object that defines the condition to be satisfied if two elements are to be taken as equivalent. A binary predicate takes two arguments and returns `true` when satisfied and `false` when not satisfied.  
  
## Return Value  
 A random-access iterator addressing the element in the destination range one position beyond the last element inserted from the source range.  
  
## Remarks  
 The source and destination ranges must not overlap and must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation.  
  
 The binary predicate must provide a strict weak ordering so that elements that are not equivalent are ordered, but elements that are equivalent are not. Two elements are equivalent under less than, but not necessarily equal, if neither is less than the other.  
  
## Example  
  
```  
// alg_partial_sort_copy.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <algorithm>  
#include <functional>  
#include <iostream>  
  
int main() {  
    using namespace std;  
    vector<int> v1, v2;  
    list<int> list1;  
    vector<int>::iterator iter1, iter2;  
    list<int>::iterator list1_Iter, list1_inIter;  
  
    int i;  
    for (i = 0; i <= 9; i++)  
        v1.push_back(i);  
  
    random_shuffle(v1.begin(), v1.end());  
  
    list1.push_back(60);  
    list1.push_back(50);  
    list1.push_back(20);  
    list1.push_back(30);  
    list1.push_back(40);  
    list1.push_back(10);  
  
    cout << "Vector v1 = ( " ;  
    for (iter1 = v1.begin(); iter1 != v1.end(); iter1++)  
        cout << *iter1 << " ";  
    cout << ")" << endl;  
  
    cout << "List list1 = ( " ;  
    for (list1_Iter = list1.begin();  
         list1_Iter!= list1.end();  
         list1_Iter++)  
        cout << *list1_Iter << " ";  
    cout << ")" << endl;  
  
    // Copying a partially sorted copy of list1 into v1  
    vector<int>::iterator result1;  
    result1 = partial_sort_copy(list1.begin(), list1.end(),  
             v1.begin(), v1.begin() + 3);  
  
    cout << "List list1 Vector v1 = ( " ;  
    for (iter1 = v1.begin() ; iter1 != v1.end() ; iter1++)  
        cout << *iter1 << " ";  
    cout << ")" << endl;  
    cout << "The first v1 element one position beyond"  
         << "\n the last L 1 element inserted was " << *result1  
         << "." << endl;  
  
    // Copying a partially sorted copy of list1 into v2  
    int ii;  
    for (ii = 0; ii <= 9; ii++)  
        v2.push_back(ii);  
  
    random_shuffle(v2.begin(), v2.end());  
    vector<int>::iterator result2;  
    result2 = partial_sort_copy(list1.begin(), list1.end(),  
             v2.begin(), v2.begin() + 6);  
  
    cout << "List list1 into Vector v2 = ( " ;  
    for (iter2 = v2.begin() ; iter2 != v2.end(); iter2++)  
        cout << *iter2 << " ";  
    cout << ")" << endl;  
    cout << "The first v2 element one position beyond"  
         << "\n the last L 1 element inserted was " << *result2  
         << "." << endl;  
}  
```  
  
## Sample Output  
  
```  
Vector v1 = ( 8 1 9 2 0 5 7 3 4 6 )  
List list1 = ( 60 50 20 30 40 10 )  
List list1 Vector v1 = ( 10 20 30 2 0 5 7 3 4 6 )  
The first v1 element one position beyond  
 the last L 1 element inserted was 2.  
List list1 into Vector v2 = ( 10 20 30 40 50 60 1 8 5 2 )  
The first v2 element one position beyond  
 the last L 1 element inserted was 1.  
```  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [partial_sort_copy](../vs140/partial_sort_copy--stl-samples-.md)   
 [Predicate Version of partial_sort_copy](../vs140/predicate-version-of-partial_sort_copy.md)   
 [Standard Template Library](../vs140/standard-template-library.md)