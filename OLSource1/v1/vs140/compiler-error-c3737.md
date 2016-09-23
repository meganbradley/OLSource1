---
title: "Compiler Error C3737"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C3737
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3737
ms.assetid: ca2aeb23-2491-4ccb-8838-884abf7065c8
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3737
'delegate': a delegate may not have an explicit calling convention  
  
 You cannot specify the [calling convention](../vs140/calling-conventions.md) for a [__delegate](../vs140/__delegate.md).  
  
 The following sample generates C3737:  
  
```  
// C3737a.cpp  
// compile with: /clr  
delegate void __stdcall MyFunc();   // C3737  
// Try the following line instead.  
// delegate void MyFunc();  
  
int main() {  
}  
```  
  
 The following sample generates C3737:  
  
```  
// C3737b.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
__delegate void __stdcall MyFunc();   // C3737  
// Try the following line instead.  
// __delegate void MyFunc();  
  
int main() {  
}  
```