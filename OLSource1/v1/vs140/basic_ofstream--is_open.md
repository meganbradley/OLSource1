---
title: "basic_ofstream::is_open"
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
  - "std.basic_ofstream.is_open"
  - "basic_ofstream.is_open"
  - "basic_ofstream::is_open"
  - "is_open"
  - "fstream/std::basic_ofstream::is_open"
  - "std::basic_ofstream::is_open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_open method"
ms.assetid: 3b181f0b-b286-419a-b3bd-35528b5ff458
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ofstream::is_open
Indicates whether a file is open.  
  
## Syntax  
  
```  
bool is_open( ) const;  
```  
  
## Return Value  
 `true` if the file is open, `false` otherwise.  
  
## Remarks  
 The member function returns [rdbuf](../vs140/basic_ofstream--rdbuf.md) **->** [is_open](../vs140/basic_filebuf--is_open.md).  
  
## Example  
  
```  
// basic_ofstream_is_open.cpp  
// compile with: /EHsc  
#include <fstream>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   ifstream file;  
   // Open and close with a basic_filebuf  
   file.rdbuf( )->open( "basic_ofstream_is_open.txt", ios::in );  
   file.close( );  
   if (file.is_open())  
      cout << "it's open" << endl;  
   else  
      cout << "it's closed" << endl;  
}  
```  
  
## Output  
  
```  
it's closed  
```  
  
## Requirements  
 **Header:** <fstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)