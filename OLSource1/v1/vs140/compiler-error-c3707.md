---
title: "Compiler Error C3707"
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
  - "C3707"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3707"
ms.assetid: ac63a5dd-7a4b-48d2-9f2a-be9cb090134c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3707
'function' : dispinterface method must have a dispid  
  
 If you use a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method, you must assign it a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. To fix this error, assign a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method, for example, by uncommenting the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute on the method in the sample below. For more information, see the attributes [dispinterface](../vs140/dispinterface.md) and [id](../vs140/id.md).  
  
 The following sample generates C3707:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>