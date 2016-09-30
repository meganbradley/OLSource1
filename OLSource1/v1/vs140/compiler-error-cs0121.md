---
title: "Compiler Error CS0121"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0121"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0121"
ms.assetid: 316cb77e-a500-4129-ae1b-e68b9188fd3e
caps.latest.revision: 11
---
# Compiler Error CS0121
The call is ambiguous between the following methods or properties: 'method1' and 'method2'  
  
 Due to implicit conversion, the compiler was not able to call one form of an overloaded method. You can resolve this error in the following ways:  
  
-   Specify the method parameters in such a way that implicit conversion does not take place.  
  
-   Remove all overloads for the method.  
  
-   Cast to proper type before calling method.  
  
## Example  
 The following sample generates CS0121:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example produces CS0121 in [!INCLUDE[vs_current_ext]()] but not in Visual Studio 2005:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>