---
title: "fpos::state"
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
  - iosfwd/std::fpos::state
  - std::fpos::state
  - fpos::state
  - std.fpos.state
  - state
  - fpos.state
dev_langs: 
  - C++
helpviewer_keywords: 
  - state method
ms.assetid: edc873e6-fa9c-4dc3-916d-f8f4c0f26afc
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# fpos::state
Sets or returns the conversion state.  
  
## Syntax  
  
```  
  
      Statetype state( ) const;   
void state(  
   Statetype _State  
);  
```  
  
#### Parameters  
 `_State`  
 The new conversion state.  
  
## Return Value  
 The conversion state.  
  
## Remarks  
 The first member function returns the value stored in the **St** member object. The second member function stores `_State` in the **St** member object.  
  
## Example  
  
```  
// fpos_state.cpp  
// compile with: /EHsc  
#include <ios>  
#include <iostream>  
#include <fstream>  
  
int main() {  
   using namespace std;  
   streamoff s;  
   ifstream file( "fpos_state.txt" );  
  
   fpos<mbstate_t> f = file.tellg( );  
   char ch;  
   while ( !file.eof( ) )  
      file.get( ch );  
   s = f;  
   cout << f.state( ) << endl;  
   f.state( 9 );  
   cout << f.state( ) << endl;  
}  
```  
  
## Input: fpos_state.txt  
  
```  
testing  
```  
  
## Output  
  
```  
0  
9  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [fpos Class](../vs140/fpos-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)