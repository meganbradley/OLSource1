---
title: "Compiler Error C2866"
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
  - "C2866"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2866"
ms.assetid: f2c1e6b2-9d79-4723-9cae-4aed4ab102c0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2866
'variable' : a const static data member of a managed or WinRTtype must be initialized at the point of declaration  
  
 It is invalid to declare an uninitialized, `const``static` data member in a managed or WinRT class or struct.  
  
 The following sample generates C2866 and shows how to fix it:  
  
```  
// C2866.cpp  
// compile with: /clr /c  
ref class x {  
public:  
   const static int i;   // C2866  
   const static int j = 0;   // OK  
  
   // Delete the following line to resolve.  
   void xx() { i = 9; }  
};  
```  
  
 The following sample generates C2866 and shows how to fix it:  
  
```  
// C2866b.cpp  
// compile with: /clr:oldSyntax /c  
  
__gc class CMyClass {  
public:  
   const static double d;   // C2866  
   const static double d2 = 9;   // OK  
};  
```