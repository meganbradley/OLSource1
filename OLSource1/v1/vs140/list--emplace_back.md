---
title: "list::emplace_back"
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
  - "list::emplace_back"
  - "list.emplace_back"
  - "std::list::emplace_back"
  - "emplace_back"
  - "list/std::list::emplace_back"
  - "std.list.emplace_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_back method"
ms.assetid: 8768150a-3d3a-4a6f-8dd6-d381f48ae532
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::emplace_back
Adds an element constructed in place to the beginning of a list.  
  
## Syntax  
  
```  
  
      void emplace_back(  
   Type&& _Val  
);   
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the end of the [list](../vs140/list-class.md).|  
  
## Remarks  
 If an exception is thrown, the `list` is left unaltered and the exception is rethrown.  
  
## Example  
  
```  
// list_emplace_back.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
#include <string>  
  
int main( )   
{  
   using namespace std;  
   list <string> c2;  
   string str("a");  
  
   c2.emplace_back( move( str ) );  
   cout << "Moved first element: " << c2.back( ) << endl;  
}  
```  
  
 **Moved first element: a**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)