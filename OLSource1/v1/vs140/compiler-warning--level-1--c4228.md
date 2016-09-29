---
title: "Compiler Warning (level 1) C4228"
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
  - "C4228"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4228"
ms.assetid: 9301d660-d601-464e-83f5-7ed844a3c6dc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4228
nonstandard extension used : qualifiers after comma in declarator list are ignored  
  
 Use of qualifiers like **const** or `volatile` after a comma when declaring variables is a Microsoft extension ([/Ze](../vs140/-za---ze--disable-language-extensions-.md)).  
  
## Example  
  
```  
// C4228.cpp  
// compile with: /W1  
int j, const i = 0;  // C4228  
int k;  
int const m = 0;  // ok  
int main()  
{  
}  
```