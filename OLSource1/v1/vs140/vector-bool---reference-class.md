---
title: "vector&lt;bool&gt;::reference Class"
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
  - vector<bool>::reference
  - std::vector<bool>::reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - vector<bool> reference class
ms.assetid: f27854f9-0ef0-4e7e-ad2e-cd53b6cb3334
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector&lt;bool&gt;::reference Class
The `vector<bool>::reference` class is a proxy class provided by the [vector<bool\> Class](../vs140/vector-bool--class.md) to simulate `bool&`.  
  
## Remarks  
 A simulated reference is required because C++ does not natively allow direct references to bits. `vector<bool>` uses only one bit per element, which can be referenced by using this proxy class. However, the reference simulation is not complete because certain assignments are not valid. For example, because the address of the `vector<bool>::reference` object cannot be taken, the following code that uses [vector<bool\>::operator&#91;&#93;](../vs140/vector-bool---operator.md) is not correct:  
  
```cpp  
    vector<bool> vb;  
...  
    bool* pb = &vb[1]; // conversion error - do not use  
    bool& refb = vb[1];   // conversion error - do not use  
```  
  
### Member Functions  
  
|||  
|-|-|  
|[flip](../vs140/vector-bool---reference--flip.md)|Inverts the Boolean value of a vector element.|  
|[operator bool](../vs140/vector-bool---reference--operator-bool.md)|Provides an implicit conversion from `vector<bool>::reference` to `bool`.|  
|[operator=](../vs140/vector-bool---reference--operator=.md)|Assigns a Boolean value to a bit, or the value held by a referenced element to a bit.|  
  
## Requirements  
 **Header**: <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [<vector\>](../vs140/-vector-.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)