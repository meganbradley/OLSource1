---
title: "Compiler Error C3717"
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
  - "C3717"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3717"
ms.assetid: ae4fceb1-2583-4577-b2f1-40971a017055
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3717
'method': a method that fires events cannot be defined  
  
 You declared an event method that includes an implementation. An [__event](../vs140/__event.md) method declaration cannot have a definition. To fix this error, ensure that no event method declarations have definitions. For example, in the code below, remove the function body from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> declaration as indicated by the comments.  
  
 The following sample generates C3717:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>