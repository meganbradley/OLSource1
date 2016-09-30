---
title: "Compiler Error C3825"
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
  - "C3825"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3825"
ms.assetid: 18e204a1-f26e-42c6-8d74-2b49cc95f940
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3825
'class': a managed or WinRTclass can only support managed or WinRTevents  
  
 Only .NET events are supported in managed classes. Only Windows Runtime events are supported in Windows Runtime classes. To fix this error in managed code, change type parameter of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Alternatively, remove the attribute.  
  
## Example  
 The following sample generates C3825 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>