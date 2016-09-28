---
title: "Adding Objects and Controls to an ATL Project"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "vc.appwiz.ATL.controls"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL projects, adding objects"
  - "wizards [C++], ATL projects"
  - "ATL projects, adding controls"
  - "controls [ATL], adding to projects"
  - "objects [C++], adding to ATL projects"
  - "ATL Control Wizard"
ms.assetid: c0adcbd0-07fe-4c55-a8fd-8c2c65ecdaad
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding Objects and Controls to an ATL Project
You can use one of the ATL code wizards to add an object or a control to your ATL- or MFC-based projects. For each COM object or control you add, the wizard generates .cpp and .h files, as well as an .rgs file for script-based registry support. The following ATL code wizards are available in Visual Studio:  
  
||||  
|-|-|-|  
|[ATL Simple Object](../vs140/atl-simple-object-wizard.md)|[ATL Dialog](../vs140/atl-dialog-wizard.md)|[ATL Control](../vs140/atl-control-wizard.md)|  
|[ATL Property Page](../vs140/atl-property-page-wizard.md)|[ATL Active Server Page Component](../vs140/atl-active-server-page-component-wizard.md)|[ATL OLE DB Consumer](../vs140/atl-ole-db-consumer-wizard.md)|  
|[Add ATL Support to MFC](../vs140/adding-atl-support-to-your-mfc-project.md)|[ATL COM+ 1.0 Component Wizard](../vs140/atl-com--1.0-component-wizard.md)|[ATL OLE DB Provider](../vs140/atl-ole-db-provider-wizard.md)|  
  
> [!NOTE]
>  Before adding an ATL object to your project, you should review the details and requirements for the object in its related Help topics.  
  
### To add an object or a control using the ATL Control Wizard  
  
1.  In Solution Explorer, right-click the project node and click **Add** from the shortcut menu. Click **Add Class**.  
  
     The [Add Class](../vs140/add-class-dialog-box.md) dialog box appears.  
  
2.  With the ATL folder selected in the Categories pane, select an object to insert from the Templates pane. Click **Open**. The code wizard for the selected object appears.  
  
    > [!NOTE]
    >  If you want to add an ATL object to an MFC project, you must add ATL support to the existing project. You can do this by following the instructions in [Adding ATL Support to Your MFC Project](../vs140/adding-atl-support-to-your-mfc-project.md).  
  
     Alternately, if you attempt to add an ATL object to your MFC project without previously adding ATL support, Visual Studio prompts you to specify whether you want ATL support added to your project. Click **Yes** to add ATL support to the project and open the selected ATL wizard.  
  
## See Also  
 [ATL Project Wizard](../vs140/atl-project-wizard.md)   
 [Visual C++ Project Types](../vs140/visual-c---project-types.md)   
 [Creating Desktop Projects By Using Application Wizards](../vs140/creating-desktop-projects-by-using-application-wizards.md)   
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)   
 [Programming with ATL and C Run-Time Code](../vs140/programming-with-atl-and-c-run-time-code.md)   
 [Default ATL Project Configurations](../vs140/default-atl-project-configurations.md)