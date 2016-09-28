---
title: "ios_base::setf"
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
  - "ios_base::setf"
  - "std::ios_base::setf"
  - "ios_base.setf"
  - "xiosbase/std::ios_base::setf"
  - "setf"
  - "std.ios_base.setf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setf method"
ms.assetid: caced62f-8872-4750-a40d-2d1dd6f5300a
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::setf
Sets the specified flags.  
  
## Syntax  
  
```  
fmtflags setf(  
    fmtflags _Mask  
);  
fmtflags setf(  
    fmtflags _Mask,  
    fmtflags _Unset  
);  
```  
  
#### Parameters  
 `_Mask`  
 The flags to turn on.  
  
 *_Unset*  
 The flags to turn off.  
  
## Return Value  
 The previous format flags  
  
## Remarks  
 The first member function effectively calls [flags](../vs140/ios_base--flags.md)(_*Mask* &#124; \_*Flags*) (set selected bits) and then returns the previous format flags. The second member function effectively calls **flags**(\_*Mask* **& fmtfl, flags & ~**`_Mask`) (replace selected bits under a mask) and then returns the previous format flags.  
  
## Example  
  
```  
// ios_base_setf.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   int i = 10;  
   cout << i << endl;  
  
   cout.unsetf( ios_base::dec );  
   cout.setf( ios_base::hex );  
   cout << i << endl;  
  
   cout.setf( ios_base::dec );  
   cout << i << endl;  
   cout.setf( ios_base::hex, ios_base::dec );  
   cout << i << endl;  
}  
```  
  
## Output  
  
```  
10  
a  
10  
a  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)