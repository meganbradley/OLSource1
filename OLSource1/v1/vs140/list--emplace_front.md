---
title: "list::emplace_front"
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
  - "list.emplace_front"
  - "list::emplace_front"
  - "std.list.emplace_front"
  - "emplace_front"
  - "std::list::emplace_front"
  - "list/std::list::emplace_front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_front method"
ms.assetid: a1684be9-b564-49ab-9b2d-38a0d56f4247
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::emplace_front
Adds an element constructed in place to the beginning of a list.  
  
## Syntax  
  
```  
  
      void emplace_front(  
   Type&& _Val  
);   
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the beginning of the [list](../vs140/list-class.md).|  
  
## Remarks  
 If an exception is thrown, the `list` is left unaltered and the exception is rethrown.  
  
## Example  
  
```  
// list_emplace_front.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
#include <string>  
  
int main( )   
{  
   using namespace std;  
   list <string> c2;  
   string str("a");  
  
   c2.emplace_front( move( str ) );  
   cout << "Moved first element: " << c2.front( ) << endl;  
}  
```  
  
 **Moved first element: a**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)