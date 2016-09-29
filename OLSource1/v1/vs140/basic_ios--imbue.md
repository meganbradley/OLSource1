---
title: "basic_ios::imbue"
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
  - "ios/std::basic_ios::imbue"
  - "basic_ios.imbue"
  - "basic_ios::imbue"
  - "std::basic_ios::imbue"
  - "imbue"
  - "std.basic_ios.imbue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imbue method"
ms.assetid: 6cae631b-fe2b-47c5-bbfb-768516f4cc9f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::imbue
Changes the locale.  
  
## Syntax  
  
```  
  
      locale imbue(  
   const locale& _Loc  
);  
```  
  
#### Parameters  
 `_Loc`  
 A locale string.  
  
## Return Value  
 The previous locale.  
  
## Remarks  
 If [rdbuf](../vs140/basic_ios--rdbuf.md) is not a null pointer, the member function calls  
  
 `rdbuf`->[pubimbue](../vs140/basic_streambuf--pubimbue.md)(_*Loc*)  
  
 In any case, it returns [ios_base::imbue](../vs140/ios_base--imbue.md)(_*Loc*).  
  
## Example  
  
```  
// basic_ios_imbue.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <locale>  
  
int main( )   
{  
   using namespace std;  
  
   cout.imbue( locale( "french_france" ) );  
   double x = 1234567.123456;  
   cout << x << endl;  
}  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)