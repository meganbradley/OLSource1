---
title: "Compiler Warning C4485"
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
  - "C4485"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4485"
ms.assetid: a6f2b437-ca93-4dcd-b9cb-df415e10df86
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4485
'override_function' : matches base ref class method 'base_class_function ', but is not marked 'new' or 'override'; 'new' (and 'virtual') is assumed  
  
 An accessor overrides, with or without the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword, a base class accessor function, but the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifier was not part of the overriding function signature. Add the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> specifier to resolve this warning.  
  
 See [override](../vs140/override---c---component-extensions-.md) and [new (new slot in vtable)](../vs140/new--new-slot-in-vtable----c---component-extensions-.md) for more information.  
  
 C4485 is always issued as an error. Use the [warning](../vs140/warning.md) pragma to suppress C4485.  
  
## Example  
 The following sample generates C4485  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>