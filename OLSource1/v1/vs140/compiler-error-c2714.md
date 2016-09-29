---
title: "Compiler Error C2714"
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
  - "C2714"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2714"
ms.assetid: 401a5a42-660c-4bad-9d63-1a2d092bc489
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2714
__alignof(void) is not allowed  
  
 An invalid value was passed to an operator.  
  
 See [__alignof Operator](../vs140/__alignof-operator.md) for more information.  
  
## Example  
 The following sample generates C2714.  
  
```  
// C2714.cpp  
int main() {  
   return __alignof(void);   // C2714  
   return __alignof(char);   // OK  
}  
```