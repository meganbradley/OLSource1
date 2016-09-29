---
title: "How to: Create File Associations For a ClickOnce Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "file associations, ClickOnce applications"
  - "ClickOnce deployment, file associations"
ms.assetid: 835230c8-3177-440f-85e3-e40f1d8b4f9d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create File Associations For a ClickOnce Application
[!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] applications can be associated with one or more file name extensions, so that the application will be started automatically when the user opens a file of those types. Adding file name extension support to a [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] application is straightforward.  
  
### To create file associations for a ClickOnce application  
  
1.  Create a [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] application normally, or use your existing [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] application.  
  
2.  Open the application manifest with a text or XML editor, such as Notepad.  
  
3.  Find the `assembly` element. For more information, see [ClickOnce Application Manifest](../VS_csharp/clickonce-application-manifest.md).  
  
4.  As a child of the `assembly` element, add a `fileAssociation` element. The `fileAssociation` element has four attributes:  
  
    -   `extension`: The file name extension you want to associate with the application.  
  
    -   `description`: A description of the file type, which will appear in the Windows shell.  
  
    -   `progid`: A string uniquely identifying the file type, to mark it in the registry.  
  
    -   `defaultIcon`: An icon to use for this file type. The icon must be added as a file resource in the application manifest. For more information, see [How To: Include a Data File in a ClickOnce Application](../VS_csharp/how-to--include-a-data-file-in-a-clickonce-application.md).  
  
     For an example of the `file` and `fileAssociation` elements, see [<fileAssociation\> Element](../VS_csharp/-fileassociation--element--clickonce-application-.md).  
  
5.  If you want to associate more than one file type with the application, add additional `fileAssociation` elements. Note that the `progid` attribute should be different for each.  
  
6.  Once you have finished with the application manifest, re-sign the manifest. You can do this from the command line by using Mage.exe.  
  
     `mage -Sign WindowsFormsApp1.exe.manifest -CertFile mycert.pfx`  
  
     For more information, see [Manifest Generation and Editing Tool (Mage.exe)](assetId:///77dfe576-2962-407e-af13-82255df725a1)  
  
## See Also  
 [<fileAssociation\> Element](../VS_csharp/-fileassociation--element--clickonce-application-.md)   
 [ClickOnce Application Manifest](../VS_csharp/clickonce-application-manifest.md)   
 [Manifest Generation and Editing Tool (Mage.exe)](assetId:///77dfe576-2962-407e-af13-82255df725a1)