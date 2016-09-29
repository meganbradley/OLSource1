---
title: "basic_ios::fail"
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
  - "Fail"
  - "ios/std::basic_ios::fail"
  - "std::basic_ios::fail"
  - "basic_ios::fail"
  - "std.basic_ios.fail"
  - "basic_ios.fail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fail method"
ms.assetid: 619f1b36-1e72-4551-8b48-888ae4e370d2
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::fail
Indicates failure to extract a valid field from a stream.  
  
## Syntax  
  
```  
bool fail( ) const;  
```  
  
## Return Value  
 `true` if [rdstate](../vs140/basic_ios--rdstate.md) `& (badbit|failbit)` is nonzero, otherwise `false`.  
  
 For more information on `failbit`, see [ios_base::iostate](../vs140/ios_base--iostate.md).  
  
## Example  
  
```  
// basic_ios_fail.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( void )   
{  
   using namespace std;  
   bool b = cout.fail( );  
   cout << boolalpha;  
   cout << b << endl;  
}  
```  
  
## Output  
  
```  
false  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)