---
title: "Compiler Error C2071"
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
  - "C2071"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2071"
ms.assetid: f8c09255-a5c4-47e3-8089-3d875ae43cc5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2071
'identifier' : illegal storage class  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> was declared with an invalid [storage class](../vs140/c-storage-classes.md). This error can be caused when more than one storage class is specified for an identifier, or when the definition is incompatible with the storage class declaration.  
  
 To fix this issue, understand the intended storage class of the identifier—for example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>—and correct the declaration to match.  
  
## Example  
 The following sample generates C2071.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C2071.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>