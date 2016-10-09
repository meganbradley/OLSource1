---
title: "How to: Attach Managed Code Extensions to Documents"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "managed code extensions [Office development in Visual Studio], attaching"
  - "documents [Office development in Visual Studio], managed code extensions"
ms.assetid: b38c3a35-8b4a-4e86-8475-88fa8a873a5d
caps.latest.revision: 33
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
# How to: Attach Managed Code Extensions to Documents
  You can attach a customization assembly to an existing Microsoft Office Word document or Microsoft Office Excel workbook. The document or workbook can be in any file format that is supported by the Microsoft Office projects and development tools in Visual Studio. For more information, see [Architecture of Document-Level Customizations](../VS_officedev/architecture-of-document-level-customizations.md).  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
 To attach a customization to a Word or Excel document, use the \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization*> method of the \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class. Because the \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class is designed to be run on a computer that does not have Microsoft Office installed, you can use this method in solutions that are not directly related to Microsoft Office development (such as a console or Windows Forms application).  
  
> [!NOTE]  
>  The customization will fail to load if the code expects controls that the specified document does not have.  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Attach or Detach a VSTO Assembly from a Word Document?](http://go.microsoft.com/fwlink/?LinkId=136782).  
  
### To attach managed code extensions to a document  
  
1.  In a project that does not require Microsoft Office, such as a console application or Windows Forms project, add a reference to the Microsoft.VisualStudio.Tools.Applications.ServerDocument.dll and Microsoft.VisualStudio.Tools.Applications.Runtime.dll assemblies.  
  
2.  Add the following **Imports** or **using** statements to the top of your code file.  
  
     [!code[Trin_VstcoreDeployment#4](../VS_officedev/codesnippet/CSharp/how-to--attach-managed-code-extensions-to-documents_1.cs)]
[!code[Trin_VstcoreDeployment#4](../VS_officedev/codesnippet/VisualBasic/how-to--attach-managed-code-extensions-to-documents_1.vb)]  
  
3.  Call the static \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization*> method.  
  
     The following code example uses the \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument.AddCustomization*> overload. This overload takes the full path of the document and a \<xref:System.Uri> that specifies the location of the deployment manifest for the customization you want to attach to the document. This example assumes that a Word document named **WordDocument1.docx** is on the desktop, and that the deployment manifest is located in a folder that is named **Publish** that is also on the desktop.  
  
     [!code[Trin_VstcoreDeployment#3](../VS_officedev/codesnippet/CSharp/how-to--attach-managed-code-extensions-to-documents_2.cs)]
[!code[Trin_VstcoreDeployment#3](../VS_officedev/codesnippet/VisualBasic/how-to--attach-managed-code-extensions-to-documents_2.vb)]  
  
4.  Build the project and run the application on the computer where you want to attach the customization. The computer must have the Visual Studio 2010 Tools for Office Runtime installed.  
  
## See Also  
 [Managing Documents on a Server by Using the ServerDocument Class](../VS_officedev/managing-documents-on-a-server-by-using-the-serverdocument-class.md)   
 [How to: Remove Managed Code Extensions from Documents](../VS_officedev/how-to--remove-managed-code-extensions-from-documents.md)   
 [Application and Deployment Manifests in Office Solutions](../VS_officedev/application-and-deployment-manifests-in-office-solutions.md)  
  
  