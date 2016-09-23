---
title: "Code Analysis for C-C++ Overview"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
H1: Code Analysis for C/C++ Overview
helpviewer_keywords: 
  - annotations, code analysis
  - build integration, code analysis
  - C/C++ code analysis
  - IDE, code analysis
  - pragma directive, code analysis
  - code analysis, C/C++
  - code analysis tool
  - command line, code analysis
  - C++, code analysis
  - check-in policies, code analysis
  - #pragma directives, code analysis
  - C, code analysis
ms.assetid: 81f0c9e8-f471-4de5-aac4-99db336a8809
caps.latest.revision: 29
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Code Analysis for C-C++ Overview
The C/C++ Code Analysis tool provides information to developers about possible defects in their C/C++ source code. Common coding errors reported by the tool include buffer overruns, un-initialized memory, null pointer dereferences, and memory and resource leaks.  
  
## IDE (integrated development environment) Integration  
 To make it natural for developers to use the analysis tool, it is fully integrated within the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] IDE. During the build process, any warnings generated for the source code appear in the Error List. You can navigate to source code that caused the warning, and you can view additional information about the cause and possible solutions of the issue.  
  
## #pragma Support  
 Developers can use the `#pragma` directive to treat warnings as errors; enable or disable warnings, and suppress warnings for individual lines of code. For more information, see [How to: Enable and Disable Code Analysis for Specific C/C++ Warnings](assetId:///910b8518-71f1-4b2e-b012-70647795642a).  
  
## Annotation Support  
 Annotations improve the accuracy of the code analysis. Annotations provide additional information about pre- and post- conditions on function parameters and return types. For more information, see [How to: Specify Additional Code Information](../vs140/how-to--specify-additional-code-information-by-using-__analysis_assume.md)  
  
## Run analysis tool as part of check-in policy  
 You might want to require that all source code check-ins satisfy certain policies. In particular, you want to make sure that analysis was run as a step of the most recent local build. For more information about enabling a code analysis check-in policy, see [Creating and Using Code Analysis Check-in Policies](../vs140/creating-and-using-code-analysis-check-in-policies.md)  
  
## Team Build Integration  
 You can use the integrated features of the build system to run code analysis tool as a step of the [!INCLUDE[esprtfs](../vs140/includes/esprtfs_md.md)] build process. For more information, see [Build the application](assetId:///a971b0f9-7c28-479d-a37b-8fd7e27ef692).  
  
## Command-line support  
 In addition to the full integration within the development environment, developers can also use the analysis tool from the command line, as shown in the following example:  
  
 `C:\>cl /analyze Sample.cpp`