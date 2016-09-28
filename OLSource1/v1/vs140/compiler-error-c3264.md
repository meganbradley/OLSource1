---
title: "Compiler Error C3264"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3264"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3264"
ms.assetid: 94ece687-2364-4f7a-8ebb-7afd3ae9d63d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3264
'class' : a class-constructor cannot have a return type  
  
 Class constructors cannot have return types.  
  
 The following sample generates C3264:  
  
```  
// C3264_2.cpp  
// compile with: /clr  
  
ref class X {  
   public:  
      static int X()   { // C3264  
      }  
  
      /* use the code below to resolve the error  
      static X() {  
      }  
      */  
};  
int main() {  
}  
```  
  
 The following sample generates C3264:  
  
```  
// C3264.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
  
__gc class X {  
   public:  
      static int X()   { // C3264  
      }  
  
      /* use the code below to resolve the error  
      static X() {  
      }  
      */  
};  
int main() {  
}  
```