---
title: "Compiler Warning (level 1) CS3009"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS3009"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3009"
ms.assetid: 41a1d2c4-d558-4066-8f3f-e9d2d69298a8
caps.latest.revision: 8
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Compiler Warning (level 1) CS3009
'type': base type 'type' is not CLS-compliant  
  
 A base type was marked as not having to be compliant with the Common Language Specification (CLS) in an assembly that was marked as being CLS compliant. Either remove the attribute that specifies the assembly is CLS compliant or remove the attribute that indicates the type is not CLS compliant. For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md).  
  
## Example  
 The following example generates CS3009:  
  
```  
// CS3009.cs  
  
using System;  
  
[assembly:CLSCompliant(true)]  
[CLSCompliant(false)]  
public class B  
{  
}  
  
public class C : B   // CS3009  
{  
    public static void Main () {}  
}  
```