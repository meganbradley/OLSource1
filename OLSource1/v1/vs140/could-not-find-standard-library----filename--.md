---
title: "Could not find standard library: &#39;&lt;filename&gt;&#39;"
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
  - "vbc40049"
  - "bc40049"
helpviewer_keywords: 
  - "BC40049"
ms.assetid: a292f97e-4852-4021-b300-7ab47beb95d9
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Could not find standard library: &#39;&lt;filename&gt;&#39;
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is unable to find or open one of the standard DLL libraries needed for compilation and linking.  
  
 The unusable library is most likely to be either mscorlib.dll or microsoft.visualbasic.dll.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40049  
  
### To correct this error  
  
1.  Verify that the file cited in the error message is present on the hard disk from which you are running [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. Normally the standard libraries should reside in a subdirectory under \WINNT\Microsoft.NET\Framework or \WINDOWS\Microsoft.NET\Framework.  
  
2.  Verify that neither the file nor the directory has a setting or attribute that prevents read access by [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
3.  Verify that the file name and extension are spelled correctly. Capitalization is not a concern.  
  
4.  If the file appears to be properly placed and accessible, it might be corrupted on the disk. Reinstall [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] if possible.  
  
5.  Note the exact file name and extension and contact Microsoft Product Support Services.  
  
## See Also  
 [Building from the Command Line (Visual Basic)](../vs140/building-from-the-command-line--visual-basic-.md)   
 [How to: Invoke the Command-Line Compiler](../vs140/how-to--invoke-the-command-line-compiler--visual-basic-.md)   
 [Getting Help from Microsoft Product Support Services (Visual Studio)](../vs140/talk-to-us.md)