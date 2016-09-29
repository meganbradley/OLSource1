---
title: "basic_filebuf::is_open"
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
  - "fstream/std::basic_filebuf::is_open"
  - "is_open"
  - "basic_filebuf::is_open"
  - "std::basic_filebuf::is_open"
  - "basic_filebuf.is_open"
  - "std.basic_filebuf.is_open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_open method"
ms.assetid: a519e35d-fe2f-4aad-a40d-2785becf1ada
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::is_open
Indicates whether a file is open.  
  
## Syntax  
  
```  
bool is_open( ) const;  
```  
  
## Return Value  
 **true** if the file pointer is not a null pointer.  
  
## Example  
  
```  
// basic_filebuf_is_open.cpp  
// compile with: /EHsc  
#include <fstream>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   ifstream file;  
   cout << boolalpha << file.rdbuf( )->is_open( ) << endl;  
  
   file.open( "basic_filebuf_is_open.cpp" );  
   cout << file.rdbuf( )->is_open( ) << endl;  
}  
```  
  
 **false**  
**true**   
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)