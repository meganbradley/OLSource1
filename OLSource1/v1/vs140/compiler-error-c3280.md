---
title: "Compiler Error C3280"
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
  - "C3280"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3280"
ms.assetid: 86dc5bbc-8818-4786-a728-9334268d308b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3280
'class' : a member-function of a managed type cannot be compiled as an unmanaged function  
  
 Managed class member functions cannot be compiled as unmanaged functions.  
  
 The following sample generates C3280:  
  
```  
// C3280_2.cpp  
// compile with: /clr  
ref struct A {  
   void func();  
};  
  
#pragma managed(push,off)  
  
void A::func()   // C3280  
{  
}  
  
#pragma managed(pop)  
```  
  
 The following sample generates C3280:  
  
```  
// C3280.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
  
__gc struct A {  
   void func();  
};  
  
#pragma managed(push,off)  
  
void A::func()   // C3280  
{  
}  
  
#pragma managed(pop)  
```