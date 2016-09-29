---
title: "Customizing T4 Text Transformation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, API"
  - "text templates, custom hosts"
ms.assetid: 62cd9a3c-a6e1-4b29-93f5-f2a0cf47dc92
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Customizing T4 Text Transformation
Text templates are a feature of [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] that allow you to generate program code or other text files through a transformation process. Using [!INCLUDE[vssdk_current_short](../VS_csharp/includes/vssdk_current_short_md.md)], you can extend the default template transformation process by customizing the text template directive processor or the text template host.  
  
## In This Section  
 [The Text Template Transformation Process](../VS_csharp/the-text-template-transformation-process.md)  
 Describes how text transformation works, and explains the role of the template host and the directive processors.  
  
 [Creating Custom Text Template Directive Processors](../VS_csharp/creating-custom-t4-text-template-directive-processors.md)  
 The directive processor deals with directives in your template, such as `<#@template#>.` It runs during the compilation of the template, and can load assemblies and other resources. It can also insert code that will load resources at runtime. By defining your own directive processor, you can reduce the complexity of your templates.  
  
 [Invoking Text Transformation in a Visual Studio Extension](../VS_csharp/invoking-text-transformation-in-a-vs-extension.md)  
 If you are writing a [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] Extension such as a menu command or event handler, your extension can use the Text Templating Service to transform any text template. You can pass parameter data into the template by using the Session object, and get the values from within the template by using the `<#@parameter#>` directive.  
  
 [Creating Custom Text Template Hosts](../VS_csharp/processing-text-templates-by-using-a-custom-host.md)  
 When the code of the text template executes, the host provides access to external files and the state of the application. For example, the host that runs text transformations in [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] can provide access to solution explorer. It also displays errors in the error message window. If you want to run text transformations in a different context, you can define your own host that provides access to the services available in that context.  
  
 If you are writing a [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] Extension, consider using the existing text transformation service instead of writing your own host. For more information, see [Invoking Text Transformation in a Visual Studio Extension](../VS_csharp/invoking-text-transformation-in-a-vs-extension.md).  
  
## Reference  
 [Text Template Structure](../VS_csharp/writing-a-t4-text-template.md)  
  
 Provides the syntax of text template directives and control blocks.