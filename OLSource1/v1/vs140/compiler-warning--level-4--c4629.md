---
title: "Compiler Warning (level 4) C4629"
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
  - "C4629"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4629"
ms.assetid: 158cde12-bae5-4d43-b575-b52b35aaa0b9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4629
digraph used, character sequence 'digraph' interpreted as token 'char' (insert a space between the two characters if this is not what you intended)  
  
 Under [/Za](../vs140/-za---ze--disable-language-extensions-.md), the compiler warns when it detects a digraph.  
  
 The following sample generates C4629:  
  
```  
// C4629.cpp  
// compile with: /Za /W4  
int main()  
<%   // C4629 <% digraph for {  
}  
```