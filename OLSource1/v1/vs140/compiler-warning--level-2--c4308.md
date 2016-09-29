---
title: "Compiler Warning (level 2) C4308"
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
  - "C4308"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4308"
ms.assetid: d4e5c53c-71b2-4bbc-8a7c-3a2a3180d9d9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) C4308
negative integral constant converted to unsigned type  
  
 An expression converts a negative integer constant to an unsigned type. The result of the expression is probably meaningless.  
  
## Example  
  
```  
// C4308.cpp  
// compile with: /W2  
unsigned int u = (-5 + 3U);   // C4308  
  
int main()  
{  
}  
```