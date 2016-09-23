---
title: "CLS Compliance Warning CLS01103"
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
  - CLS01103
dev_langs: 
  - C++
helpviewer_keywords: 
  - CLS01103
ms.assetid: 0d0aebaa-441a-4dc0-9745-8de3a551204b
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CLS Compliance Warning CLS01103
All types appearing in a signature shall be CLS-compliant  
  
 If a type is CLS compliant, then all fields, unless marked not CLS compliant, must be of CLS compliant types.  
  
 For more information CLS compliance checking, see [CLS Compliant Assemblies](assetId:///3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
```  
// CLS01103.cpp  
// compile with: /clr /LD  
// CLS01103 expected  
using namespace System;  
using namespace System::Reflection;  
[assembly:CLSCompliant (true)];  
[assembly:AssemblyKeyFile("clscompliance.snk")];  
  
[CLSCompliant(false)]  
public ref class NotCompliantType {};  
  
// Ref class  
public ref class One {  
public:  
   NotCompliantType^ Member1;   // CLS01103  
   static NotCompliantType^ Member2;   // CLS01103  
};  
```