---
title: "Compiler Error C2946"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C2946
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2946
ms.assetid: c86dfbfc-7702-4f09-8a53-d205710e99c2
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2946
explicit instantiation; 'class' is not a template-class specialization  
  
 You cannot explicitly instantiate a nontemplated class.  
  
## Example  
 The following sample generates C2946.  
  
```  
// C2946.cpp  
class C {};  
template C;  // C2946  
int main() {}  
```