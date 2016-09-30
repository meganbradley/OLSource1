---
title: "strstreambuf::pcount"
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
  - "std::strstreambuf::pcount"
  - "pcount"
  - "strstreambuf.pcount"
  - "strstreambuf::pcount"
  - "std.strstreambuf.pcount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pcount method"
ms.assetid: ee8b44ed-f71e-4afa-8ab5-da2aea2e08a5
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::pcount
Returns a count of the number of elements written to the controlled sequence.  
  
## Syntax  
  
```  
streamsize pcount( ) const;  
```  
  
## Return Value  
 A count of the number of elements written to the controlled sequence.  
  
## Remarks  
 Specifically, if [pptr](../vs140/basic_streambuf--pptr.md) is a null pointer, the function returns zero. Otherwise, it returns `pptr` – [pbase](../vs140/basic_streambuf--pbase.md).  
  
## Example  
  
```  
// strstreambuf_pcount.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <strstream>  
using namespace std;  
  
int main( )  
{  
   strstream x;  
   x << "test1";  
   cout << x.rdbuf( )->pcount( ) << endl;  
   x << "test2";  
   cout << x.rdbuf( )->pcount( ) << endl;  
}  
```  
  
## Output  
  
```  
5  
10  
```  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)