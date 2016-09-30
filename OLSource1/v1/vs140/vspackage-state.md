---
title: "VSPackage State"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "state, VSPackages"
  - "VSPackages, managing application state"
  - "state persistence"
ms.assetid: 6056a9ea-e7a8-481c-9fc8-340229fa12d9
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSPackage State
Many factors determine the set of persisted values, or state, of a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] application.  
  
-   Projects have project and configuration properties.  
  
-   Solutions have properties.  
  
-   User settings determine the size and position of document windows, tool windows, docking state, and keyboard shortcuts.  
  
-   Applications can have options that a user sets.  
  
-   Objects that an application creates can have properties of their own.  
  
 Here are some of the ways that a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] application state can be managed:  
  
-   Through the project and solution property pages.  
  
-   Through the **Import and Export Settings Wizard**, which enables a user to move settings from one computer to another.  
  
-   Through the **Options** dialog box, which includes options related to applications.  
  
-   Through the **Properties** window, which exposes properties of objects.  
  
-   Through Automation. An application can access VSPackage and object properties that have been exposed to Automation.  
  
 Underlying the application state are various persistence mechanisms that enable the application state to be saved and restored.  
  
## In This Section  
 [Support for State Persistence](../vs140/support-for-state-persistence.md)  
 Lists common strategies for saving, restoring, and resetting the state of a VSPackage.  
  
 [Support for Tools/Options Pages](../vs140/options-and-options-pages.md)  
 Introduces general and custom Options pages and explains how to implement them.  
  
 [Walkthrough: Creating an Options Page (C#)](../vs140/creating-an-options-page.md)  
 Explains how to create two Options pages, a simple page and a custom page.  
  
 [Support for Settings Categories](../vs140/support-for-settings-categories.md)  
 Discusses user settings and how they are created and persisted.  
  
 [Walkthrough: Creating a Settings Category (C#)](../vs140/creating-a-settings-category.md)  
 Explains how to create a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings category and use it to save values to and restore values from a settings file.  
  
 [Support for the Property Browser](../vs140/extending-properties-and-the-property-window.md)  
 Explains how to display and change the value of an object in the **Properties** window.  
  
 [Walkthrough: Exposing Properties to the Properties Window (C#)](../vs140/exposing-properties-to-the-properties-window.md)  
 Explains how to expose the public properties of an object to the **Properties** window.  
  
 [Support for Project and Configuration Properties](../vs140/support-for-project-and-configuration-properties.md)  
 Explains how to display and change project and configuration properties.  
  
 [Walkthrough: Retrieving Project Properties (C#)](../vs140/getting-project-properties.md)  
 Guides you through the steps of creating a managed VSPackage that displays project properties in a tool window.  
  
 [Walkthrough: Using the Settings Store](../vs140/using-the-settings-store.md)  
 Explains the Settings Store persistence mechanism and how to use it.  
  
## Related Sections  
 [VSPackages](../vs140/vspackages.md)  
 Provides a general orientation to topics that explain how to create and use VSPackages.