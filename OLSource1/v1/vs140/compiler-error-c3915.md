---
title: "Compiler Error C3915"
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
  - "C3915"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3915"
ms.assetid: 2b0a5e5f-3aec-4a4b-9157-233031817084
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3915
'type' has no default indexed property (class indexer)  
  
 A type does not have a default, indexed property.  
  
 For more information, see [property](../vs140/property---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3915.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C3915 can also occur if you attempt to consume a default indexer in the same compiland where it was defined with \<xref:System.Reflection.DefaultMemberAttribute*>.  
  
 The following sample generates C3915.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>