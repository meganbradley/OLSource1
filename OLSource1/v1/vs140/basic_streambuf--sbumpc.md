---
title: "basic_streambuf::sbumpc"
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
  - "basic_streambuf.sbumpc"
  - "sbumpc"
  - "streambuf/std::basic_streambuf::sbumpc"
  - "std::basic_streambuf::sbumpc"
  - "std.basic_streambuf.sbumpc"
  - "basic_streambuf::sbumpc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sbumpc method"
ms.assetid: 98de7e35-5136-42d8-98ea-89422c1373d5
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sbumpc
Reads and returns the current element, moving the stream pointer.  
  
## Syntax  
  
```  
  
int  
_  
type sbumpc( );  
  
```  
  
## Return Value  
 The current element.  
  
## Remarks  
 If a read position is available, the member function returns **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)( **\***[gptr](../vs140/basic_streambuf--gptr.md)) and increments the next pointer for the input buffer. Otherwise, it returns [uflow](../vs140/basic_streambuf--uflow.md).  
  
## Example  
  
```  
// basic_streambuf_sbumpc.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   int i = 0;  
   i = cin.rdbuf( )->sbumpc( );  
   cout << i << endl;  
}  
```  
  
  **`3` `3`3**  
**51**   
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)