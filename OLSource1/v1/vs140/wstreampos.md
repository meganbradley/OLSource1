---
title: "wstreampos"
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
  - iosfwd/std::wstreampos
  - std.wstreampos
  - wstreampos
  - std::wstreampos
dev_langs: 
  - C++
helpviewer_keywords: 
  - wstreampos typedef
ms.assetid: 1444744f-5beb-40c4-9797-675849ab9497
caps.latest.revision: 19
translation.priority.mt: 
  - de-de
  - ja-jp
---
# wstreampos
Holds the current position of the buffer pointer or file pointer.  
  
## Syntax  
  
```  
  
typedef fpos<mbstate  
_  
t> wstreampos;  
  
```  
  
## Remarks  
 The type is a synonym for [fpos](../vs140/fpos-class.md)<`mbstate_t`>.  
  
## Example  
  
```  
// ios_wstreampos.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )   
{  
   using namespace std;  
   wofstream xw( "wiostream.txt" );  
   xw << L"testing";  
   wstreampos y = xw.tellp( );  
   cout << y << endl;  
}  
```  
  
 **7**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [fpos Class](../vs140/fpos-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)