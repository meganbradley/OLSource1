---
title: "Improve Code Quality"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio ALM"
  - "team-based development"
ms.assetid: 73baa961-c21f-43fe-bb92-3f59ae9b5945
caps.latest.revision: 43
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Improve Code Quality
What is code quality? Correctness, maintainability, and even elegance are all involved in creating great code. However you define it, Visual Studio test tools can help you and your team to develop and sustain high standards of code excellence.  
  
 **Requirements**  
  
-   Some of the tools and features that are described in this section are available only in specific editions of Visual Studio—they aren’t universally available in Visual Studio. We list the specific edition requirements in the documentation for these tools and features.  
  
## In this section  
 In the following table, you can find descriptions of common tasks and links to more information about how you can successfully complete those tasks.  
  
|||  
|-|-|  
|[Verifying Code by Using Unit Tests](../VS_csharp/unit-test-your-code.md)|Test Explorer makes it easy to integrate unit tests in your development practice. You can use the Microsoft unit test framework or one of several third-party and open source frameworks.|  
|[Analyzing Application Quality by Using Code Analysis Tools](../VS_csharp/analyzing-application-quality-by-using-code-analysis-tools.md)|Static code analysis tools find design, usage, maintainablity, and style issues in C++ and managed code. Many of these issues can lead to bugs that are hard to reproduce in standard testing environment.|  
|[Measuring Complexity and Maintainability of Managed Code](../VS_csharp/measuring-complexity-and-maintainability-of-managed-code.md)|Code metrics is a set of software measures that provide developers better insight into the code they are developing. The metrics include a maintainability index for functions and classes, cyclomatic complexity of functions, the inheritance depth of classes, and the amount of coupling among classes.|  
|[Finding Duplicate Code by using Code Clone Detection](../VS_csharp/finding-duplicate-code-by-using-code-clone-detection.md)|The code clone tool searches for duplicate or highly similar code in Visual C# and Visual Basic projects throughout your Visual Studio solution. You can often refactor the code to eliminate the duplication for a more maintainable solution.|  
|[PreEmptive Analytics for Team Foundation Server](http://msdn.microsoft.com/library/hh973124.aspx)|PreEmptive Analytics for TFS CE helps you to integrate feedback-driven development processes into your development workflow. Your applications automatically send back exception report data to the PreEmptive Analytics service as errors occur during their execution. The service then creates or updates work items in Microsoft Team Foundation Server based on rules and thresholds you define.|  
|[PreEmptive Dotfuscator and Analytics CE](assetId:///25d195d4-9f76-4dcc-9fbb-eeb9bdca9a3f)|PreEmptive Dotfuscator is a.NET obfuscator and compactor that helps protect programs against reverse engineering while making them smaller and more efficient.|  
  
## Related Scenarios  
 [Adopting Visual Studio and Team Foundation Server for Application Lifecycle Management](assetId:///7ae9182f-4762-4bd3-b238-39ce987932e5)  
 If you are unfamiliar with Visual Studio Team Foundation, you can learn more about how you can use it in a team development environment to improve productivity and reduce risks that are associated with application development.  
  
 [Designing the Application](../VS_csharp/analyze-and-model-your-architecture.md)  
 You can use [!INCLUDE[vsPreExt](../VS_csharp/includes/vspreext_md.md)] to manage the challenges and complexity of designing software. [!INCLUDE[vsPreShort](../VS_csharp/includes/vspreshort_md.md)] lets you visually model your application, both as it exists now and as you want it to exist in the future. You can create and maintain diagrams to help you visualize the logical models of your application at the same time that they map to the physical models; this enables you to change, validate, and analyze the software that is "under design."  
  
 [Testing the application](assetId:///796b7d6d-ad45-4772-9719-55eaf5490dac)  
 You can use [!INCLUDE[vsPreShort](../VS_csharp/includes/vspreshort_md.md)] and [!INCLUDE[vsUltShort](../VS_csharp/includes/vsultshort_md.md)] to be more productive throughout the testing life cycle. [!INCLUDE[vsPreShort](../VS_csharp/includes/vspreshort_md.md)] or [!INCLUDE[vsUltShort](../VS_csharp/includes/vsultshort_md.md)] let you plan your testing effort. You can create, manage, edit, and run both manual and automated tests. You can also review your testing progress based on your plan.  
  
 [Build the application](assetId:///a971b0f9-7c28-479d-a37b-8fd7e27ef692)  
 You can use [!INCLUDE[esprbuild](../VS_csharp/includes/esprbuild_md.md)] to create and manage automated builds for your code. [!INCLUDE[esprbuild](../VS_csharp/includes/esprbuild_md.md)] lets you create drop servers to deploy builds. In addition, you can analyze build trends.  
  
 [Track work using Visual Studio Online or Team Foundation Server](assetId:///52aa8bc9-fc7e-4fae-9946-2ab255ca7503)  
 You can use [!INCLUDE[vststfsLong](../VS_csharp/includes/vststfslong_md.md)] to plan and track your projects whether you use the agile process, the formal process, or a variation on those processes. By planning your projects, tracking your progress against the plan, and making necessary adjustments, you can reduce risks, avoid unpleasant surprises, and manage the cost of your projects.