---
title: "set::max_size"
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
  - "std.set.max_size"
  - "std::set::max_size"
  - "max_size"
  - "set.max_size"
  - "set::max_size"
  - "set/std::set::max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: 5c496232-4aac-4843-9a36-6a54bf811201
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# set::max_size
Returns the maximum length of the set.  
  
## Syntax  
  
```  
  
size_type max_size( ) const;  
  
```  
  
## Return Value  
 The maximum possible length of the set.  
  
## Example  
  
```  
// set_max_size.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   set <int> s1;  
   set <int>::size_type i;  
  
   i = s1.max_size( );     
   cout << "The maximum possible length "  
        << "of the set is " << i << "." << endl;  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The maximum possible length of the set is 1073741823.  
```  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::max_size](../vs140/set--max_size--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)