---
title: "Compiler Warning (level 1) C4632"
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
  - C4632
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4632
ms.assetid: 9e35d205-cf21-4e34-8bd5-e1e7b0e2cdd3
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4632
XML document comment: file - access denied: reason  
  
 The path to .xdc file (`file`) was not valid, and no .xdc file created.  
  
 The following sample generates C4632:  
  
```  
// C4632.cpp  
// compile with: /clr /docv:\\falsedir /LD /W1  
// C4632 expected  
  
/// Text for class MyClass.  
public ref class MyClass {};  
```