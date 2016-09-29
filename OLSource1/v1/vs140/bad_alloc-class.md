---
title: "bad_alloc Class"
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
  - "std::bad_alloc"
  - "new/std:bad_alloc"
  - "bad_alloc"
  - "std.bad_alloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bad_alloc class"
ms.assetid: 6429a8e6-5a49-4907-8d56-f4a4ec8131d0
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bad_alloc Class
The class describes an exception thrown to indicate that an allocation request did not succeed.  
  
## Syntax  
  
```  
class bad_alloc : public exception {  
   bad_alloc();  
   virtual ~bad_alloc();  
};  
```  
  
## Remarks  
 The value returned by **what** is an implementation-defined C string. None of the member functions throw any exceptions.  
  
## Requirements  
 **Header:** \<new>  
  
 **Namespace:** std  
  
## Example  
  
```  
// bad_alloc.cpp  
// compile with: /EHsc  
#include<new>  
#include<iostream>  
using namespace std;  
  
int main() {  
   char* ptr;  
   try {  
      ptr = new char[(~unsigned int((int)0)/2) - 1];  
      delete[] ptr;  
   }  
   catch( bad_alloc &ba) {  
      cout << ba.what( ) << endl;  
   }  
}  
```  
  
## Sample Output  
  
```  
bad allocation  
```  
  
## Requirements  
 **Header:** \<new>  
  
## See Also  
 [exception Class](../vs140/exception-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)