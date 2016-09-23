---
title: "Extending the Automation Model"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - automation object model, extending
ms.assetid: f09e1365-6291-41a7-b52b-9398270d9da2
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Extending the Automation Model
This section discusses how the automation model and the VSPackage model represent a two-prong approach to extensibility in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment. Extensibility is the capacity to enhance and extend the functionality of the IDE. Automation, on the one hand, refers to user-created code and tools that automate tasks in the existing environment and programmatically drive the IDE. VSPackages, on the other hand, let you add new functionality to the environment.  
  
 It is possible to combine automation and VSPackages in an extensibility application. For an example, see [Walkthrough: Extending Managed VSPackages with Automation](../vs140/walkthrough--extending-managed-vspackages-by-using-automation.md).  
  
 For an end-to-end sample of a language project system that supports the automation model, see the [IronPython sample](../vs140/vssdk-samples.md).  
  
## In This Section  
 [Automation Model](../vs140/automation-model.md)  
 Provides an overview of the automation model and discusses how the automation model lets you customize, adjust, and automate the environment.  
  
 [Contributing to the Automation Model](../vs140/contributing-to-the-automation-model.md)  
 Provides a more detailed view of the automation model and discusses the ways to provide automation for your VSPackage. This section also provides code examples that show how an automation consumer obtains the initial project automation objects.  
  
## Related Sections  
 [Visual Studio SDK and Automation](../Topic/Visual%20Studio%20SDK%20and%20Automation_deleted.md)  
 Discusses using automation, VSPackages, or a combination to create [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] extensibility applications.