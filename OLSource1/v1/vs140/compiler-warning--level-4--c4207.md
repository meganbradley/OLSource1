---
title: "Compiler Warning (level 4) C4207"
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
  - "C4207"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4207"
ms.assetid: f4e09e3e-ac87-4489-8e3f-c8f76b82e721
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4207
nonstandard extension used : extended initializer form  
  
 With Microsoft extensions (/Ze), you can initialize an unsized array of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> using a string within braces.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Such initializations are invalid under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)).