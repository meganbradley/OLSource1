---
title: "Compiler Error C2356"
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
  - "C2356"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2356"
ms.assetid: 84d5a816-9a61-4d45-9978-38e485bbf767
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2356
initialization segment must not change during translation unit  
  
 Possible causes:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> preceded by segment initialization code  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> preceded by another <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 To resolve, move the segment initialization code to the beginning of the module. If multiple areas must be initialized, move them to separate modules.  
  
 The following sample generates C2356:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>