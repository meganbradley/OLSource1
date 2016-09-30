---
title: "Compiler Error C2663"
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
  - "C2663"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2663"
ms.assetid: 1e93e368-fd52-42bf-9908-9b6df467c8c9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2663
'function' : number overloads have no legal conversions for 'this' pointer  
  
 The compiler could not convert <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to any of the overloaded versions of the member function.  
  
 This error can be caused by invoking a non-<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function on a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  Possible resolutions:  
  
1.  Remove the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> from the object declaration.  
  
2.  Add <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to one of the member function overloads.  
  
 The following sample generates C2663:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>