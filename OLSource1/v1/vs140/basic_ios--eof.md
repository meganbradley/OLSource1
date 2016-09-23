---
title: "basic_ios::eof"
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
  - ios/std::basic_ios::eof
  - std::basic_ios::eof
  - EOF
  - basic_ios::eof
  - basic_ios.eof
  - std.basic_ios.eof
dev_langs: 
  - C++
helpviewer_keywords: 
  - eof method
ms.assetid: 3087f631-1268-49cd-86cf-ff4108862329
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_ios::eof
Indicates if the end of a stream has been reached.  
  
## Syntax  
  
```  
bool eof( ) const;  
```  
  
## Return Value  
 `true` if the end of the stream has been reached, `false` otherwise.  
  
## Remarks  
 The member function returns `true` if [rdstate](../vs140/basic_ios--rdstate.md) `& eofbit` is nonzero. For more information on `eofbit`, see [ios_base::iostate](../vs140/ios_base--iostate.md).  
  
## Example  
  
```  
// basic_ios_eof.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
using namespace std;  
  
int main( int argc, char* argv[] )   
{  
   fstream   fs;  
   int n = 1;  
   fs.open( "basic_ios_eof.txt" );   // an empty file  
   cout << boolalpha  
   cout << fs.eof() << endl;  
   fs >> n;   // Read the char in the file  
   cout << fs.eof() << endl;  
}  
```  
  
## Sample Output  
  
```  
false  
true  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)