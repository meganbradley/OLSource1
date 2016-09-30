---
title: "Compiler Error C3020"
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
  - "C3020"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3020"
ms.assetid: f625c7a3-afaa-4bd8-9c1b-51891b832f36
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3020
'var' : index variable of OpenMP 'for' loop cannot be modified in loop body  
  
 An OpenMP <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop may not modify the index (loop counter) in the body of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop.  
  
 The following sample generates C3020:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 A variable declared with [lastprivate](../vs140/lastprivate.md) cannot be used as the index inside a parallelized loop.  
  
 The following sample will give C3020 for the second lastprivate because that lastprivate will trigger a write to idx_a within the outermost for loop. The first lastprivate doesn't give an error because that lastprivate triggers a write to idx_a outside the outermost for loop (technically, at the very end of the last iteration). The following sample generates C3020.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample demonstrates a possible resolution:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>