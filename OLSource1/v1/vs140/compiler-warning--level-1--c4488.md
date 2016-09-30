---
title: "Compiler Warning (level 1) C4488"
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
  - "C4488"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4488"
ms.assetid: 55625e46-ddb5-4c7c-99c7-cd4aa9f879bd
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4488
'function' : requires 'keyword' keyword to implement the interface method 'interface_method'  
  
 A class must implement all members of an interface from which it directly inherits. An implemented member must have public accessibility, and must be marked virtual.  
  
## Example  
 C4488 can occur if an implemented member is not public. The following sample generates C4488.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C4488 can occur if an implemented member is not marked virtual. The following sample generates C4488.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>