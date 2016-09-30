---
title: "Modeling SDK for Visual Studio - Domain-Specific Languages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language Tools"
  - "Domain-Specific Language"
ms.assetid: 17a531e2-1964-4a9d-84fd-6fb1b4aee662
caps.latest.revision: 81
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Modeling SDK for Visual Studio - Domain-Specific Languages
By using the Modeling SDK for [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] (MSDK), you can create powerful model-based development tools that you can integrate into [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. As an example, the UML tools are created using MSDK. In the same manner, you can create one or more model definitions and integrate them into a set of tools.  
  
 At the heart of MSDK is the definition of a model that you create to represent concepts in your business area. You can surround the model with a variety of tools, such as a diagrammatic view, the ability to generate code and other artifacts, commands for transforming the model, and the ability to interact with code and other objects in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. As you develop the model, you can combine it with other models and tools to form a powerful toolset that is centered on your development.  
  
 MSDK lets you develop a model quickly in the form of a domain-specific language (DSL). You begin by using a specialized editor to define a schema or abstract syntax together with a graphical notation. From this definition, VMSDK generates:  
  
-   A model implementation with a strongly-typed API that runs in a transaction-based store.  
  
-   A tree-based explorer.  
  
-   A graphical editor in which users can view the model or parts of it that you define.  
  
-   Serialization methods that save your models in readable XML.  
  
-   Facilities for generating program code and other artifacts using text templating.  
  
 You can customize and extend all of these features. Your extensions are integrated in such a way that you can still update the DSL definition and re-generate the features without losing your extensions.  
  
## Samples and the Latest Information  
 [Download the Modeling SDK for Visual Studio 2015](http://www.microsoft.com/download/details.aspx?id=48148)  
  
 [Samples](http://go.microsoft.com/fwlink/?LinkId=186128) for the Modeling SDK for Visual Studio.  
  
 For guidance on advanced techniques and troubleshooting, visit [Visual Studio DSL & Modeling Tools Extensibility forum](http://go.microsoft.com/fwlink/?LinkID=186074).  
  
## In This Section  
 [Getting Started with Domain-Specific Languages](../vs140/getting-started-with-domain-specific-languages.md)  
  
 [Understanding Models, Classes and Relationships](../vs140/understanding-models--classes-and-relationships.md)  
  
 [How to Define a Domain-Specific Language](../vs140/how-to-define-a-domain-specific-language.md)  
  
 [Customizing Domain-Specific Languages](../vs140/customizing-and-extending-a-domain-specific-language.md)  
  
 [Adding Validation to DSLs](../vs140/validation-in-a-domain-specific-language.md)  
  
 [Programming Domain-Specific Languages](../vs140/writing-code-to-customise-a-domain-specific-language.md)  
  
 [Generating Code in DSLs](../vs140/generating-code-from-a-domain-specific-language.md)  
  
 [Understanding the Generated Code](../vs140/understanding-the-dsl-code.md)  
  
 [Customizing Serialization Behavior](../vs140/customizing-file-storage-and-xml-serialization.md)  
  
 [Deploying DSLs](../vs140/deploying-domain-specific-language-solutions.md)  
  
 [Creating a Windows Forms-based DSL](../vs140/creating-a-windows-forms-based-domain-specific-language.md)  
  
 [Creating a WPF-based DSL](../vs140/creating-a-wpf-based-domain-specific-language.md)  
  
 [Customizing the DSL Designer](../vs140/how-to--extend-the-domain-specific-language-designer.md)  
  
 [Supported VS Editions](../vs140/supported-visual-studio-editions-for-visualization---modeling-sdk.md)  
  
 [How to Migrate](../vs140/how-to--migrate-a-domain-specific-language-to-a-new-version.md)  
  
 [API Reference for VSVSMSDK](../vs140/api-reference-for-modeling-sdk-for-visual-studio.md)