---
title: "vector&lt;bool&gt;::operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 97738633-690d-4069-b2d9-8c54104fbfdd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector&lt;bool&gt;::operator
Returns a simulated reference to the `vector<bool>` element at a specified position.  
  
## Syntax  
  
```  
vector<bool>::reference operator[](size_type Pos);  
vector<bool>::const_reference operator[](size_type Pos) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Pos`|The position of the `vector<bool>` element.|  
  
## Return Value  
 A [vector\<bool>::reference](../vs140/vector-bool---reference-class.md) or [vector\<bool>::const_reference](../vs140/vector-bool---const_reference.md) object that contains the value of the indexed element.  
  
 If the position specified is greater than or equal to the size of the container, the result is undefined.  
  
## Remarks  
 If you compile with `_ITERATOR_DEBUG_LEVEL` set, a run-time error occurs if you attempt to access an element outside the bounds of the vector.  For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
 This code example shows the correct use of `vector<bool>::operator[]` and two common coding mistakes, which are commented out. These mistakes cause errors because the address of the `vector<bool>::reference` object that `vector<bool>::operator[]` returns cannot be taken.  
  
```cpp  
  
// cl.exe /EHsc /nologo /W4 /MTd   
#include <vector>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    cout << boolalpha;  
    vector<bool> vb;  
  
    vb.push_back(true);  
    vb.push_back(false);  
  
    //    bool* pb = &vb[1]; // conversion error - do not use  
    //    bool& refb = vb[1];   // conversion error - do not use  
    bool hold = vb[1];  
    cout << "The second element of vb is " << vb[1] << endl;  
    cout << "The held value from the second element of vb is " << hold << endl;  
  
    // Note this doesn't modify hold.  
    vb[1] = true;  
    cout << "The second element of vb is " << vb[1] << endl;  
    cout << "The held value from the second element of vb is " << hold << endl;  
}  
  
```  
  
## Output  
  
```  
The second element of vb is false  
The held value from the second element of vb is false  
The second element of vb is true  
The held value from the second element of vb is false  
```  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector\<bool> Class](../vs140/vector-bool--class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)