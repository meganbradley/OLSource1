---
title: "XML literals and XML axis properties are not available during this debugging session because they are not used in this assembly"
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
  - "vbc31196"
  - "bc31196"
helpviewer_keywords: 
  - "BC31196"
ms.assetid: 36be5c92-dd6b-41d4-894a-2bd71d772092
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML literals and XML axis properties are not available during this debugging session because they are not used in this assembly
An XML literal or XML axis property has been referenced in the **Watch** or **Immediate** window during a debugging session in which XML in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] features are not available. This is the case for an assembly that either does not use the XML in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] features or is a release build.  
  
 **Error ID:** BC31196  
  
### To correct this error  
  
-   Start a new debugging session using the debug build of the assembly.  
  
## See Also  
 [Debugging Your Visual Basic Application](../vs140/debugging-your-visual-basic-application.md)   
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)