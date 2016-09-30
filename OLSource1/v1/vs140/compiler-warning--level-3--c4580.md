---
title: "Compiler Warning (level 3) C4580"
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
  - "C4580"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4580"
ms.assetid: fef6e8e0-0d6a-44fa-b22a-2fe7ba2ef379
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4580
[attribute] is deprecated; instead specify System::Attribute or Platform::Metadata as a base class  
  
 [attribute](../vs140/attribute.md) is no longer the preferred syntax for creating user-defined attributes. For more information, see [User-Defined Attributes](../vs140/user-defined-attributes---c---component-extensions-.md). For CLR code, derive attributes from \<xref:Attribute*>. For Windows Runtime code, derive attributes from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample generates C3454 and shows how to fix it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>