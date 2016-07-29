---
title: "Create a Changeset (Master Data Services)"
ms.custom: 
  - SQL2016_New_Updated
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - master-data-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cfad6f1c-9125-4896-b5f5-a4b9f9593cc4
caps.latest.revision: 10
manager: jhubbard
---
# Create a Changeset (Master Data Services)
A changeset is a collection of the pending changes on the master data. If the entity requires approval for changes, the pending changes must be saved in a changeset and then submitted for administrator approval.  
  
## Prerequisites  
  
-   You must have permission to access the Explorer functional area. For more information, see [Functional Area Permissions (Master Data Services)](../../Topics/TopicNameNotContainA/Functional-Area-Permissions--Master-Data-Services-.md)  
  
-   You must have at least read access to the entity or one of its attributes.  
  
## To create a local changeset  
  
1.  On the [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] home page, select  the model and version and then click **Explorer**.  
  
2.  Click an entity on the **Entities** menu.  
  
3.  In the right pane, select **Changesets** and click **Create**.  
  
4.  Enter a name for the changeset, and click **Save**.  
  
     The name of the changeset must be unique within a model.  
  
## To create a changeset for approval  
  
1.  On the [!INCLUDE[ssMDSmdm](../../Topics/TopicNameContainA/includes/ssMDSmdm_md.md)] home page, select  the model and version and then click **Explorer**.  
  
2.  Click an entity on the **Entities** menu.  
  
3.  Make changes to the entity and click on**OK**.  
  
4.  **Choose A changeset** dialog box is displayed.  
  
5.  Click **New**, enter a name for the changeset, and click **Save**. The changeset name must be unique within a model.  
  
6.  To use  an existing changeset, click **Existing** and choose the changeset from the list. Only changesets that are in an open or rejected state are available.  
  
## Next Steps  
 [Apply and Update a Changeset (Master Data Services)](../../Topics/TopicNameContainA/Apply-and-Update-a-Changeset--Master-Data-Services-.md)  
  
## See Also  
 [Commit or Submit a Changeset (Master Data Services)](../../Topics/TopicNameContainA/Commit-or-Submit-a-Changeset--Master-Data-Services-.md)   
 [Approve or Reject a Changeset (Master Data Services)](../../Topics/TopicNameContainA/Approve-or-Reject-a-Changeset--Master-Data-Services-.md)