---
title: "skipws"
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
  - "ios/std::skipws"
  - "_Iosb.skipws"
  - "std._Iosb.skipws"
  - "std::skipws"
  - "skipws"
  - "_Iosb::skipws"
  - "std::_Iosb::skipws"
  - "xiosbase/std::_Iosb::skipws"
  - "std.skipws"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "skipws"
  - "skipws function"
ms.assetid: 061e2679-95db-4d93-a8bf-d787612eb910
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# skipws
Cause spaces to not be read by the input stream.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& skipws(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, `skipws` is in effect. [noskipws](../vs140/noskipws.md) will cause spaces to be read from the input stream.  
  
 The manipulator effectively calls `_Str.`[setf](../vs140/ios_base--setf.md)(`ios_base::skipws`), and then returns `_Str`.  
  
## Example  
  
```  
#include <iostream>  
#include <string>  
  
int main( )   
{  
   using namespace std;  
   char s1, s2, s3;  
   cout << "Enter three characters: ";  
   cin >> skipws >> s1 >> s2 >> s3;  
   cout << "." << s1  << "." << endl;  
   cout << "." << s2 << "." << endl;  
   cout << "." << s3 << "." << endl;  
}  
```  
  
  **`1 2 3` `1 2 3`.1.**  
**.2.**  
**.3.**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)