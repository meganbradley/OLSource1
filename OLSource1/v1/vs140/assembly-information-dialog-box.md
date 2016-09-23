---
title: "Assembly Information Dialog Box"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.ProjectPropertiesAssemblyInfo
helpviewer_keywords: 
  - Assembly Information dialog box
ms.assetid: 8f1f6449-e03d-4a5b-9076-d3b1f84ada48
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Assembly Information Dialog Box
The **Assembly Information** dialog box is used to specify the values of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] global assembly attributes, which are stored in the AssemblyInfo file created automatically with your project. In **Solution Explorer**, the file is located in the **My Project** node in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] (click **Show All files** to view it); it is located under **Properties** in [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)]. For more information about assembly attributes, see [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md).  
  
 To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Application** tab. On the **Application** page, click the **Assembly Information** button.  
  
## UIElement List  
 **Title**  
 Specifies a title for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTitleAttribute?qualifyHint=False>.  
  
 **Description**  
 Specifies an optional description for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyDescriptionAttribute?qualifyHint=False>.  
  
 **Company**  
 Specifies a company name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCompanyAttribute?qualifyHint=False>.  
  
 **Product**  
 Specifies a product name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyProductAttribute?qualifyHint=False>.  
  
 **Copyright**  
 Specifies a copyright notice for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCopyrightAttribute?qualifyHint=False>.  
  
 **Trademark**  
 Specifies a trademark for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTrademarkAttribute?qualifyHint=False>.  
  
 **Assembly Version**  
 Specifies the version of the assembly. Corresponds to <xref:System.Reflection.AssemblyVersionAttribute?qualifyHint=False>.  
  
 **File Version**  
 Specifies a version number that instructs the compiler to use a specific version for the Win32 file version resource. Corresponds to <xref:System.Reflection.AssemblyFileVersionAttribute?qualifyHint=False>.  
  
 **GUID**  
 A unique GUID that identifies the assembly. When you create a project, Visual Studio generates a GUID for the assembly. Corresponds to <xref:System.Guid?qualifyHint=False>.  
  
 **Neutral Language**  
 Specifies which culture the assembly supports. Corresponds to <xref:System.Resources.NeutralResourcesLanguageAttribute?qualifyHint=False>. The default is **(None)**.  
  
 **Make assembly COM-Visible**  
 Specifies whether types in the assembly will be available to COM. Corresponds to <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False>.  
  
## See Also  
 [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md)   
 [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md)