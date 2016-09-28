---
title: "Building External Projects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "external projects"
  - "Visual C++ projects, external projects"
  - "builds [C++], external projects"
  - "projects [C++], external projects"
  - "Makefile projects, external projects"
ms.assetid: 650b7803-ea91-489d-bee3-8f3e990e223c
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Building External Projects
An external project is a Visual C++ project that uses a makefile or other facilities that are outside (foreign or external to) the Visual C++ development environment.  
  
 If you have an external project (for example, a makefile project) that you want to build in the Visual C++ development environment, create a Makefile project and specify your project's build command and output in the Makefile Application Wizard. For more information, see [Creating a Makefile Project](../vs140/creating-a-makefile-project.md).  
  
 Note that Visual C++ no longer supports the ability to export a makefile for the active project from the development environment. Use [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md) to build Visual Studio projects at the command line.  
  
## See Also  
 [Building C++ Projects in Visual Studio](../vs140/building-c---projects-in-visual-studio.md)