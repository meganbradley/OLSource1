---
title: "ios_base::getloc"
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
  - "std::ios_base::getloc"
  - "std.ios_base.getloc"
  - "ios_base::getloc"
  - "getloc"
  - "ios_base.getloc"
  - "xiosbase/std::ios_base::getloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "getloc method"
ms.assetid: 3ae3a6a3-b3dd-4796-89cf-07478ca3da97
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::getloc
Returns the stored locale object.  
  
## Syntax  
  
```  
  
locale getloc( ) const;  
  
```  
  
## Return Value  
 The stored locale object.  
  
## Example  
  
```  
// ios_base_getlock.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   cout << cout.getloc( ).name( ).c_str( ) << endl;  
}  
```  
  
 **C**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)