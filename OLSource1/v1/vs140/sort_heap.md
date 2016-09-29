---
title: "sort_heap"
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
  - "sort_heap"
  - "std::sort_heap"
  - "algorithm/std::sort_heap"
  - "std.sort_heap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sort_heap"
  - "sort_heap function"
ms.assetid: 4a16b2ef-a1b4-4c80-823b-3e4bf06b2481
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sort_heap
Converts a heap into a sorted range.  
  
## Syntax  
  
```  
template<class RandomAccessIterator>  
   void sort_heap(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Last  
   );  
template<class RandomAccessIterator, class Predicate>  
   void sort_heap(  
      RandomAccessIterator _First,   
      RandomAccessIterator _Last,  
      Predicate _Comp  
   );  
```  
  
#### Parameters  
 `_First`  
 A random-access iterator addressing the position of the first element in the target heap.  
  
 `_Last`  
 A random-access iterator addressing the position one past the final element in the target heap.  
  
 `_Comp`  
 User-defined predicate function object that defines sense in which one element is less than another. A binary predicate takes two arguments and returns **true** when satisfied and **false** when not satisfied.  
  
## Remarks  
 Heaps have two properties:  
  
-   The first element is always the largest.  
  
-   Elements may be added or removed in logarithmic time.  
  
 After the application if this algorithm, the range it was applied to is no longer a heap.  
  
 This is not a stable sort because the relative order of equivalent elements is not necessarily preserved.  
  
 Heaps are an ideal way to implement priority queues and they are used in the implementation of the Standard Template Library container adaptor [priority_queue Class](../vs140/priority_queue-class.md).  
  
 The range referenced must be valid; all pointers must be dereferenceable and within the sequence the last position is reachable from the first by incrementation.  
  
 The complexity is at most *N* log *N*, where *N* = (*_Last – _First*).  
  
## Example  
  
```  
// alg_sort_heap.cpp  
// compile with: /EHsc  
#include <algorithm>  
#include <functional>  
#include <iostream>  
#include <ostream>  
#include <string>  
#include <vector>  
using namespace std;  
  
void print(const string& s, const vector<int>& v) {  
    cout << s << ": ( ";  
  
    for (auto i = v.begin(); i != v.end(); ++i) {  
        cout << *i << " ";  
    }  
  
    cout << ")" << endl;  
}  
  
int main() {  
    vector<int> v;  
    for (int i = 1; i <= 9; ++i) {  
        v.push_back(i);  
    }  
    print("Initially", v);  
  
    random_shuffle(v.begin(), v.end());  
    print("After random_shuffle", v);  
  
    make_heap(v.begin(), v.end());  
    print("     After make_heap", v);  
  
    sort_heap(v.begin(), v.end());  
    print("     After sort_heap", v);  
  
    random_shuffle(v.begin(), v.end());  
    print("             After random_shuffle", v);  
  
    make_heap(v.begin(), v.end(), greater<int>());  
    print("After make_heap with greater<int>", v);  
  
    sort_heap(v.begin(), v.end(), greater<int>());  
    print("After sort_heap with greater<int>", v);  
}  
```  
  
## Sample Output  
  
```  
Initially: ( 1 2 3 4 5 6 7 8 9 )  
After random_shuffle: ( 9 2 7 3 1 6 8 4 5 )  
     After make_heap: ( 9 5 8 4 1 6 7 2 3 )  
     After sort_heap: ( 1 2 3 4 5 6 7 8 9 )  
             After random_shuffle: ( 5 8 3 1 2 9 7 6 4 )  
After make_heap with greater<int>: ( 1 2 3 4 5 9 7 6 8 )  
After sort_heap with greater<int>: ( 9 8 7 6 5 4 3 2 1 )  
```  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [heap](../vs140/heap.md)   
 [Standard Template Library](../vs140/standard-template-library.md)