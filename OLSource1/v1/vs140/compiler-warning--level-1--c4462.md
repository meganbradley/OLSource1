---
title: "Compiler Warning (level 1) C4462"
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
  - "C4462"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4462"
ms.assetid: 4e20aca4-293e-4c75-a83d-961c27ab7840
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4462
cannot determine the GUID of the type. Program may fail at runtime.  
  
 Warning C4462 occurs in a Windows Runtime app or component when a public <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has as one of its type parameters a reference to the enclosing class.  
  
 **This kind of code raises the warning:**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **To fix the error:**  
  
 There are two ways to work around the error. One way, shown in the next example, is to give the event internal accessibility so that it is available to code in the same executable but not to code in other Windows Runtime components.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If the event must be public, then you can use the other workaround, which is to expose it through a default interface:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A GUID of the type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is only used when the type is accessed from another component. The first workaround works because it can only be accessed within its own component after the workaround. Otherwise, the compiler has to assume the worst case and emit the warning.