---
title: "CLS Compliance Warning CLS03503"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CLS03503
dev_langs: 
  - C++
helpviewer_keywords: 
  - CLS03503
ms.assetid: 2d2e78db-5fcf-47e1-af1e-9545f28a306b
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CLS Compliance Warning CLS03503
The CLS does not allow publicly visible required modifiers (modreq), but does allow optional modifiers (modopt) they do not understand  
  
 The CLS does not allow publicly visible required modifiers (modreq), but does allow optional modifiers (modopt) they do not understand.  
  
 Make sure that fields do not contain types marked with publicly visible required modifiers.  
  
 For more information Common Language Subset (CLS) compliance checking, see [CLS Compliant Assemblies](assetId:///3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
 The following sample generates CLS03503:  
  
```  
// CLS03503.cpp  
// compile with: /clr /LD  
// CLS03503 expected  
using namespace System;  
using namespace System::Reflection;  
using namespace cli::language;  
[assembly:CLSCompliant (true)];  
[assembly:AssemblyKeyFile("clscompliance.snk")];  
  
public ref class MyClass {  
public:  
   volatile Int32 param;   // CLS03503  
   Int32 param2;   // OK  
};  
```