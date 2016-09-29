---
title: "vector::begin"
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
  - "vector.begin"
  - "vector::begin"
  - "std.vector.begin"
  - "std::vector::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: 5ab4af74-ab67-41f0-93dc-716a1d23e8cc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::begin
Returns a random-access iterator to the first element in the vector.  
  
## Syntax  
  
```  
const_iterator begin() const;  
iterator begin();  
```  
  
## Return Value  
 A random-access iterator addressing the first element in the `vector` or to the location succeeding an empty `vector`. You should always compare the value returned with [vector::end](../vs140/vector--end.md) to ensure it is valid.  
  
## Remarks  
 If the return value of `begin` is assigned to a [vector::const_iterator](../vs140/vector--const_iterator.md), the `vector` object cannot be modified. If the return value of `begin` is assigned to an [vector::iterator](../vs140/vector--iterator.md), the `vector` object can be modified.  
  
## Example  
  
```  
// vector_begin.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    vector<int> c1;  
    vector<int>::iterator c1_Iter;  
    vector<int>::const_iterator c1_cIter;  
  
    c1.push_back(1);  
    c1.push_back(2);  
  
    cout << "The vector c1 contains elements:";  
    c1_Iter = c1.begin();  
    for (; c1_Iter != c1.end(); c1_Iter++)  
    {  
        cout << " " << *c1_Iter;  
    }  
    cout << endl;  
  
    cout << "The vector c1 now contains elements:";  
    c1_Iter = c1.begin();  
    *c1_Iter = 20;  
    for (; c1_Iter != c1.end(); c1_Iter++)  
    {  
        cout << " " << *c1_Iter;  
    }  
    cout << endl;  
  
    // The following line would be an error because iterator is const  
    // *c1_cIter = 200;  
}  
```  
  
 **The vector c1 contains elements: 1 2**  
**The vector c1 now contains elements: 20 2**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)