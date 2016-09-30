---
title: "Compiler Error C2492"
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
  - "C2492"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2492"
ms.assetid: 8c44c9bb-c366-4fe5-a0ab-882e38608aaa
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2492
'variable' : 'thread' data may not have dll interface  
  
 The variable is declared with the [thread](../vs140/thread.md) attribute and with the DLL interface. The address of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable is not known until run time, so it cannot be linked to a DLL import or export.  
  
 The following sample generates C2492:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>