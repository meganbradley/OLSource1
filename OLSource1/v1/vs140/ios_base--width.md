---
title: "ios_base::width"
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
  - "xiosbase/std::ios_base::width"
  - "std.ios_base.width"
  - "ios_base::width"
  - "Width"
  - "ios_base.width"
  - "width"
  - "std::ios_base::width"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "width method"
ms.assetid: 1c25c6fb-6b56-4187-bf27-a0bf2db496a7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::width
Sets the length of the output stream.  
  
## Syntax  
  
```  
  
      streamsize width( ) const;   
streamsize width(  
   streamsize _Wide  
);  
```  
  
#### Parameters  
 `_Wide`  
 The desired size of the output stream.  
  
## Return Value  
 The current width setting.  
  
## Remarks  
 The first member function returns the stored field width. The second member function stores `_Wide` in the field width and returns its previous stored value.  
  
## Example  
  
```  
// ios_base_width.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
  
   cout.width( 20 );  
   cout << cout.width( ) << endl;  
   cout << cout.width( ) << endl;  
}  
```  
  
  **20**  
**0**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)