---
title: "Examining the Mechanics of a Wizard"
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
  - "custom wizards, wizard projects"
ms.assetid: 79917075-a843-40f6-abf8-64d98e5f6bdc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Examining the Mechanics of a Wizard
You do not need to compile a wizard project to have users start using it right away. Once you have created the necessary elements, the VSDIR directs the `New Project` dialog box to display the wizard icon and the `Add New Item` dialog box to display the wizard name in the shortcut menu. Your customer can launch the wizard immediately by selecting it.  
  
 When the user launches the wizard, the environment shell cocreates the wizard engine and queries for <xref:EnvDTE.IDTWizard*>. It then calls <xref:EnvDTE.IDTWizard.Execute*> to launch the wizard.  
  
> [!NOTE]
>  If the wizard has no interface, the project is created with the supplied defaults and displayed in Solution Explorer, with the node structure supplied in the .vsz file. The rest of this topic assumes that the wizard has a UI.  
  
 If the wizard has a UI, the user accepts or changes the defaults in each control in the wizard's HTML-based UI. As the user navigates through the wizard's pages and makes changes, functions such as <xref:Microsoft.VisualStudio.VsWizard.VCWizCtlClass.Navigate*> and <xref:Microsoft.VisualStudio.VsWizard.VCWizCtlClass.Next*> are called in the Script section of the HTML.  
  
 Whenever the user selects different options within the wizard, the selections are captured in the symbol table in the wizard control. The symbol table matches the IDs of the controls in the wizard's HTML page to maintain a one-to-one correspondence between user selections and the symbol table.  
  
 When the user clicks **Finish** in the wizard UI, the JScript function **OnFinish** is called from the HTML script.  
  
> [!NOTE]
>  You can customize **OnFinish** in Default.js to perform any additional tasks you require.  
  
 The wizard engine then scans through the template files, parsing and rendering them based on the user's choices. It copies the rendered files to the project directory and adds these files to the project. The newly created project is loaded in the Visual Studio environment, and the project's nodes and files are displayed in Solution Explorer.  
  
## See Also  
 <xref:Microsoft.VisualStudio.VsWizard.VCWizCtl*>   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Steps to Designing a Wizard](../vs140/steps-to-designing-a-wizard.md)   
 [Customizing Your Wizard](../vs140/customizing-your-wizard.md)