---
title: "Configure and administer Lab Management"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - Lab Management
  - administering Lab Management [Visual Studio ALM]
  - Lab Management, configuring
ms.assetid: 13a4c6e6-3287-427d-963c-28b0abecb879
caps.latest.revision: 32
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Configure and administer Lab Management
[!INCLUDE[vstsLabLong](../vs140/includes/vstslablong_md.md)] lets you create and manage lab environments for a team project on Team Foundation Server. Use lab environments to develop, test, or run your application. Each machine in a lab environment represents a role required for the application that you intend to develop, test, or run. For example, you might be developing a multi-tiered application that requires three roles: a desktop client, a web server, and a database server. There are two types of lab environments: standard environments and SCVMM environments. A standard environment can contain physical machines and virtual machines using any virtualization platform. An SCVMM environment can only contain virtual machines that are managed by SCVMM on the Hyper-V virtualization platform. For more information about lab environments, see [Using a Lab Environment for your application Lifecycle](../vs140/using-a-lab-environment-for-your-application-lifecycle.md).  
  
## Tasks  
 Use the following topics to help you configure and administer [!INCLUDE[vstsLabShort](../vs140/includes/vstslabshort_md.md)]:  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Setting up Lab Management for the first time:** To use Lab Management to create standard environments, you need to set up a test controller. To use Lab Management to create SCVMM environments, you must first configure Hyper-V and SCVMM.|-   [Configuring Lab Management for the First Time](../vs140/configure-lab-management-for-scvmm-environments.md)|  
|**Changing your Lab Management configuration:** You might want to add more host groups, change the library share that is used, modify the integration service account, or add build controllers or test controllers after you have configured [!INCLUDE[vstsLabShort](../vs140/includes/vstslabshort_md.md)] for the first time.|-   [Changing Existing Lab Management Configurations](../vs140/change-existing-lab-management-configurations.md)|  
|**Assigning users permissions to use Lab Management resources:** The default [!INCLUDE[esprtfs](../vs140/includes/esprtfs_md.md)] security groups automatically give members certain permissions to use [!INCLUDE[vstsLabShort](../vs140/includes/vstslabshort_md.md)] resources. You might want to modify those permissions or assign permissions to custom groups or users.|-   [Managing User Permissions for Lab Management](../vs140/manage-user-permissions-for-lab-management.md)|  
|**Backing up and restoring your lab environments:** You can back up and restore your lab environments.|-   [Backing up and Restoring Your Deployment](assetId:///cf9b5ab7-f4da-4519-991c-cc1722cb5d3c)<br />-   [Restore Lab Management Components](assetId:///c99b3b8c-d025-4e2f-b6ef-533c5c2f3f92)|  
  
## Forums  
 [Visual Studio Lab Management](http://go.microsoft.com/fwlink/?LinkId=211860)  
  
## Blogs  
 [Visual Studio Lab Management team blog](http://go.microsoft.com/fwlink/?LinkId=211862)  
  
## See Also  
 [Using a Virtual Lab for Your Application Lifecycle](../vs140/using-a-lab-environment-for-your-application-lifecycle.md)   
 [Administering Team Foundation](assetId:///b29b394e-b704-4ebb-ac4b-8c83eb124dd3)