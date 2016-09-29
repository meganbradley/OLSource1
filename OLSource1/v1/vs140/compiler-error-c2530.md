---
title: "Compiler Error C2530"
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
  - "C2530"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2530"
ms.assetid: b790a312-48df-4a6a-9e27-be2c5f32f16c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2530
'identifier' : references must be initialized  
  
 You must initialize a reference when it was declared, unless it is declared already:  
  
-   With the keyword [extern](../vs140/using-extern-to-specify-linkage.md).  
  
-   As a member of a class, structure, or union (and it is initialized in the constructor).  
  
-   As a parameter in a function declaration or definition.  
  
-   As the return type of a function.  
  
 The following sample generates C2530:  
  
```  
// C2530.cpp  
int main() {  
   int i = 0;  
   int &j;   // C2530  
   int &k = i;   // OK  
}  
```