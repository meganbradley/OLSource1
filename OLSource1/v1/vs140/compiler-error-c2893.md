---
title: "Compiler Error C2893"
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
  - "C2893"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2893"
ms.assetid: ec0cbe43-005d-45da-8742-aaeb9b81d28e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2893
Failed to specialize function template 'template name'  
  
 The compiler failed to specialize a function template. There can be many causes for this error.  
  
 In general, the way to resolve a C2893 error is to review the function's signature and make sure you can instantiate every type.  
  
## Example  
 C2893 occurs because <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>'s template parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is deduced to be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, but <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has no member <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can not be instantiated with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.). The following sample generates C2893.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>