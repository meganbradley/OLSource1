---
title: "Compiler Warning (level 2) CS3021"
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
  - "CS3021"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3021"
ms.assetid: 89f09e4d-65b0-4422-86ea-85c7e05ac29b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS3021
'type' does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute  
  
 This warning occurs if `[CLSCompliant(false)]` appears on a class in an assembly which does not have an assembly-level CLSCompliant attribute set to true (i.e., the line `[assembly: CLSCompliant(true)]`). Since the assembly is not declaring itself CLS compliant, there is no need for anything within the assembly to declare itself non-compliant, since it is assumed to be non-compliant. For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3).  
  
 To get rid of this warning, remove the attribute or add the assembly level attribute.  
  
## Example  
 The following example generates CS3021:  
  
```  
// CS3021.cs  
using System;  
// Uncomment the following line to declare the assembly CLS Compliant,  
// and avoid the warning without removing the attribute on the class.  
//[assembly: CLSCompliant(true)]  
  
// Remove the next line to avoid the warning.  
[CLSCompliant(false)]               // CS3021  
public class C  
{  
    public static void Main()  
    {  
    }  
}  
```  
  
## See Also  
 [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6)