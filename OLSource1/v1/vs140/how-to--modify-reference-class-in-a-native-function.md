---
title: "How to: Modify Reference Class in a Native Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "platform invoke, reference class"
  - "reference types, modifying in a C++ native function"
ms.assetid: c701145b-62a0-4c4b-b32a-db8d69a59720
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Modify Reference Class in a Native Function
You can pass a reference class with a CLR array to a native function, and modify the class, using PInvoke services.  
  
## Example  
 Compile the following native library.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Compile the following assembly.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **str: Hello**  
**In native: intarr: 100, 200**  
**In managed: intarr: 300, 400**   
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)