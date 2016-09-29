---
title: "basic_ios::bad"
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
  - "ios/std::basic_ios::bad"
  - "std::basic_ios::bad"
  - "std.basic_ios.bad"
  - "bad"
  - "basic_ios.bad"
  - "basic_ios::bad"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bad method"
ms.assetid: 4038d331-e9c9-48b0-bf49-c6505744469c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::bad
Indicates a loss of integrity of the stream buffer  
  
## Syntax  
  
```  
bool bad( ) const;  
```  
  
## Return Value  
 `true` if `rdstate & badbit` is nonzero; otherwise `false`.  
  
 For more information on `badbit`, see [ios_base::iostate](../vs140/ios_base--iostate.md).  
  
## Example  
  
```  
// basic_ios_bad.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( void )   
{  
   using namespace std;  
   bool b = cout.bad( );  
   cout << boolalpha;  
   cout << b << endl;  
  
   b = cout.good( );  
   cout << b << endl;  
}  
```  
  
## Output  
  
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