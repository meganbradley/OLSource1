---
title: "Compiler Error C2534"
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
  - "C2534"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2534"
ms.assetid: 481f9f54-5b51-4aa0-8eea-218f10807705
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2534
'identifier' : constructor cannot return a value  
  
 A constructor cannot return a value or have a return type (not even a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> return type).  
  
 This error may be fixed by removing the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement from the constructor definition.  
  
 The following sample generates C2534:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>