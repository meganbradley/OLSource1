---
title: "Partition Processing Destination"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 36c592ff-3f78-4a58-b496-31c1c8eee131
caps.latest.revision: 45
manager: jhubbard
---
# Partition Processing Destination
The Partition Processing destination loads and processes an [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] partition. For more information about partitions, see [Partitions (SSAS)](assetId:///cd10ad00-468c-4d49-9f8d-873494d04b4f).  
  
 The Partition Processing destination includes the following features:  
  
-   Options to perform incremental, full, or update processing.  
  
-   Error configuration, to specify whether processing ignores errors or stops after a specified number of errors.  
  
-   Mapping of input columns to partition columns.  
  
 For more information about processing [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] objects, see [Processing Options and Settings (Analysis Services)](../../Topics/TopicNameNotContainA/Processing-Options-and-Settings--Analysis-Services-.md).  
  
> [!NOTE]  
>  Tasks described here do not apply to Analysis Services tabular models.  You cannot map input columns to partition columns for tabular models. You can instead use the Analysis Services Execute DDL task [Analysis Services Execute DDL Task](../../Topics/TopicNameNotContainA/Analysis-Services-Execute-DDL-Task.md) to process the partition.  
  
## Configuration of the Partition Processing Destination  
 The Partition Processing destination uses an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] connection manager to connect to the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] project or the instance of [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] that contains the cubes and partitions the destination processes. For more information, see [Analysis Services Connection Manager](../../Topics/TopicNameNotContainA/Analysis-Services-Connection-Manager.md).  
  
 This destination has one input. It does not support an error output.  
  
 You can set properties through [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer or programmatically.  
  
 For more information about the properties that you can set in the Partition Processing **Destination Editor** dialog box, click one of the following topics:  
  
-   [Partition Processing Destination Editor (Connection Manager Page)](../../Topics/TopicNameNotContainA/Partition-Processing-Destination-Editor--Connection-Manager-Page-.md)  
  
-   [Partition Processing Destination Editor (Mappings Page)](../../Topics/TopicNameNotContainA/Partition-Processing-Destination-Editor--Mappings-Page-.md)  
  
-   [Partition Processing Destination Editor (Advanced Page)](../../Topics/TopicNameNotContainA/Partition-Processing-Destination-Editor--Advanced-Page-.md)  
  
 The **Advanced Editor** dialog box reflects the properties that can be set programmatically. For more information about the properties that you can set in the **Advanced Editor** dialog box or programmatically, click one of the following topics:  
  
-   [Common Properties](../../Topics/TopicNameNotContainA/Common-Properties.md)  
  
-   [Partition Processing Destination Custom Properties](../../Topics/TopicNameNotContainA/Partition-Processing-Destination-Custom-Properties.md)  
  
 For more information about how to set the properties, see [Set the Properties of a Data Flow Component](../../Topics/TopicNameContainA/Set-the-Properties-of-a-Data-Flow-Component.md).