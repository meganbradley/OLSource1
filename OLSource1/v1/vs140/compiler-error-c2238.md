---
title: "Compiler Error C2238"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C2238"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2238"
ms.assetid: 3d53060c-d6b7-4603-b9cf-d7c65eb64cd2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2238
unexpected token(s) preceding 'token'  
  
 An incorrect token was found.  
  
 The following sample generates C2238:  
  
```  
// C2238.cpp  
// compile with: /c  
class v {  
virtual: int vvv;   // C2238  
};  
```