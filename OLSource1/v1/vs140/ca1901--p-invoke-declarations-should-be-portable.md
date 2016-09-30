---
title: "CA1901: P-Invoke declarations should be portable"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "CA1901: P/Invoke declarations should be portable"
f1_keywords: 
  - "CA1901"
  - "PInvokeDeclarationsShouldBePortable"
helpviewer_keywords: 
  - "CA1901"
  - "PInvokeDeclarationsShouldBePortable"
ms.assetid: 90361812-55ca-47f7-bce9-b8775d3b8803
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1901: P-Invoke declarations should be portable
|||  
|-|-|  
|TypeName|PInvokeDeclarationsShouldBePortable|  
|CheckId|CA1901|  
|Category|Microsoft.Portability|  
|Breaking Change|Breaking - If the P/Invoke is visible outside the assembly. Non Breaking - If the P/Invoke is not visible outside the assembly.|  
  
## Cause  
 This rule evaluates the size of each parameter and the return value of a P/Invoke and verifies that their size, when marshaled to unmanaged code on 32-bit and 64-bit platforms, is correct. The most common violation of this rule is to pass a fixed-sized integer where a platform-dependent, pointer-sized variable is required.  
  
## Rule Description  
 Either of the following scenarios violates this rule occurs:  
  
-   The return value or parameter is typed as a fixed-size integer when it should be typed as an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
-   The return value or parameter is typed as an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when it should be typed as a fixed-size integer.  
  
## How to Fix Violations  
 You can fix this violation by using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to represent handles instead of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## When to Suppress Warnings  
 You should not suppress this warning.  
  
## Example  
 The following example demonstrates a violation of this rule.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter is declared as an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is 4 bytes wide on a 32-bit platform and 8 bytes wide on a 64-bit platform. In the unmanaged declaration that follows, you can see that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a 4-byte unsigned integer on all platforms.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 To fix the violation, change the declaration to the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Portability Warnings](../vs140/portability-warnings.md)