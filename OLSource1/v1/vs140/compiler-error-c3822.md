---
title: "Compiler Error C3822"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3822"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3822"
ms.assetid: e4346fed-d640-4126-a14c-180919a48fdd
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3822
'property' : name of the property method must start with 'get_' or 'set_'  
  
 Property method names must start with either `get_` or `set_`.  
  
 C3822 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3822:  
  
```  
// C3822.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
  
__gc struct A {  
   __property int get_Size() {  
      return 0;  
   }  
  
   __property void SET_Size(int i) {   // C3822  
   }  
  
   // use the property below to resolve the error  
   __property void set_Size(int i) {  
   }  
   */  
};  
  
int main() {  
}  
```