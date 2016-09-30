---
title: "Compiler Error C3711"
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
  - "C3711"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3711"
ms.assetid: 26d581cc-2153-4ee0-b814-a371184be3e1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3711
'method': an non-managed event source method must return void or an integral type  
  
 You defined a method in the event source that did not return void or an integral type. To fix this error, make the event and event handler have a return type of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or an integral type such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The following sample generates C3711:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>