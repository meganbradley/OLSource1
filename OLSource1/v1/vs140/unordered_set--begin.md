---
title: "unordered_set::begin"
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
  - "unordered_set::begin"
  - "std::tr1::unordered_set::begin"
  - "std.tr1.unordered_set.begin"
  - "unordered_set.begin"
  - "unordered_set/std::tr1::unordered_set::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method [TR1]"
ms.assetid: 76f8a0ad-fb00-495a-a1f5-80911625f6cc
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::begin
Designates the beginning of the controlled sequence or a bucket.  
  
## Syntax  
  
```  
iterator begin();  
const_iterator begin() const;  
local_iterator begin(size_type nbucket);  
const_local_iterator begin(size_type nbucket) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`nbucket`|The bucket number.|  
  
## Remarks  
 The first two member functions return a forward iterator that points at the first element of the sequence (or just beyond the end of an empty sequence). The last two member functions return a forward iterator that points at the first element of bucket `nbucket` (or just beyond the end of an empty bucket).  
  
## Example  
  
```cpp  
// unordered_set_begin.cpp   
// compile using: cl.exe /EHsc /nologo /W4 /MTd   
#include <unordered_set>   
#include <iostream>   
  
using namespace std;  
  
typedef unordered_set<char> MySet;  
  
int main()   
{   
    MySet c1;   
  
    c1.insert('a');   
    c1.insert('b');   
    c1.insert('c');   
  
    // display contents using range-based for   
    for (auto it : c1) {  
        cout << " [" << it << "]";   
    }  
  
    cout << endl;   
  
    // display contents using explicit for  
    for (MySet::const_iterator it = c1.begin(); it != c1.end(); ++it) {  
        cout << " [" << *it << "]";   
    }  
  
    cout << std::endl;   
  
    // display first two items  
    MySet::iterator it2 = c1.begin();   
    cout << " [" << *it2 << "]";   
    ++it2;   
    cout << " [" << *it2 << "]";   
    cout << endl;   
  
    // display bucket containing 'a'   
    MySet::const_local_iterator lit = c1.begin(c1.bucket('a'));   
    cout << " [" << *lit << "]";   
  
    return (0);   
}  
  
```  
  
  **[a] [b] [c]**   
 **[a] [b] [c]**   
 **[a] [b]**   
 **[a]**    
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::end](../vs140/unordered_set--end.md)