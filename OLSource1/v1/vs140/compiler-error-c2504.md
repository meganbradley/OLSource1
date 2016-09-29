---
title: "Compiler Error C2504"
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
  - "C2504"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2504"
ms.assetid: c9e002a6-a4ee-4ba7-970e-edf4adb83692
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2504
'class' : base class undefined  
  
 The base class is declared but never defined.  Possible causes:  
  
1.  Missing include file.  
  
2.  External base class not declared with [extern](../vs140/using-extern-to-specify-linkage.md).  
  
 The following sample generates C2504:  
  
```  
// C2504.cpp  
// compile with: /c  
class A;  
class B : public A {};   // C2504  
```  
  
 // OK  
  
```  
class C{};  
class D : public C {};  
```