---
title: "exchange Function"
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
ms.assetid: 631caa8b-5401-441b-8ebd-244e675834c6
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exchange Function
**(C++14)** Assigns a new value to an object and returns its old value.  
  
## Syntax  
  
```cpp  
template<class T, class Other = T>  
T exchange(T& val, Other&& new_val)  
```  
  
#### Parameters  
 `val`  
 The object that will receive the value of new_val.  
  
 `new_val`  
 The object whose value is copied or moved into val.  
  
## Return Value  
 Returns the original value of the left hand argument before the function was called.  
  
## Remarks  
 For complex types, `exchange` avoids copying the old value when a move constructor is available, avoids copying the new value if it’s a temporary object or is moved, and accepts any type as the new value, using any available converting assignment operator. The exchange function is different from [std::swap](../vs140/swap.md) in that the left argument is not moved or copied to the right argument.  
  
## Example  
 The following example shows how to use `exchange`. In the real world, `exchange` is most useful with large objects that are expensive to copy:  
  
```  
#include <utility>  
#include <iostream>  
  
using namespace std;  
  
struct C  
{  
int i;  
//...  
};  
int main()  
{     
// Use brace initialization   
C c1{ 1 };  
C c2{ 2 };  
C result = exchange(c1, c2);  
cout << "The old value of c1 is: " << result.i << endl;  
cout << "The new value of c1 after exchange is: " << c1.i << endl;  
  
return 0;  
}  
/* Output:  
The old value of c1 is: 1  
The new value of c1 after exchange is: 2  
*/  
```  
  
## Requirements  
 Header: \<utility>  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)