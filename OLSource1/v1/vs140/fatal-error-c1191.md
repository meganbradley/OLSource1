---
title: "Fatal Error C1191"
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
  - "C1191"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1191"
ms.assetid: 2888c6c4-b4e6-449e-8ee0-7917f31086df
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1191
'dll' can only be imported at global scope  
  
 The instruction to import mscorlib.dll into a program that uses /clr programming cannot appear in a namespace or function, but must appear at global scope.  
  
 The following sample generates C1191:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>