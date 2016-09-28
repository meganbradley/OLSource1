---
title: "Legacy Language Service Overview"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "language services [managed package framework], about language services"
ms.assetid: bb44e27b-d228-463c-b2cf-cd5c24c7c1b5
caps.latest.revision: 21
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Legacy Language Service Overview
A language service provides editor support that lets you implement certain [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] features. The Managed Package Framework (MPF) language service classes provide full support for frequently-used features and partial support for other features.  
  
## Fully Supported Features in the MPF  
 The MPF language service classes support the following features:  
  
-   Syntax highlighting  
  
-   Outlining  
  
-   Commenting blocks of code  
  
-   Brace matching  
  
-   Code snippets  
  
-   Custom document properties  
  
-   IntelliSense parameter information  
  
-   IntelliSense Quick Info  
  
-   IntelliSense member completion  
  
-   IntelliSense word completion  
  
## Partially Supported Features in the MPF  
 The MPF provides only partial support for the following features. This means that you must implement the methods that are called by the MPF.  
  
-   Reformatting code. You supply the code that implements the reformatting.  
  
-   Validating breakpoints by identifying valid code spans. You supply the code that identifies the code spans.  
  
-   Supporting the debugger **Autos** window for displaying variables. You supply the code that determines what to show in the window.  
  
-   Supporting the **Navigation bar** for quick navigation between types and members. You implement and return a helper class that populates the lists in the **Navigation bar** combo boxes.  
  
## Implementation  
 You must complete several steps to implement the language service itself and the language service features that you want to support for your language. These steps are discussed in the following topics:  
  
-   [Implementing a Language Service (Managed Package Framework)](../vs140/implementing-a-legacy-language-service2.md)  
  
-   [Registering a Language Service (Managed Package Framework)](../vs140/registering-a-legacy-language-service1.md)  
  
-   [Syntax Highlighting (Managed Package Framework)](../vs140/syntax-colorizing-in-a-legacy-language-service.md)  
  
-   [Brace Matching (Managed Package Framework)](../vs140/brace-matching-in-a-legacy-language-service.md)  
  
-   [Outlining (Managed Package Framework)](../vs140/outlining-in-a-legacy-language-service.md)  
  
-   [Commenting Blocks of Code (Managed Package Framework)](../vs140/commenting-code-in-a-legacy-language-service.md)  
  
-   [Reformatting Code (Managed Package Framework)](../vs140/reformatting-code-in-a-legacy-language-service.md)  
  
-   [Custom Document Properties (Managed Package Framework)](../vs140/custom-document-properties-in-a-legacy-language-service.md)  
  
-   [Supporting Code Snippets (Managed Package Framework)](../vs140/support-for-code-snippets-in-a-legacy-language-service.md)  
  
-   [Supporting the Navigation Bar (Managed Package Framework)](../vs140/support-for-the-navigation-bar-in-a-legacy-language-service.md)  
  
-   [Supporting IntelliSense Complete Word (Managed Package Framework)](../vs140/word-completion-in-a-legacy-language-service.md)  
  
-   [Supporting IntelliSense Member Completion (Managed Package Framework)](../vs140/member-completion-in-a-legacy-language-service.md)  
  
-   [Supporting IntelliSense Parameter Info (Managed Package Framework)](../vs140/parameter-info-in-a-legacy-language-service2.md)  
  
-   [Supporting IntelliSense Quick Info (Managed Package Framework)](../vs140/quick-info-in-a-legacy-language-service.md)  
  
-   [Supporting the Autos Window (Managed Package Framework)](../vs140/support-for-the-autos-window-in-a-legacy-language-service.md)  
  
-   [Validating Breakpoints (Managed Package Framework)](../vs140/validating-breakpoints-in-a-legacy-language-service.md)  
  
## See Also  
 [Language Service in the Managed Package Framework](../vs140/implementing-a-legacy-language-service1.md)   
 [Language Services](../vs140/legacy-language-service-extensibility.md)