---
title: "Compiler Warning (level 1) CS1616"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1616"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1616"
ms.assetid: 7fb99eba-8da3-4c1b-81a3-bc4a57822e45
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1616
Option 'option' overrides attribute 'attribute' given in a source file or added module  
  
 This warning occurs if the assembly attributes <xref:System.Reflection.AssemblyKeyFileAttribute*> or <xref:System.Reflection.AssemblyKeyNameAttribute*> found in source conflict with the [/keyfile](../vs140/-keyfile--csharp-compiler-options-.md) or [/keycontainer](../vs140/-keycontainer--csharp-compiler-options-.md) command line option or key file name or key container specified in the Project Properties.  
  
 For the example below, assume you have a key file  named `cs1616.snk`. This file could be generated with the command line:  
  
```  
sn –k CS1616.snk  
```  
  
 The following sample generates CS1616:  
  
```  
// CS1616.cs  
// compile with: /keyfile:cs1616.snk  
using System.Reflection;  
  
// To fix the error, remove the next line  
[assembly: AssemblyKeyFile("cs1616b.snk")]  // CS1616  
  
class C  
{  
  public static void Main()  
  {  
  }  
}  
```