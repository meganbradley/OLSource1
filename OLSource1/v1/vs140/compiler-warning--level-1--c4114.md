---
title: "Compiler Warning (level 1) C4114"
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
  - "C4114"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4114"
ms.assetid: 3983e1c6-e8bb-46dc-8894-e1827db48797
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4114
same type qualifier used more than once  
  
 A type declaration or definition uses a type qualifier (**const**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, **signed**, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) more than once. This causes a warning with Microsoft extensions (/Ze) and an error under ANSI compatibility (/Za).  
  
 The following sample generates C4114:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C4114:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>