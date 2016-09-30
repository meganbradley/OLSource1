---
title: "Compiler Error C2619"
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
  - "C2619"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2619"
ms.assetid: c826f8ab-d66a-4b79-a0b2-93b0af8c41ac
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2619
'identifier': a static data member is not allowed in an anonymous struct or union  
  
 A member of an anonymous struct or union is declared <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 The following sample generates C2619, and demonstrates how to fix it by removing the static keyword.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>