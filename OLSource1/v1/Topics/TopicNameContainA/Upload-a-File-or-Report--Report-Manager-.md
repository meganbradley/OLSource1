---
title: "Upload a File or Report (Report Manager)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 79027e11-f4ba-4bfd-bd8c-d334e3da02a1
caps.latest.revision: 43
manager: mblythe
---
# Upload a File or Report (Report Manager)
Report Manager provides an upload feature so that you can add reports, models, and other files to a report server without having to publish those items from a client application. Files that you upload from the file system are stored as items on the report server. The type of file you upload determines how it is stored:  
  
-   .rdl files are stored as reports.  
  
-   .smdl files are stored as report models.  
  
-   All other files, including shared data source (.rds) files, are uploaded as resources. Resources are not processed by a report server, but can be viewed in Report Manager if the report server supports the MIME type of the file.  
  
### To upload a file or report  
  
1.  Start [Report Manager  (SSRS Native Mode)](../../Topics/TopicNameNotContainA/Report-Manager---SSRS-Native-Mode-.md).  
  
2.  In Report Manager, navigate to the **Contents** page. Navigate to the folder to which you want to add an item.  
  
3.  Click **Upload File**.  
  
4.  Click **Browse** to select a file to upload. You can upload a report definition file, an image, a document, or any file that you want to make available on the report server.  
  
5.  Type a name for the new item. An item name can include spaces, but cannot include the reserved characters: ; ? : @ & = + , $ / * < > &#124;.  
  
6.  If you want to replace an existing item with the new item, select **Overwrite item if it exists**.  
  
7.  [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
## See Also  
 [Create, Delete, or Modify a Shared Data Source (Report Manager)](../../Topics/TopicNameContainA/Create--Delete--or-Modify-a-Shared-Data-Source--Report-Manager-.md)   
 [Contents Page (Report Manager)](../../Topics/TopicNameNotContainA/Contents-Page--Report-Manager-.md)   
 [Upload File Page (Report Manager)](../../Topics/TopicNameNotContainA/Upload-File-Page--Report-Manager-.md)   
 [Upload Files to a Folder](../../Topics/TopicNameContainA/Upload-Files-to-a-Folder.md)