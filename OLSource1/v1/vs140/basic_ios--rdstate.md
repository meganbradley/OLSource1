---
title: "basic_ios::rdstate"
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
  - "std.basic_ios.rdstate"
  - "ios/std::basic_ios::rdstate"
  - "std::basic_ios::rdstate"
  - "basic_ios.rdstate"
  - "rdstate"
  - "basic_ios::rdstate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rdstate method"
ms.assetid: e235e4e2-7e95-4777-a160-3938d263dd9c
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::rdstate
Reads the state of bits for flags.  
  
## Syntax  
  
```  
  
iostate rdstate( ) const;  
  
```  
  
## Return Value  
 The stored stream state information.  
  
## Example  
  
```  
// basic_ios_rdstate.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
using namespace std;  
  
void TestFlags( ios& x )   
{  
   cout << ( x.rdstate( ) & ios::badbit ) << endl;  
   cout << ( x.rdstate( ) & ios::failbit ) << endl;  
   cout << ( x.rdstate( ) & ios::eofbit ) << endl;  
   cout << endl;  
}  
  
int main( )   
{  
   fstream x( "c:\test.txt", ios::out );  
   x.clear( );  
   TestFlags( x );  
   x.clear( ios::badbit | ios::failbit | ios::eofbit );  
   TestFlags( x );  
}  
```  
  
 **0**  
**0**  
**0**  
**4**  
**2**  
**1**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)