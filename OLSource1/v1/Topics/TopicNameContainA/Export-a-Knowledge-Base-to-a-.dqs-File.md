---
title: Export a Knowledge Base to a .dqs File
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - data-quality-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a324ead5-c8aa-4e26-abe3-ef415add00f8
---
# Export a Knowledge Base to a .dqs File
  This topic describes how to export an entire knowledge base to a .dqs data file in [!INCLUDE[ssDQSnoversion](../../Token\Other/ssDQSnoversion_md.md)] \(DQS\). You can export a domain or an entire knowledge base to a data file. For information about exporting a domain, see [Export a Domain to a .dqs File](../../Topics\TopicNameContainA/Export-a-Domain-to-a-.dqs-File.md).  
  
 Exporting a knowledge base to a .dqs file, and then importing it as another knowledge base simplifies the knowledge generation process, saving time and effort. It enables you to share a knowledge base and its knowledge with others. The .dqs file will contain all knowledge base information, including domains and the matching policy, except for the attached reference data information. You must attach the required domains to appropriate reference data services again, if required, after importing the .dqs file. Both published and unpublished data in a knowledge base is exported.  
  
 The .dqs data file created by the export process is encrypted, so the contents cannot be viewed.  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Prerequisites"></a> Prerequisites  
 To export a knowledge base to a .dqs data file, you must have created and opened a knowledge base. You do not need to have a .dqs file to export into; one will be created for you.  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 You must have the dqs\_kb\_editor or the dqs\_administrator role on the DQS\_MAIN database to export a knowledge base to a .dqs data file.  
  
##  <a name="Export"></a> Export a knowledge base to a .dqs file  
  
1.  [!INCLUDE[ssDQSInitialStep](../../Token\Other/ssDQSInitialStep_md.md)] [Run the Data Quality Client Application](../../Topics\TopicNameNotContainA/Run-the-Data-Quality-Client-Application.md).  
  
2.  In the [!INCLUDE[ssDQSClient](../../Token\Other/ssDQSClient_md.md)] home screen, open a knowledge base in the Domain Management activity.  
  
3.  In the Domain Management page \(with any tab selected\), click the **Export Knowledge Base data** icon above the Domain list, and then click **Export Knowledge Base**. Alternatively, you can also right\-click in the **Domain** list, hover over **Export**, and then click **Export Knowledge Base**.  
  
4.  In the **Export to Data File** dialog box, move to the folder that you want to save the file in, name the file or keep the knowledge base name, keep **DQS Data Files \(\*.dqs\)** as the **Save as** type, and then click **Save**.  
  
5.  In the **Export Knowledge Base** dialog box, verify that the status line indicates that the export completed. Click **OK**.  
  
##  <a name="FollowUp"></a> Follow Up: After Exporting a Domain to a .dqs File  
 After you export a knowledge base to a .dqs file, you can import the knowledge base into the same [!INCLUDE[ssDQSServer](../../Token\Other/ssDQSServer_md.md)] \(with a new name\) or into a different [!INCLUDE[ssDQSServer](../../Token\Other/ssDQSServer_md.md)].  
  
  