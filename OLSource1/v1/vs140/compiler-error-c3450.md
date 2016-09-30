---
title: "Compiler Error C3450"
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
  - "C3450"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3450"
ms.assetid: 78892cf7-0b82-4589-90d0-e06666247003
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3450
'type': not an attribute; cannot specify [System::AttributeUsageAttribute] or [Windows::Foundation::Metadata::AttributeUsageAttribute]  
  
 A user-defined managed attribute must inherit from \<xref:System.ComponentModel.AttributeCollection.#ctor*>. A Windows Runtime attribute must be defined in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> namespace.  
  
 For more information, see [User-Defined Attributes](../vs140/user-defined-attributes---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3450 and shows how to fix it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>