---
title: "Compiler Warning (level 1) C4486"
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
  - "C4486"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4486"
ms.assetid: 2c0c59e3-d025-4d97-8da2-fa27df1402fc
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4486
'function' : a private virtual method of a ref class or value class should be marked 'sealed'  
  
 Since a private virtual member function of a managed class or struct cannot be accessed or overridden, it should be marked [sealed](../vs140/sealed---c---component-extensions-.md).  
  
## Example  
 The following sample generates C4486.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample shows one possible use of a private sealed, virtual function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>