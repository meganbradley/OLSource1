---
title: "list::clear"
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
  - "clear"
  - "std.list.clear"
  - "list::clear"
  - "std::list::clear"
  - "list.clear"
  - "Clear"
  - "list/std::list::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: acf7fab4-b895-4f23-9f3a-25147d680432
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::clear
Erases all the elements of a list.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Example  
  
```  
// list_clear.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   list <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
  
   cout << "The size of the list is initially " << c1.size( ) << endl;  
   c1.clear( );  
   cout << "The size of list after clearing is " << c1.size( ) << endl;  
}  
```  
  
 **The size of the list is initially 3**  
**The size of list after clearing is 0**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)