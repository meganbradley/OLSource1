---
title: "Compiler Error C3170"
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
  - C3170
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3170
ms.assetid: ca9a59d6-7df3-42f0-b028-c09d0af3ac2a
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3170
cannot have different module identifiers in a project  
  
 [module](../vs140/module--c---.md) attributes with different names were found in two of the files in a compilation. Only one unique `module` attribute can be specified per compilation.  
  
 Identical `module` attributes can be specified in more than one source code file.  
  
 For example, if the following module attributes were found:  
  
```  
// C3170.cpp  
[ module(name="MyModule", uuid="373a1a4e-469b-11d3-a6b0-00c04f79ae8f") ];  
int main() {}  
```  
  
 And then,  
  
```  
// C3170b.cpp  
// compile with: C3170.cpp  
// C3170 expected  
[ module(name="MyModule1", uuid="373a1a4e-469b-11d3-a6b0-00c04f79ae8f") ];  
```  
  
 the compiler would generate C3170 (note the different names).