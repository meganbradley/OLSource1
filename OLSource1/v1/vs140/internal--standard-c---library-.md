---
title: "internal (Standard C++ Library)"
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
  - "internal function"
  - "ios/std::internal"
  - "std::internal"
  - "std.internal"
  - "internal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "internal function"
  - "internal"
ms.assetid: 266fcb17-8949-4d35-9796-277c11ab95f1
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# internal (Standard C++ Library)
Causes a number's sign to be left justified and the number to be right justified.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& internal(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which `_Str` is derived.  
  
## Remarks  
 [showpos](../vs140/showpos.md) causes the sign to display for positive numbers.  
  
 The manipulator effectively calls `_Str`.[setf](../vs140/ios_base--setf.md)([ios_base::internal](../vs140/ios_base--fmtflags.md), [ios_base::adjustfield](../vs140/ios_base--fmtflags.md)), and then returns `_Str`.  
  
## Example  
  
```  
// ios_internal.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <iomanip>  
  
int main( void )   
{  
   using namespace std;  
   float i = -123.456F;  
   cout.fill( '.' );  
   cout << setw( 10 ) << i << endl;  
   cout << setw( 10 ) << internal << i << endl;  
}  
```  
  
 **..-123.456**  
**-..123.456**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)