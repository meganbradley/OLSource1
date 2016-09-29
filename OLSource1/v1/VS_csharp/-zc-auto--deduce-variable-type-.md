---
title: "-Zc:auto (Deduce Variable Type)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Zc:auto (Deduce Variable Type)"
f1_keywords: 
  - "/Zc:auto"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Zc compiler options (C++)"
  - "Deduce variable type (C++)"
  - "/Zc compiler options (C++)"
  - "Zc compiler options (C++)"
ms.assetid: 5f5bc102-44c3-4688-bbe1-080594dcee5c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Zc:auto (Deduce Variable Type)
The **/Zc:auto[-]** compiler option tells the compiler how to use the [auto keyword](../VS_csharp/auto-keyword.md) to declare variables. If you specify the default option, **/Zc:auto**, the compiler deduces the type of the declared variable from its initialization expression. If you specify **/Zc:auto-**, the compiler allocates the variable to the automatic storage class.  
  
## Syntax  
  
```  
/Zc:auto[-]  
```  
  
## Remarks  
 The C++ standard defines an original and a revised meaning for the `auto` keyword. Before [!INCLUDE[cpp_dev10_long](../VS_csharp/includes/cpp_dev10_long_md.md)], the keyword declares a variable in the automatic storage class; that is, a variable that has a local lifetime. Starting with [!INCLUDE[cpp_dev10_long](../VS_csharp/includes/cpp_dev10_long_md.md)], the keyword deduces the type of a variable from the declaration's initialization expression. Use the **/Zc:auto[-]** compiler option to tell the compiler to use the original or revised meaning of the `auto` keyword.  
  
 The compiler issues an appropriate diagnostic message if your use of the `auto` keyword contradicts the current compiler option. For more information, see [auto Keyword](../VS_csharp/auto-keyword.md). For more information about conformance issues with Visual C++, see [Nonstandard Behavior](../VS_csharp/nonstandard-behavior.md).  
  
### To set this compiler option in Visual Studio  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../VS_csharp/working-with-project-properties.md).  
  
2.  Click the **Configuration Properties** node.  
  
3.  Click the **C/C++** node.  
  
4.  Click the **Command Line** node.  
  
5.  Add **/Zc:auto** or **/Zc:auto-** to the **Additional options:** pane.  
  
## See Also  
 [/Zc (Conformance)](../VS_csharp/-zc--conformance-.md)   
 [auto Keyword](../VS_csharp/auto-keyword.md)