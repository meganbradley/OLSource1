---
title: "basic_ios::tie"
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
  - basic_ios::tie
  - basic_ios.tie
  - std::basic_ios::tie
  - tie
  - std.basic_ios.tie
  - ios/std::basic_ios::tie
dev_langs: 
  - C++
helpviewer_keywords: 
  - tie method
ms.assetid: d85ef9f0-2966-4cea-9a2a-f7dceffc3870
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_ios::tie
Ensures that one stream is processed before another stream.  
  
## Syntax  
  
```  
basic_ostream<Elem, Traits> *tie( ) const;  
basic_ostream<Elem, Traits> *tie(   
    basic_ostream<Elem, Traits> *_Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A stream.  
  
## Return Value  
 The first member function returns the stored tie pointer. The second member function stores `_Str` in the tie pointer and returns its previous stored value.  
  
## Remarks  
 `tie` causes two streams to be synchronized, such that, operations on one stream occur after operations on the other stream are complete.  
  
## Example  
 In this example, by tying cin to cout, it is guaranteed that the "Enter a number:" string will go to the console before the number itself is extracted from cin. This eliminates the possibility that the "Enter a number:" string is still sitting in the buffer when the number is read, so that we are certain that the user actually has some prompt to respond to. By default, cin and cout are tied.  
  
```  
#include <ios>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   int i;  
   cin.tie( &cout );  
   cout << "Enter a number:";  
   cin >> i;  
}  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)