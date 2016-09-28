---
title: "Interoperability (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "COM interop"
  - "interoperability"
  - "platform invoke, accessing APIs with C#"
  - "C# language, interoperability"
ms.assetid: 238bb95a-e962-4026-bbd5-197055bdb8ee
caps.latest.revision: 35
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interoperability (C# Programming Guide)
Interoperability enables you to preserve and take advantage of existing investments in unmanaged code. Code that runs under the control of the common language runtime (CLR) is called *managed code*, and code that runs outside the CLR is called *unmanaged code*. COM, COM+, C++ components, ActiveX components, and Microsoft Win32 API are examples of unmanaged code.  
  
 The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] enables interoperability with unmanaged code through platform invoke services, the <xref:System.Runtime.InteropServices*> namespace, C++ interoperability, and COM interoperability (COM interop).  
  
## In This Section  
 [Interoperability Overview (C# Programming Guide)](../vs140/interoperability-overview--csharp-programming-guide-.md)  
 Describes methods to interoperate between C# managed code and unmanaged code.  
  
 [How to Access Office Interop Objects by Using Visual C# 2010 Features](../vs140/how-to--access-office-interop-objects-by-using-visual-csharp-features--csharp-programming-guide-.md)  
 Describes features that are introduced in Visual C# 2010 to facilitate Office programming.  
  
 [How to: Use Indexed Properties in COM Interop Programming](../vs140/how-to--use-indexed-properties-in-com-interop-programming--csharp-programming-guide-.md)  
 Describes how to use indexed properties to access COM properties that have parameters.  
  
 [How to: Use Platform Invoke to Play a Wave File (C# Programming Guide)](../vs140/how-to--use-platform-invoke-to-play-a-wave-file--csharp-programming-guide-.md)  
 Describes how to use platform invoke services to play a .wav sound file on the Windows operating system.  
  
 [Walkthrough: Office Programming (C# and Visual Basic)](../vs140/walkthrough--office-programming--csharp-and-visual-basic-.md)  
 Shows how to create an Excel workbook and a Word document that contains a link to the workbook.  
  
 [Example COM Class (C# Programming Guide)](../vs140/example-com-class--csharp-programming-guide-.md)  
 Demonstrates how to expose a C# class as a COM object.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [Marshal.ReleaseComObject](assetId:///M:System.Runtime.InteropServices.Marshal.ReleaseComObject(System.Object)?qualifyHint=True&autoUpgrade=True)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)   
 [Walkthrough: Office Programming (C# and Visual Basic)](../vs140/walkthrough--office-programming--csharp-and-visual-basic-.md)