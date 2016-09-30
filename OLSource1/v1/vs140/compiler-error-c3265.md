---
title: "Compiler Error C3265"
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
  - "C3265"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3265"
ms.assetid: 10ab3e17-4a9f-4120-bab5-21473869b70f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3265
cannot declare a managed 'managed construct' in an unmanaged 'unmanaged construct'  
  
 You cannot include a managed object in an unmanaged context.  
  
 The following sample reproduces C3265:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample reproduces C3265:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C3265 can also occur if you embed a managed pointer directly inside an unmanaged class. To fix this error, use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>