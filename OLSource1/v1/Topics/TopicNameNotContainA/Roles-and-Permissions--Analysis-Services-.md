---
title: Roles and Permissions (Analysis Services)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bb885447-868b-4686-853c-8241f63d4370
manager: mblythe
---
# Roles and Permissions (Analysis Services)
[!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] provides a role-based authorization model that grants access to operations, objects, and data. All users who access an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] instance or database must do so within the context of a role.  
  
 As an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] system administrator, you are in charge of granting membership to the **server administrator role** that conveys unrestricted access to operations on the server. This role has fixed permissions and cannot be customized. By default, members of the local Administrators group are automatically Analysis Services system administrators.  
  
 Non-administrative users who query or process data are granted access through **database roles**. Both system administrators and database administrators can create the roles that describe different levels of access within a given database, and then assign membership to every user who requires access. Each role has a customized set of permissions for accessing objects and operations within a particular database. You can assign permissions at these levels: database, interior objects such as cubes and dimensions (but not perspectives), and rows.  
  
 It is common practice to create roles and assign membership as separate operations. Often, the model designer adds roles during the design phase. This way, all role definitions are reflected in the project files that define the model. Role membership is typically rolled out later as the database moves into production, usually by database administrators who create scripts that can be developed, tested, and run as an independent operation.  
  
 All authorization is predicated on a valid Windows user identity. [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] uses Windows authentication exclusively to authenticate user identities. [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] provides no proprietary authentication method.See [Authentication methodologies supported by Analysis Services](../../Topics/TopicNameNotContainA/Authentication-methodologies-supported-by-Analysis-Services.md).  
  
> [!IMPORTANT]  
>  Permissions are additive for each Windows user or group, across all roles in the database. If one role denies a user or group permission to perform certain tasks or view certain data, but another role grants this permission to that user or group, the user or group will have permission to perform the task or view the data.  
  
## In this section  
  
-   [Authorizing access to objects and operations (Analysis Services)](../../Topics/TopicNameNotContainA/Authorizing-access-to-objects-and-operations--Analysis-Services-.md)  
  
-   [Grant database permissions (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-database-permissions--Analysis-Services-.md)  
  
-   [Grant cube or model permissions (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-cube-or-model-permissions--Analysis-Services-.md)  
  
-   [Grant process permissions (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-process-permissions--Analysis-Services-.md)  
  
-   [Grant read definition permissions on object metadata (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-read-definition-permissions-on-object-metadata--Analysis-Services-.md)  
  
-   [Grant permissions on a data source object (Analysis Services)](../../Topics/TopicNameContainA/Grant-permissions-on-a-data-source-object--Analysis-Services-.md)  
  
-   [Grant permissions on data mining structures and models (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-permissions-on-data-mining-structures-and-models--Analysis-Services-.md)  
  
-   [Grant permissions on a dimension (Analysis Services)](../../Topics/TopicNameContainA/Grant-permissions-on-a-dimension--Analysis-Services-.md)  
  
-   [Grant custom access to dimension data (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-custom-access-to-dimension-data--Analysis-Services-.md)  
  
-   [Grant custom access to cell data (Analysis Services)](../../Topics/TopicNameNotContainA/Grant-custom-access-to-cell-data--Analysis-Services-.md)  
  
## See Also  
 [Create and Manage Roles (SSAS Tabular)](../../Topics/TopicNameNotContainA/Create-and-Manage-Roles--SSAS-Tabular-.md)