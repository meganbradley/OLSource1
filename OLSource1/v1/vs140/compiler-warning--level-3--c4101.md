---
title: "Compiler Warning (level 3) C4101"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4101"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4101"
ms.assetid: d98563cd-9dce-4aae-8f12-bd552a4ea677
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4101
'identifier' : unreferenced local variable  
  
 The local variable is never used. This warning will occur in the obvious situation:  
  
```  
// C4101a.cpp  
// compile with: /W3  
int main() {  
int i;   // C4101  
}  
```  
  
 However, this warning will also occur when calling a **static** member function through an instance of the class:  
  
```  
// C4101b.cpp  
// compile with:  /W3  
struct S {  
   static int func()  
   {  
      return 1;  
   }  
};  
  
int main() {  
   S si;   // C4101, si is never used  
   int y = si.func();  
   return y;  
}  
```  
  
 In this situation, the compiler uses information about `si` to access the **static** function, but the instance of the class is not needed to call the **static** function; hence the warning. To resolve this warning, you could:  
  
-   Add a constructor, in which the compiler would use the instance of `si` in the call to `func`.  
  
-   Remove the **static** keyword from the definition of `func`.  
  
-   Call the **static** function explicitly: `int y = S::func();`.