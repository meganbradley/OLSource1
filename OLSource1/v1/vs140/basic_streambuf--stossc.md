---
title: "basic_streambuf::stossc"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - stossc
  - basic_streambuf.stossc
  - std.basic_streambuf.stossc
  - basic_streambuf::stossc
  - std::basic_streambuf::stossc
  - streambuf/std::basic_streambuf::stossc
dev_langs: 
  - C++
helpviewer_keywords: 
  - stossc method
ms.assetid: c8d8e16b-668c-49d4-90fb-9fe32f400887
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_streambuf::stossc
Move past the current element in the stream.  
  
## Syntax  
  
```  
  
void stossc( );  
  
```  
  
## Remarks  
 The member function calls [sbumpc](../vs140/basic_streambuf--sbumpc.md). Note that an implementation is not required to supply this member function.  
  
## Example  
  
```  
// basic_streambuf_stossc.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )   
{  
   using namespace std;  
   ifstream myfile( "basic_streambuf_stossc.txt", ios::in );  
  
   myfile.rdbuf( )->stossc( );  
   char i = myfile.rdbuf( )->sgetc( );  
   cout << i << endl;  
}  
```  
  
## Input: basic_streambuf_stossc.txt  
  
```  
testing  
```  
  
### Output  
  
```  
e  
```  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)