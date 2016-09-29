---
title: "Compiler Error C3669"
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
  - "C3669"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3669"
ms.assetid: be9c7ae4-e96f-47ab-922a-39a3537d5ca6
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3669
'member' : override specifier 'override' not allowed on static member functions or constructors  
  
 An override was specified incorrectly. For more information, see [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3669.  
  
```  
// C3669.cpp  
// compile with: /clr  
public ref struct R {  
   R() override {}   // C3669  
};  
```