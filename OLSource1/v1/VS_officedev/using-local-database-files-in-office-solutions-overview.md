---
title: "Using Local Database Files in Office Solutions Overview"
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
  - "Office applications [Office development in Visual Studio], data"
  - "data [Office development in Visual Studio], local"
  - "local data [Office development in Visual Studio]"
ms.assetid: 7a920e6b-f0c3-4a62-b5dd-02668a6177b6
caps.latest.revision: 30
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
# Using Local Database Files in Office Solutions Overview
  You can include a database file, such as a SQL Server Express (.mdf) file or a Microsoft Office Access (.mdb) file, in your Office solution. This enables end users to maintain a local database in situations where maintaining a centralized database is not required, for example in a local inventory solution that is used on only a single computer.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
## Importing the Database File into a Project  
 To import the database file into your project, use the **Data Source Configuration Wizard** to create a data source based on the database file. The wizard adds the database file and a typed dataset to your project.  
  
## Deploying the Database File  
 The **Data Source Configuration Wizard** uses a relative path to create connections to the local database file. This enables you to copy the solution from one computer to another if you maintain the relative positions of the files.  
  
 If you deploy your solution to a server and then distribute the document to each end user, you must also manually distribute the database file and install it in the same position relative to the document. This means that the end user cannot move the document to a new location on his or her computer, unless he or she also moves the database file.  
  
## Local Database Files and Caching the Dataset  
 In document-level solutions for Microsoft Office Excel and Microsoft Office Word, you can cache datasets in the document by marking the dataset instance with the attribute \<xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute>. When you add the database file to your project by using the **Data Source Configuration Wizard**, a typed dataset is added to your project automatically. It is rarely necessary to apply \<xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute> to this dataset, because the data is already local on the user's computer. For more information, see [Caching Data](../VS_officedev/caching-data.md).  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [How to: Populate Documents with Data from a Database](../VS_officedev/how-to--populate-documents-with-data-from-a-database.md)   
 [How to: Update a Data Source with Data from a Host Control](../VS_officedev/how-to--update-a-data-source-with-data-from-a-host-control.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Caching Data](../VS_officedev/caching-data.md)  
  
  