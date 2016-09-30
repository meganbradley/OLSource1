---
title: "Compiler Error CS1613"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1613"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1613"
ms.assetid: 9d7ea9c8-9953-459f-a3f0-c7e65d1b9f59
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1613
The managed coclass wrapper class 'class' for interface 'interface' cannot be found (are you missing an assembly reference?)  
  
 An attempt was made to instantiate a COM object from an interface. The interface has the **ComImport** and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attributes, but the compiler cannot find the type given for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute.  
  
 To resolve this error, you can try one of the following:  
  
-   Add a reference to the assembly that has the coclass (most of the time the interface and coclass should be in the same assembly). See [/reference](../vs140/-reference--csharp-compiler-options-.md) or [Add Reference Dialog Box](assetId:///2feb0fe2-0805-4cc9-8cba-b0315849dfb7) for information.  
  
-   Fix the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute on the interface.  
  
 The following sample demonstrates correct usage of **CoClassAttribute**:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>