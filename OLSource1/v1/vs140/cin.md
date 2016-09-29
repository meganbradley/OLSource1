---
title: "cin"
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
  - "cin"
  - "std.cin"
  - "iostream/std::cin"
  - "std::cin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "console, reading formatted text from"
  - "console, reading from"
  - "cin function"
  - "text input"
ms.assetid: 0a830ffb-db8b-4cfc-a303-6ae4200ab760
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cin
Specifies the `cin` global stream.  
  
## Syntax  
  
```  
extern istream cin;  
```  
  
## Return Value  
 An [istream](../vs140/istream.md) object.  
  
## Remarks  
 The object controls extractions from the standard input as a byte stream. Once the object is constructed, the call `cin.`[tie](../vs140/basic_ios--tie.md) returns `&`[cout](../vs140/cout.md).  
  
## Example  
 In this example, `cin` sets the fail bit on the stream when it encounters non-numeric characters. The program clears the fail bit and strips the invalid character from the stream to proceed.  
  
```  
// iostream_cin.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main()  
{  
   int x;  
   cout << "enter choice:";  
   cin >> x;  
   while (x < 1 || x > 4)  
   {  
      cout << "Invalid choice, try again:";  
      cin >> x;  
      // not a numeric character, probably  
      // clear the failure and pull off the non-numeric character  
      if (cin.fail())  
      {  
         cin.clear();  
         char c;  
         cin >> c;  
      }  
   }  
}  
```  
  
  **`2`**    
## Requirements  
 **Header:** \<iostream>  
  
 **Namespace:** std  
  
## See Also  
 [istream](../vs140/istream.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)