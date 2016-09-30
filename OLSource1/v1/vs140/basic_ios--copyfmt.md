---
title: "basic_ios::copyfmt"
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
  - "std.basic_ios.copyfmt"
  - "copyfmt"
  - "ios/std::basic_ios::copyfmt"
  - "basic_ios.copyfmt"
  - "std::basic_ios::copyfmt"
  - "basic_ios::copyfmt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copyfmt method"
ms.assetid: 736f866e-5756-4423-89b8-d7d061ac7e68
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::copyfmt
Copies flags from one stream to another.  
  
## Syntax  
  
```  
basic_ios<Elem, Traits>& copyfmt(  
    const basic_ios<Elem, Traits>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The stream whose flags you want to copy.  
  
## Return Value  
 The **this** object for the stream to which you are copying the flags.  
  
## Remarks  
 The member function reports the callback event erase_event. It then copies from `_Right` into **\*this** the fill character, the tie pointer, and the formatting information. Before altering the exception mask, it reports the callback event copyfmt_event. If, after the copy is complete, **state &**[exceptions](../vs140/basic_ios--exceptions.md) is nonzero, the function effectively calls [clear](../vs140/basic_ios--clear.md) with the argument [rdstate](../vs140/basic_ios--rdstate.md). It returns **\*this**.  
  
## Example  
  
```  
// basic_ios_copyfmt.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )   
{  
   using namespace std;  
   ofstream x( "test.txt" );  
   int i = 10;  
  
   x << showpos;  
   cout << i << endl;  
   cout.copyfmt( x );  
   cout << i << endl;  
}  
```  
  
## Output  
  
```  
10  
+10  
```  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)