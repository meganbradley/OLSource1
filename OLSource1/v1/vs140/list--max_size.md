---
title: "list::max_size"
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
  - "list.max_size"
  - "max_size"
  - "std::list::max_size"
  - "list/std::list::max_size"
  - "std.list.max_size"
  - "list::max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: dd9a64bf-60ce-4913-9f8e-82bcb1f3bf56
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::max_size
Returns the maximum length of a list.  
  
## Syntax  
  
```unstlib  
  
size  
_  
type max  
_  
size( ) const;  
  
```  
  
## Return Value  
 The maximum possible length of the list.  
  
## Example  
  
```  
// list_max_size.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
   list <int>::size_type i;  
  
   i = c1.max_size( );  
   cout << "Maximum possible length of the list is " << i << "." << endl;  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
Maximum possible length of the list is 1073741823.  
```  
  
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)