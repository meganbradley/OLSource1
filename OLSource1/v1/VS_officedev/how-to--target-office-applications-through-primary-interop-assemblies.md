---
title: "How to: Target Office Applications Through Primary Interop Assemblies"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "assemblies [Office development in Visual Studio], PIA references"
  - "primary interop assemblies [Office development in Visual Studio], adding references to"
  - "Office primary interop assemblies in Visual Studio, adding references to"
  - "Office applications [Office development in Visual Studio], automating"
  - "application development [Office development in Visual Studio], automating"
ms.assetid: 9bedae85-32b6-4df6-82b2-9d124fb49636
caps.latest.revision: 40
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
# How to: Target Office Applications Through Primary Interop Assemblies
  When you create a new Office project, Visual Studio automatically adds references to the Microsoft Office primary interop assemblies (PIAs) that are required to build your project. You must add references to other PIAs in the following scenarios:  
  
-   You want to use features of other Microsoft Office applications in your project. For example, you might want to use features of Microsoft Office Excel in a project for Microsoft Office Word.  
  
-   You want to automate Microsoft Office applications that do not have dedicated projects in Visual Studio, such as Microsoft Office Access.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
### To add a reference to a primary interop assembly  
  
1.  Open your Office project and select the project name in **Solution Explorer**.  
  
2.  On the **Project** menu, click **Add Reference**.  
  
3.  On the **Framework** tab, select the PIA you want in the **Component Name** list. For more information about the available Microsoft Office primary interop assemblies, see [Office Primary Interop Assemblies](../VS_officedev/office-primary-interop-assemblies.md).  
  
     If the project targets the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later, the **Embed Interop Types** property for the assembly reference is set to **True** by default. By using this setting, your solution does not require the PIA on end-user computers. For more information, see [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md).  
  
    > [!NOTE]  
    >  In Office projects, always add references to Office PIAs by using the **.NET** tab of the **Add Reference** dialog rather than the **COM** tab. For more information, see [Office Primary Interop Assemblies](../VS_officedev/office-primary-interop-assemblies.md).  
  
4.  Click **OK**.  
  
     The assembly name appears in the **References** folder of **Solution Explorer**.  
  
## See Also  
 [Office Primary Interop Assemblies](../VS_officedev/office-primary-interop-assemblies.md)   
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)   
 [Developing Office Solutions](../VS_officedev/developing-office-solutions.md)   
 [How to: Install Office Primary Interop Assemblies](../VS_officedev/how-to--install-office-primary-interop-assemblies.md)  
  
  