---
title: "Compiler Error C2757"
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
  - "C2757"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2757"
ms.assetid: 421f102f-8a32-4d47-a109-811ddf2c909d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2757
'symbol' : a symbol with this name already exists and therefore this name cannot be used as a namespace name  
  
 A symbol used in the current compilation as a namespace identifier is already being used in a referenced assembly.  
  
 The following sample generates C2757:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And then,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample generates C2757:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 And then,  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>