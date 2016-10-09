---
title: "Managing Documents on a Server by Using the ServerDocument Class"
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
  - "documents [Office development in Visual Studio], managing on server"
  - "Office documents [Office development in Visual Studio, managing on server"
  - "ServerDocument class, managing documents on server"
ms.assetid: 1ac90e89-d07d-4874-9d24-6741d6679a21
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
# Managing Documents on a Server by Using the ServerDocument Class
  You can use the ServerDocument class in the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] to manage several aspects of document-level customizations, even if Microsoft Office Word and Microsoft Office Excel are not installed. You can perform the following tasks:  
  
-   Access and modify data in the data cache of a document or workbook. For more information, see [Working With Cached Data in the Document](#CachedData).  
  
-   Manage the customization assembly that is associated with a document. For more information, see [Managing the Document Customization](#CustomizationInfo).  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
## Understanding the ServerDocument Class  
 The ServerDocument class is designed to be used on computers that do not have Office installed. Therefore, you typically use this class in applications that do not integrate with Office, such as Console projects or Windows Forms projects, rather than Office projects. Use the \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class in the Microsoft.VisualStudio.Tools.Applications.ServerDocument.dll assembly.  
  
 The ServerDocument class can be used to operate on document-level customizations that were created by using [!INCLUDE[vs_dev12](../VS_officedev/includes/vs_dev12_md.md)].  
  
 For more information about the Visual Studio 2010 Tools for Office Runtime and the Office extensions for the .NET Framework, see [Visual Studio Tools for Office Runtime Overview](../VS_officedev/visual-studio-tools-for-office-runtime-overview.md).  
  
> [!NOTE]  
>  If you have a legacy application that uses the ServerDocument class in the Visual Studio Tools for Office system (version 3.0 Runtime), the Visual Studio Tools for Office system (version 3.0 Runtime) must be installed on computers that run the application. The Visual Studio 2010 Tools for Office Runtime cannot run these applications.  
  
##  <a name="CachedData"></a> Working With Cached Data in the Document  
 The ServerDocument class provides members you can use to work with the data cache in customized documents. For more information about cached data, see [Caching Data](../VS_officedev/caching-data.md) and [Accessing Data in Documents on the Server](../VS_officedev/accessing-data-in-documents-on-the-server.md).  
  
 The following table lists the members you can use to work with cached data.  
  
|Task|Member to use|  
|----------|-------------------|  
|To determine whether a document has a data cache.|The \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.IsCacheEnabled*> method.|  
|To access the cached data in a document.<br /><br /> For more information, see [Accessing Data in Documents on the Server](../VS_officedev/accessing-data-in-documents-on-the-server.md).|The \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.CachedData*> property.|  
  
##  <a name="CustomizationInfo"></a> Managing the Document Customization  
 You can use members of the ServerDocument class to manage the customization assembly that is associated with a document. For example, you can programmatically remove the customization from a document so that the document is no longer part of a customization.  
  
 The following table lists the members you can use to manage the customization assembly.  
  
|Task|Member to use|  
|----------|-------------------|  
|To determine whether a document is part of a document-level customization.|The \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.GetCustomizationVersion*> method.|  
|To programmatically attach a customization to a document at run time.<br /><br /> For more information, see [How to: Attach Managed Code Extensions to Documents](../VS_officedev/how-to--attach-managed-code-extensions-to-documents.md)|One of the \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization*> methods.|  
|To programmatically remove a customization from a document at run time.<br /><br /> For more information, see [How to: Remove Managed Code Extensions from Documents](../VS_officedev/how-to--remove-managed-code-extensions-from-documents.md).|The \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.RemoveCustomization*> method.|  
|To get the URL of the deployment manifest that is associated with the document.|The \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.DeploymentManifestUrl*> property.|  
  
## See Also  
 [How to: Attach Managed Code Extensions to Documents](../VS_officedev/how-to--attach-managed-code-extensions-to-documents.md)   
 [How to: Remove Managed Code Extensions from Documents](../VS_officedev/how-to--remove-managed-code-extensions-from-documents.md)   
 [Visual Studio Tools for Office Runtime Overview](../VS_officedev/visual-studio-tools-for-office-runtime-overview.md)   
 [Caching Data](../VS_officedev/caching-data.md)  
  
  