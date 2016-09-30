---
title: "Error creating assembly manifest: &lt;error message&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30140"
  - "vbc30140"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30140"
ms.assetid: 1beb5aa0-7b79-4c85-946b-5c2d0a41d1d2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error creating assembly manifest: &lt;error message&gt;
The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler calls the Assembly Linker (Al.exe, also known as Alink) to generate an assembly with a manifest. The linker has reported an error in the pre-emission stage of creating the assembly.  
  
 This can occur if there are problems with the key file or the key container specified. To fully sign an assembly, you must provide a valid key file that contains information about the public and private keys. To delay sign an assembly, you must select the **Delay sign only** check box and provide a valid key file that contains information about the public key information. The private key is not necessary when an assembly is delay-signed. For more information, see [How to: Sign an Assembly (Visual Studio)](assetId:///f468a7d3-234c-4353-924d-8e0ae5896564).  
  
 **Error ID:** BC30140  
  
### To correct this error  
  
1.  Examine the quoted error message and consult the topic [Al.exe Tool Errors and Warnings](assetId:///7f125d49-0a03-47a6-9ba9-d61a679a7d4b) for error AL1019 further explanation and advice  
  
2.  If the error persists, gather information about the circumstances and notify Microsoft Product Support Services.  
  
## See Also  
 [How to: Sign an Assembly (Visual Studio)](assetId:///f468a7d3-234c-4353-924d-8e0ae5896564)   
 [Signing Page, Project Designer](../vs140/signing-page--project-designer.md)   
 [Assembly Linker (Al.exe)](assetId:///b5382965-0053-47cf-b92f-862860275a01)   
 [Al.exe Tool Errors and Warnings](assetId:///7f125d49-0a03-47a6-9ba9-d61a679a7d4b)   
 [Product Support and Accessibility](../vs140/talk-to-us.md)