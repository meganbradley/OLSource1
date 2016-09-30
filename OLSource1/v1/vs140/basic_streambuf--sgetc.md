---
title: "basic_streambuf::sgetc"
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
  - "basic_streambuf.sgetc"
  - "basic_streambuf::sgetc"
  - "std.basic_streambuf.sgetc"
  - "streambuf/std::basic_streambuf::sgetc"
  - "sgetc"
  - "std::basic_streambuf::sgetc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sgetc method"
ms.assetid: 237e90fc-f00f-442c-953d-addece0aa0e4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sgetc
Returns current element without changing position in the stream.  
  
## Syntax  
  
```  
  
int  
_  
type sgetc( );  
  
```  
  
## Return Value  
 The current element.  
  
## Remarks  
 If a read position is available, the member function returns **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(`*`[gptr](../vs140/basic_streambuf--gptr.md)). Otherwise, it returns [underflow](../vs140/basic_streambuf--underflow.md).  
  
## Example  
  
```  
// basic_streambuf_sgetc.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )   
{  
   using namespace std;  
   ifstream myfile( "basic_streambuf_sgetc.txt", ios::in );  
  
   char i = myfile.rdbuf( )->sgetc( );  
   cout << i << endl;  
   i = myfile.rdbuf( )->sgetc( );  
   cout << i << endl;  
}  
```  
  
## Input: basic_streambuf_sgetc.txt  
  
```  
testing  
```  
  
### Output  
  
```  
t  
t  
```  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)