---
title: "Troubleshooting Exceptions: System.Runtime.InteropServices.SafeArrayRankMismatchException"
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
  - "EHSafeArrayRankMismatch"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "SafeArrayRankMismatchException class"
ms.assetid: 6c69355c-8bfd-49bb-acad-b4d7236ae2e7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Runtime.InteropServices.SafeArrayRankMismatchException
A <xref:System.Runtime.InteropServices.SafeArrayRankMismatchException*> exception is thrown when the rank of an incoming SAFEARRAY does not match the rank specified in the managed signature.  
  
## Associated Tips  
 **Make sure your array has the required number of dimensions.**  
 Because the rank and bounds of a safe array cannot be determined from the type library, the rank is assumed to equal 1, and the lower bound is assumed to equal 0. The rank and bounds must be defined in the managed signature produced by the [Type Library Importer (Tlbimp.exe)](assetId:///ec0a8d63-11b3-4acd-b398-da1e37e97382).  
  
## See Also  
 <xref:System.Runtime.InteropServices.SafeArrayRankMismatchException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Default Marshaling for Arrays](assetId:///8a3cca8b-dd94-4e3d-ad9a-9ee7590654bc)   
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)