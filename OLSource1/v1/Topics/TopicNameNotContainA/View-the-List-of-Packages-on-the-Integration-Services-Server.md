---
title: View the List of Packages on the Integration Services Server
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 67a992d1-7524-4f4b-b3d8-ebd9e5ea82a8
manager: jhubbard
---
# View the List of Packages on the Integration Services Server
You can view the list of packages that are stored on the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] server in one of two ways.  
  
 [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] access  
 To view the list of packages that are stored on the server, query the view, [catalog.packages (Integration Services Database)](assetId:///a634e94d-f492-4dfd-9611-a35f545106a1).  
  
 In [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]  
 To view packages stored on the server by using Object Explorer in [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], follow the procedure below.  
  
### To view packages using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)]  
  
1.  In [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)], connect to the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] server. That is, connect to the instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)] that hosts the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] database.  
  
2.  In Object Explorer, expand the tree to display the **Integration Services Catalogs** node.  
  
3.  Expand the **Integration Services Catalogs** node to display the **SSISDB** node.  
  
4.  Expand the **SSISDB** node to display a list of one or more folders. Each folder contains one or more projects in the **Projects** folder, and each project contains one more packages in the **Packages** folder.