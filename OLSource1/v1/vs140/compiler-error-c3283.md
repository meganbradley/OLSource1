---
title: "Compiler Error C3283"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3283"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3283"
ms.assetid: c51d912c-cde3-4928-904e-26734c8954ce
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3283
'type' : an interface cannot have an instance constructor  
  
 A CLR [interface](../vs140/interface-class---c---component-extensions-.md) cannot have an instance constructor.  A static constructor is allowed.  
  
 The following sample generates C3283:  
  
```  
// C3283.cpp  
// compile with: /clr  
interface class I {  
   I();   // C3283  
};  
```  
  
 Possible resolution:  
  
```  
// C3283b.cpp  
// compile with: /clr /c  
interface class I {  
   static I(){}  
};  
```