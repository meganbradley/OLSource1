---
title: "How to: Create Office Projects in Visual Studio"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VST.SelectDocWizard.Page1"
  - "VST.SelectDocWizard.Http"
  - "VST.SelectDocWizard.Extension"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "add-ins [Office development in Visual Studio], creating projects"
  - "Office applications [Office development in Visual Studio], creating"
  - "Office projects [Office development in Visual Studio]"
  - "projects [Office development in Visual Studio], creating"
  - "document-level customizations [Office development in Visual Studio], creating"
  - "application-level add-ins [Office development in Visual Studio], creating projects"
ms.assetid: 0037dbd8-0d2a-4766-90ea-81c819379582
caps.latest.revision: 96
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Create Office Projects in Visual Studio
  You can use [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] to create VSTO Add-in and document-level customizations for Microsoft Office applications. For more information about these types of projects, see [Office Solutions Development Overview &#40;VSTO&#41;](../VS_officedev/office-solutions-development-overview--vsto-.md).  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
### To create a VSTO Add-in project  
  
1.  On the **File** menu, choose **New**, **Project**. If your integrated development environment (IDE) is set to use [!INCLUDE[vbprvb](../VS_officedev/includes/vbprvb_md.md)] development settings, on the **File** menu, choose **New**, **Project**.  
  
     The **New Project** dialog box appears.  
  
    > [!NOTE]  
    >  Office projects target the [!INCLUDE[net_v45](../VS_officedev/includes/net_v45_md.md)] by default. For more information, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
2.  In the templates pane, under the node for the language you want to use, expand **Office/SharePoint**.  
  
3.  Choose the **Office Add-ins** node.  
  
4.  In the list of project templates, select a VSTO Add-in project template. For a list of available VSTO Add-in project templates, see [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md).  
  
    > [!NOTE]  
    >  If project templates are not visible when you select the **Office Add-ins** node, make sure that **.NET Framework 4** or later is selected in the combo box at the top of the dialog box. Office project templates are visible for both versions of the .NET Framework.  
  
5.  In the **Name** box, type a name for the project. By default, the project name is also used as the solution name.  
  
6.  In the **Location** box, enter the path where you want to create the project. You can use absolute and universal naming convention (UNC) paths. Do not use HTTP, FTP, or other protocol paths.  
  
     Locations have the following formats:  
  
    -   [*drive*\]:\  
  
    -   \\\\*Server*\\*Share*  
  
     Do not use these characters in the location:  
  
    -   Asterisk (*)  
  
    -   Vertical bar (|)  
  
    -   Colon (:) (Except following the drive letter.)  
  
    -   Double quotation mark (") (Paths that contain spaces do not need quotation marks.)  
  
    -   Less than (\<)  
  
    -   Greater than (>)  
  
    -   Question mark (?)  
  
    -   Percent sign (%)  
  
7.  Choose the **OK** button.  
  
    > [!NOTE]  
    >  Add-in projects are always saved when they are created. They cannot be created as temporary projects. For more information about temporary projects, see [NIB Temporary Projects](assetId:///9cf1944c-7045-44cc-8701-7b0eb4099f2b).  
  
### To create a document-level customization project  
  
1.  On the **File** menu, choose **New**, **Project**. If your IDE is set to use Visual Basic development settings, on the **File** menu, choose **New**, **Project**.  
  
     The **New Project** dialog box appears.  
  
    > [!NOTE]  
    >  Office projects target the [!INCLUDE[net_v45](../VS_officedev/includes/net_v45_md.md)] by default.  For more information, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
2.  In the templates pane, under the node for the language you want to use, expand **Office/SharePoint**.  
  
3.  Select the **Office Add-ins** node.  
  
4.  In the list of project templates, select a document-level project template. For a list of available document-level project templates, see [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md).  
  
    > [!NOTE]  
    >  If project templates are not visible when you select the **Office Add-ins** node, make sure that **.NET Framework 4** or later is selected in the combo box at the top of the dialog box. Office project templates are visible for both versions of the .NET Framework.  
  
5.  In the **Name** box, type a name for the project. By default, this name is also used for the document. If your IDE is set to use Visual C# development settings or General development settings, also enter a location and solution name.  
  
    > [!NOTE]  
    >  You cannot use surrogate characters in the path of the project location or in the project name. For information about surrogate characters, see [NIB: Unicode Support for Surrogate Pairs and Combining Character Sequences](assetId:///cba3285c-7b47-4ce8-8970-f48d6ac03e39). Also, if you plan to deploy the solution for use offline, the characters in the project name must fit the HTTP protocol specifications.  
  
6.  Choose the **OK** button.  
  
     The **Visual Studio Tools for Office Project Wizard** opens.  
  
7.  Select **Create a new document** if you want to create a new document for the solution, or select **Copy an existing document** if you want to customize an existing document.  
  
     If you create a new document, specify the name in the **Name** box and select the format of the document by using the **Format** box. For more information about the available formats, see [Architecture of Document-Level Customizations](../VS_officedev/architecture-of-document-level-customizations.md).  
  
     If you use an existing document, specify the location of the document in the **Full path of the existing document** box. You can use absolute and UNC paths. Do not use HTTP, FTP, or other protocol paths to the document.  
  
     Locations have the following formats:  
  
    -   [*drive*\]:\  
  
    -   \\\\*Server*\\*Share*  
  
     Do not use these characters in the location:  
  
    -   Asterisk (*)  
  
    -   Vertical bar (|)  
  
    -   Colon (:) (Except following the drive letter.)  
  
    -   Double quotation mark (") (Paths that contain spaces do not need quotation marks.)  
  
    -   Less than (\<)  
  
    -   Greater than (>)  
  
    -   Question mark (?)  
  
    -   Percent sign (%)  
  
    > [!NOTE]  
    >  If you use an existing document in a [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)] project, only use documents that were created in or converted to [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)]. Similarly, if you use an existing document in a Word 2010 project, only use documents that were created in or converted to Word 2010. Certain features will be disabled in the document if you use a document that was created in an earlier version of Word. If you try to write code that uses these features, you might encounter errors in your project. To convert a document, open it in [!INCLUDE[Word_15_short](../VS_officedev/includes/word_15_short_md.md)] or Word 2010, on the **File** tab on the ribbon, choose **Info**, **Convert**.  
  
8.  Choose **Finish**.  
  
9. Add the project folder and its subfolders to the list of trusted locations in the Trust Center in Word in the following cases:  
  
    -   You are creating a Word Document that is based on a .docm file, and the document contains a VBA project or hosts Windows Forms controls. Adding the project folder to the list of trusted locations will help make sure that the document works as expected at design time.  
  
    -   You are creating a Word Template project that is based on a .dotx file. You must add the project folder to the list of trusted locations so that you can run and debug the project.  
  
     For more information on how to add a document to the trusted locations, see the Microsoft Office Online web site [Create, remove, or change a trusted location for your files](https://support.office.com/en-au/article/Create-remove-or-change-a-trusted-location-for-your-files-f5151879-25ea-4998-80a5-4208b3540a62).  
  
## See Also  
 [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md)   
 [Collaborative Development of Office Solutions](../VS_officedev/collaborative-development-of-office-solutions.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [Getting Started Programming VSTO Add-ins](../VS_officedev/getting-started-programming-vsto-add-ins.md)  
  
  