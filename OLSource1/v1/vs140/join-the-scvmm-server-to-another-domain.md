---
title: "Join the SCVMM server to another domain"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fa6fe08e-ddee-40fc-851a-76a771b441e0
caps.latest.revision: 2
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Join the SCVMM server to another domain
Occasionally, it might be necessary to change your [!INCLUDE[vstsTfsShort](../vs140/includes/vststfsshort_md.md)] from one active directory domain to another, or from a workgroup to a domain. For more information, see [Move TFS](assetId:///ff582394-a3d6-4a1d-86d2-ff4a0c9f7e30). As part of this task, you should move SCVMM and Lab Management to the new domain.  
  
 In order to move an SCVMM server to a domain, or change its domain, you must re-install SCVMM. Therefore, you have to save the virtual machines and templates, and then re-define the environments in the new installation. This topic describes this procedure in more detail.  
  
### Uninstall SCVMM  
  
1.  Remove the hosts and library servers from the SCVMM server.  
  
    1.  Open the Virtual Machine Manager Administrator Console:  
  
         Choose **Start**, **Microsoft System Center**, **Virtual Machine Manager**, **Virtual Machine Manager Administrator Console**.  
  
    2.  Delete the library servers.  
  
    3.  Delete the host groups.  
  
2.  Delete all lab artifacts from [!INCLUDE[TCMext](../vs140/includes/tcmext_md.md)] Library Center:  
  
     In the **Lab** tab, delete the environments. In the **Library** tab, delete the virtual machines and the environments.  
  
     Because the hosts and library servers are no longer associated with SCVMM, removing these items from [!INCLUDE[TCMext](../vs140/includes/tcmext_md.md)] does not delete the actual virtual machines and VHDs.  
  
3.  Unconfigure SCVMM from Team Foundation Server.  
  
    1.  Log on to the Team Foundation Server as *tfsadmin*.  
  
    2.  Open **Team Foundation Administrator Console**.  
  
    3.  In the **Application Tier** node, choose **Lab Management**, then choose **Reconfigure Lab Management**.  
  
    4.  Delete the links between the library shares and the team project collection.  
  
4.  Uninstall SCVMM from the computer on which it was installed.  
  
### Join the computers to domain  
  
1.  Change the domain of the hosts and library servers.  
  
2.  Change the domain of the SCVMM server computer.  
  
### Re-install SCVMM and rebuild artifacts  
  
1.  Re-install SCVMM on its computer.  
  
2.  Add the hosts and library servers back to SCVMM.  
  
     For more information, see the SCVMM section in [Configuring Lab Management for the First Time](../vs140/configure-lab-management-for-scvmm-environments.md).  
  
3.  If any of the virtual machines has to be joined to the new domain, do so.  
  
     Network isolated environments have their own domain or workgroup. Therefore, their constituent machines do not have to be altered.  
  
4.  Configure the new SCVMM to couple it to your team project collection.  
  
     Set the new lab service account in Team Foundation Server.  
  
     For more information, see the SCVMM section in [Configuring Lab Management for the First Time](../vs140/configure-lab-management-for-scvmm-environments.md).  
  
5.  Using [!INCLUDE[vstsLabShort](../vs140/includes/vstslabshort_md.md)], re-import the virtual machines and templates into the Library.  
  
     For more information, see [How to Import Virtual Machines and Templates](assetId:///571cc1ca-e3ae-4971-a053-56de57add531).  
  
6.  Compose virtual machines into environments in [!INCLUDE[TCMext](../vs140/includes/tcmext_md.md)].  
  
     For more information, see [How to Create a Stored Environment](assetId:///52b9484b-0265-4774-abeb-e1c0cadf4e96).