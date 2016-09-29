---
title: "count_if"
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
  - "std.count_if"
  - "count_if"
  - "algorithm/std::count_if"
  - "std::count_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count_if"
  - "count_if function"
ms.assetid: b785887c-83cd-4099-becc-3284dee05295
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# count_if
Returns the number of elements in a range whose values satisfy a specified condition.  
  
## Syntax  
  
```  
  
   template<class InputIterator, class Predicate>  
typename iterator_traits<InputIterator>::difference_type count_if(  
   InputIterator _First,   
   InputIterator _Last,  
   Predicate _Pred  
);  
```  
  
#### Parameters  
 `_First`  
 An input iterator addressing the position of the first element in the range to be searched.  
  
 `_Last`  
 An input iterator addressing the position one past the final element in the range to be searched.  
  
 `_Pred`  
 User-defined predicate function object that defines the condition to be satisfied if an element is to be counted. A predicate takes single argument and returns **true** or **false**.  
  
## Return Value  
 The number of elements that satisfy the condition specified by the predicate.  
  
## Remarks  
 This template function is a generalization of the algorithm [count](../vs140/count.md), replacing the predicate "equals a specific value" with any predicate.  
  
## Example  
  
```  
// alg_count_if.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
bool greater10(int value)  
{  
    return value >10;  
}  
  
int main()  
{  
    using namespace std;  
    vector<int> v1;  
    vector<int>::iterator Iter;  
  
    v1.push_back(10);  
    v1.push_back(20);  
    v1.push_back(10);  
    v1.push_back(40);  
    v1.push_back(10);  
  
    cout << "v1 = ( ";  
    for (Iter = v1.begin(); Iter != v1.end(); Iter++)  
        cout << *Iter << " ";  
    cout << ")" << endl;  
  
    vector<int>::iterator::difference_type result1;  
    result1 = count_if(v1.begin(), v1.end(), greater10);  
    cout << "The number of elements in v1 greater than 10 is: "  
         << result1 << "." << endl;  
}  
```  
  
 **v1 = ( 10 20 10 40 10 )**  
**The number of elements in v1 greater than 10 is: 2.**   
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [count_if](../vs140/count_if--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)