---
title: "not1 Function"
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
  - "std.not1"
  - "std::not1"
  - "not1"
  - "xfunctional/std::not1"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not1 function"
  - "not1"
ms.assetid: 81933163-806a-4c36-938b-4c95c327473f
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# not1 Function
Returns the complement of a unary predicate.  
  
## Syntax  
  
```  
template<class UnaryPredicate>  
   unary_negate<UnaryPredicate> not1(  
      const UnaryPredicate& _Pred  
   );  
```  
  
#### Parameters  
 `_Pred`  
 The unary predicate to be negated.  
  
## Return Value  
 A unary predicate that is the negation of the unary predicate modified.  
  
## Remarks  
 If a `unary_negate` is constructed from a unary predicate **Pred**(*x*), then it returns **! Pred**(*x*).  
  
## Example  
  
```  
// functional_not1.cpp  
// compile with: /EHsc  
#include <vector>  
#include <functional>  
#include <algorithm>  
#include <iostream>  
  
using namespace std;  
  
int main()  
{  
    vector<int> v1;  
    vector<int>::iterator Iter;  
  
    int i;  
    for (i = 0; i <= 7; i++)  
    {  
        v1.push_back(5 * i);  
    }  
  
    cout << "The vector v1 = ( ";  
    for (Iter = v1.begin(); Iter != v1.end(); Iter++)  
        cout << *Iter << " ";  
    cout << ")" << endl;  
  
    vector<int>::iterator::difference_type result1;  
    // Count the elements greater than 10  
    result1 = count_if(v1.begin(), v1.end(), bind2nd(greater<int>(), 10));  
    cout << "The number of elements in v1 greater than 10 is: "  
         << result1 << "." << endl;  
  
    vector<int>::iterator::difference_type result2;  
    // Use the negator to count the elements less than or equal to 10  
    result2 = count_if(v1.begin(), v1.end(),  
        not1(bind2nd(greater<int>(), 10)));  
  
    cout << "The number of elements in v1 not greater than 10 is: "  
         << result2 << "." << endl;  
}  
```  
  
 **The vector v1 = ( 0 5 10 15 20 25 30 35 )**  
**The number of elements in v1 greater than 10 is: 5.**  
**The number of elements in v1 not greater than 10 is: 3.**   
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)