---
title: "Compiler Warning (level 4) C4205"
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
  - "C4205"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4205"
ms.assetid: 39b5108c-7230-41b4-b2fe-2293eb6aae28
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4205
nonstandard extension used : static function declaration in function scope  
  
 With Microsoft extensions (/Ze), **static** functions can be declared inside another function. The function is given global scope.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Such initializations are invalid under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)).