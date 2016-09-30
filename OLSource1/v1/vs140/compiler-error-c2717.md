---
title: "Compiler Error C2717"
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
  - "C2717"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2717"
ms.assetid: bfb96328-440e-4b41-9370-15e430454d56
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2717
'__nogc new' cannot be used to create a managed type object  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> can only be used to create instances of unmanaged classes and value types. For more information, see [__nogc](../vs140/__nogc.md).  
  
 C2717 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C2717:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>