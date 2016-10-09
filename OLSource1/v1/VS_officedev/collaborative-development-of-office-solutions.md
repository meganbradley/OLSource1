---
title: "Collaborative Development of Office Solutions"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office applications [Office development in Visual Studio], collaborative development"
  - "Office development in Visual Studio, collaboration"
  - "source control [Office development in Visual Studio]"
  - "collaborative development [Office development in Visual Studio]"
ms.assetid: c493354b-17d3-4e50-85f0-968b104bc978
caps.latest.revision: 29
ms.author: "normesta"
manager: "ghogen"
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
# Collaborative Development of Office Solutions
  Multiple developers can work on an Office project in the same way that they collaborate on other Visual Studio projects. Visual Studio correctly locates the Microsoft Office installation on each computer, even if Office is installed in different locations. However, there are some important considerations to be aware of.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
## Debug Properties Are Not Shared  
 Debug properties are not shared among multiple users under source control. Visual Basic and Visual C# projects store the debugging properties in a user-specific file (*ProjectName*.vbproj.user or *ProjectName*.csproj.user), and this file is not under source control. If more than one person is debugging, each person must enter debug properties manually.  
  
 If the project is housed on a network share instead of in source control, some extra steps must be taken to enable the collaborating developers to open the solution and test the assembly.  
  
## Source Control Requires Checking Out All Files  
 If you use source control for your projects, you should check out all of the files under a code file in **Solution Explorer** (such as the ThisDocument, ThisWorkbook, or ThisAddIn code files) every time you change the code file, even the files that are hidden by default. If you check out only the top-level code file, your changes might be lost.  
  
 After you make your changes, check all of the files back in. For more information about hidden code files in projects, see [Office Projects in the Visual Studio Environment](../VS_officedev/office-projects-in-the-visual-studio-environment.md).  
  
## Security for Informal Collaboration on a Network  
 For all document-level solutions that are in a network location (such as \\\\*Servername*\\*Sharename*), the fully qualified location must be added to the trusted folder list in the Microsoft Office application that you are working with. Select the option to include the subdirectories under the main folder, or specifically add debug and build folders to the trusted folder list. For more information about how to do this, see [Granting Trust to Documents](../VS_officedev/granting-trust-to-documents.md).  
  
 The temporary certificates that are automatically generated at build time are not secured by passwords. The certificates contain the developer's login name and other personal information. If you deploy customizations that are signed by temporary certificates, others might be able to access this information.  
  
## See Also  
 [Securing Office Solutions](../VS_officedev/securing-office-solutions.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [Building Office Solutions](../VS_officedev/building-office-solutions.md)  
  
  