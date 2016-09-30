---
title: "Compiler Error C2662"
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
  - "C2662"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2662"
ms.assetid: e172c2a4-f29e-4034-8232-e7dc6f83689f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2662
'function' : cannot convert 'this' pointer from 'type1' to 'type2'  
  
 The compiler could not convert the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 This error can be caused by invoking a non-<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function on a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  Possible resolutions:  
  
-   Remove the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> from the object declaration.  
  
-   Add <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the member function.  
  
 The following sample generates C2662:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When compiling with **/clr**, you cannot call a function on a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> qualified managed type. You cannot declare a const member function of a managed class, so you cannot call methods on const managed objects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample generates C2662:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>