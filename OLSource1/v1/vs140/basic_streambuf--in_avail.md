---
title: "basic_streambuf::in_avail"
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
  - "std.basic_streambuf.in_avail"
  - "streambuf/std::basic_streambuf::in_avail"
  - "std::basic_streambuf::in_avail"
  - "basic_streambuf.in_avail"
  - "in_avail"
  - "basic_streambuf::in_avail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "in_avail method"
ms.assetid: 7147caf5-f36d-46d4-a48f-1dc147c93ab9
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::in_avail
Returns the number of elements that are ready to be read from the buffer.  
  
## Syntax  
  
```  
  
streamsize in  
_  
avail( );  
  
```  
  
## Return Value  
 The number of elements that are ready to be read from the buffer.  
  
## Remarks  
 If a [read position](../vs140/basic_streambuf-class.md) is available, the member function returns [egptr](../vs140/basic_streambuf--egptr.md) – [gptr](../vs140/basic_streambuf--gptr.md). Otherwise, it returns [showmanyc](../vs140/basic_streambuf--showmanyc.md).  
  
## Example  
  
```  
// basic_streambuf_in_avail.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   char c;  
   // cin's buffer is empty, in_avail will return 0  
   cout << cin.rdbuf( )->in_avail( ) << endl;  
   cin >> c;  
   cout << cin.rdbuf( )->in_avail( ) << endl;  
}  
```  
  
## Input  
  
```  
4  
```  
  
## Sample Output  
  
```  
0  
4  
1  
```  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)