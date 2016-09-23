---
title: "Change Existing Lab Management Configurations"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vstf.tfs.mmc.console.labmgmt.general
helpviewer_keywords: 
  - Lab Management, chaning the configuration
  - changing Lab Management configuration [Visual Studio ALM]
ms.assetid: 69c6c649-7fd6-48b9-8b95-69f53f5ad429
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Change Existing Lab Management Configurations
After you have configured [!INCLUDE[vstsLabShort](../vs140/includes/vstslabshort_md.md)], you might want to change the resources that you are using for a team project collection. You might want to add more resources as you create more virtual machines, templates, and environments, or change the integration service account, or add a build controller or test controller.  
  
## Tasks  
 Use the following topics to help you change existing [!INCLUDE[vstsLabShort](../vs140/includes/vstslabshort_md.md)] configurations:  
  
|Tasks|Associated Topics|  
|-----------|-----------------------|  
|**Change the host groups for your team project collection:** You can add or remove host groups from your team project collection by using the Administration Console for [!INCLUDE[esprfound](../vs140/includes/esprfound_md.md)], or you can use the command-line utility TFSLabConfig.|-   [How to: Use a Different Host Group for Your Team Project Collections](../vs140/change-the-host-groups-for-your-team-project-collections.md)|  
|**Change the library shares for your team project collection:** You might want to add another library share to provide more storage for your virtual environments, templates, or virtual machines.|-   [How to: Change the Library Share for Your Team Project Collections](../vs140/change-the-library-share-for-your-team-project-collections.md)|  
|**Change the integration service account that provides communication between the agents and controllers:** We recommend that you change this user account regularly for security reasons.|-   [Setting up test   controllers in lab environments](assetId:///f5113275-14f5-4a40-8e3a-50d347ddb83a)|  
|**Change Active Directory domain to which the SCVMM server belongs.**|-   [Join the SCVMM server to another domain](../vs140/join-the-scvmm-server-to-another-domain.md)|  
  
## See Also  
 [Configuring Lab Management for the First Time](../vs140/configure-lab-management-for-scvmm-environments.md)   
 [Configuring and Administering Lab Management](../vs140/configure-and-administer-lab-management.md)   
 [Administering Team Foundation](assetId:///b29b394e-b704-4ebb-ac4b-8c83eb124dd3)