---
title: "Compiler Warning (level 1) C4667"
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
  - "C4667"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4667"
ms.assetid: 5d2b7fe0-4f0e-4cd6-b432-ca02c3d194ab
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4667
'function' : no function template defined that matches forced instantiation  
  
 You cannot instantiate a function template that has not been declared.  
  
 The following sample will cause C4667:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To avoid this warning, first declare the function template:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>