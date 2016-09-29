---
title: "basic_streambuf::getloc"
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
  - "basic_streambuf.getloc"
  - "std::basic_streambuf::getloc"
  - "streambuf/std::basic_streambuf::getloc"
  - "getloc"
  - "basic_streambuf::getloc"
  - "std.basic_streambuf.getloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "getloc method"
ms.assetid: f6a1545a-04c3-40ce-8443-ca00e6f8849f
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::getloc
Gets the basic_streambuf object's locale.  
  
## Syntax  
  
```  
  
locale getloc( ) const;  
  
```  
  
## Return Value  
 The stored locale object.  
  
## Remarks  
 For related information, see [ios_base::getloc](../vs140/ios_base--getloc.md).  
  
## Example  
  
```  
// basic_streambuf_getloc.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   cout << cout.rdbuf( )->getloc( ).name( ).c_str( ) << endl;  
}  
```  
  
 **C**   
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)