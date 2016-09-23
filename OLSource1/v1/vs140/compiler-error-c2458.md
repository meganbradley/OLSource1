---
title: "Compiler Error C2458"
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
  - C2458
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2458
ms.assetid: ed21901f-1067-42f5-b275-19b480decf5c
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2458
'identifier' : redefinition within definition  
  
 A class, structure, union, or enumeration is redefined in its own declaration.  
  
 The following sample generates C2458:  
  
```  
// C2458.cpp  
class C {  
   enum i { C };   // C2458  
};  
```