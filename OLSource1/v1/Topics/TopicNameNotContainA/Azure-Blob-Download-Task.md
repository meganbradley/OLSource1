---
title: "Azure Blob Download Task"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/21/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8a63bf44-71be-456d-9a5c-be7c31aff065
caps.latest.revision: 7
manager: jhubbard
---
# Azure Blob Download Task
  The Azure Blob Download Task enables an SSIS package to download files from an Azure blob storage.

>   [!NOTE] At this time, the Azure Storage Connection Manager and the components that use it - that is, the Blob Source, the Blob Destination, the Blob Upload Task, and the Blob Download Task - can only connect to general-purpose storage accounts; they cannot connect to blob storage accounts. For more info about these two types of storage accounts, see [Introduction to Microsoft Azure Storage](https://azure.microsoft.com/en-us/documentation/articles/storage-introduction/#general-purpose-storage-accounts). 
   
To add an **Azure Blob Download Task**, drag-drop it to the SSIS Designer, and double-click or right-click and click **Edit** to see the following **Azure Blob Download Task Editor** dialog box.  
  
 The **Azure Blob Download Task** is a component of the SQL Server Integration Services (SSIS) Feature Pack for Azure for SQL Server 2016. Download the Feature Pack [here](http://go.microsoft.com/fwlink/?LinkID=626967).  
  
 The following table provides description for the fields in this dialog box.  
  
|||  
|-|-|  
|**Field**|**Description**|  
|AzureStorageConnection|Specify an existing Azure Storage Connection Manager or create a new one that refers to an Azure Storage Account, which points to where the blob files are hosted.|  
|BlobContainer|Specifies the name of the blob container that contains the blob files to be downloaded.|  
|BlobDirectory|Specifies the blob directory that contains the blob files to be downloaded. The blob directory is a virtual hierarchical structure.|  
|LocalDirectory|Specifies the local directory where the downloaded blob files will be stored.|  
|FileName|Specifies a name filter to select files with the specified name pattern. E.g. MySheet*.xls\* includes files such as MySheet001.xls and MySheetABC.xlsx.|  
|TimeRangeFrom/TimeRangeTo|Specifies a time range filter. Files modified after **TimeRangeFrom** and before **TimeRangeTo** will be included.|  
  
  