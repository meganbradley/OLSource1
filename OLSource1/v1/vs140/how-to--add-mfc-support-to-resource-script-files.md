---
title: "How to: Add MFC Support to Resource Script Files"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.resvw.add.MFC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rc files, adding MFC support"
  - ".rc files, adding MFC support"
  - "MFC, adding support to resource scripts files"
  - "resource script files, adding MFC support"
ms.assetid: 599dfe9d-ad26-4e34-899c-49b56599e37f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add MFC Support to Resource Script Files
Normally, when you build an MFC application for Windows using the [MFC Application Wizard](../vs140/mfc-application-wizard.md), the wizard generates a basic set of files (including a resource script (.rc) file) that contains the core features of the Microsoft Foundation classes (MFC). However, if you are editing an .rc file for a Windows application that is not based on MFC, the following features specific to the MFC framework are not available:  
  
-   MFC code wizards (previously called "[MFC ClassWizard](assetId:///98dc2434-ba93-4e0b-b084-1a4bc26cdf1e)")  
  
-   Menu prompt strings  
  
-   List contents for combo box controls  
  
-   ActiveX control hosting  
  
 However, you can add MFC support to existing .rc files that do not have it.  
  
### To add MFC support to .rc files  
  
1.  Open the resource script file.  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../vs140/how-to--create-a-resource-script-file.md).  
  
2.  In [Resource View](../vs140/resource-view-window.md), highlight the resources folder (for example, MFC.rc).  
  
3.  In the [Properties window](../vs140/properties-window.md), set the **MFC Mode** property to **True**.  
  
    > [!NOTE]
    >  In addition to setting this flag, the .rc file must be part of an MFC project. For example, just setting **MFC Mode** to **True** on an .rc file in a Win32 project won't give you any of the MFC features.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 MFC  
  
## See Also  
 [Resource Files](../vs140/resource-files--visual-studio-.md)   
 [Resource Editors](../vs140/resource-editors.md)