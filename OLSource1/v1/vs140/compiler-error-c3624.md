---
title: "Compiler Error C3624"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C3624
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3624
ms.assetid: eaac6a4f-eb11-4e4d-ab12-124ba995c5cf
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3624
'type': use of this type requires a reference to assembly 'assembly'  
  
 An assembly (reference) needed to compile your code was not specified; pass the assembly to the [#using](../vs140/sharpusing-directive--c---.md) directive.  
  
 The following sample generates C3624:  
  
```  
// C3624.cpp  
// compile with: /clr /c  
#using <System.Windows.Forms.dll>  
  
// Uncomment the following 2 lines to resolve.  
// #using <System.dll>  
// #using <System.Drawing.dll>  
  
using namespace System;  
  
public ref class MyForm : public Windows::Forms::Form {};   // C3624  
```  
  
 The following sample generates C3624:  
  
```  
// C3624_b.cpp  
// compile with: /clr:oldSyntax /c  
#using <System.Windows.Forms.dll>  
  
// Uncomment the following 2 lines to resolve.  
// #using <System.dll>  
// #using <System.Drawing.dll>  
  
using namespace System;  
  
public __gc class MyForm : public Windows::Forms::Form {};   // C3624  
```