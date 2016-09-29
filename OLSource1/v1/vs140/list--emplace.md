---
title: "list::emplace"
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
  - "list/std::list::emplace"
  - "list::emplace"
  - "std.list.emplace"
  - "list.emplace"
  - "emplace"
  - "std::list::emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 26648a45-6402-4299-9682-516ebd089b44
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::emplace
Inserts an element constructed in place into a list at a specified position.  
  
## Syntax  
  
```  
  
      void emplace_back(  
   iterator _Where,  
   Type&& _Val  
);   
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Where`|The position in the target [list](../vs140/list-class.md) where the first element is inserted.|  
|`_Val`|The element added to the end of the `list`.|  
  
## Remarks  
 If an exception is thrown, the `list` is left unaltered and the exception is rethrown.  
  
## Example  
  
```  
// list_emplace.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
#include <string>  
  
int main( )   
{  
   using namespace std;  
   list <string> c2;  
   string str("a");  
  
   c2.emplace(c2.begin(), move( str ) );  
   cout << "Moved first element: " << c2.back( ) << endl;  
}  
```  
  
 **Moved first element: a**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)