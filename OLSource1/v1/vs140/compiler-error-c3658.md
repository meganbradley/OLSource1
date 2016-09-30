---
title: "Compiler Error C3658"
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
  - "C3658"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3658"
ms.assetid: 2a06872a-81a3-4407-8e99-6b48aa13ae86
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3658
'keyword' : override specifier not allowed with /clr:oldSyntax  
  
 An override specifier in the current syntax was used in a compilation enabled for the previous syntax.  
  
 The following sample generates C3658:  
  
```  
// C3658.cpp  
// compile with: /clr:oldSyntax /c  
__gc struct C {  
   virtual void f() abstract;   // C3658  
};  
```  
  
 The following sample demonstrates a possible resolution:  
  
```  
// C3658b.cpp  
// compile with: /clr /c  
ref struct C {  
   virtual void f() abstract;  
};  
```