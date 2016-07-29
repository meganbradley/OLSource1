---
title: "Partition Processing Destination Editor (Connection Manager Page)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7add6f82-eed1-47fc-a5d7-7b91f3f24d34
caps.latest.revision: 28
manager: jhubbard
---
# Partition Processing Destination Editor (Connection Manager Page)
Use the **Connection Manager** page of the **Partition Processing Destination Editor** dialog box to specify a connection to a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] project or to an instance of [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)].  
  
 To learn more abou the Partition Processing destination, see [Partition Processing Destination](../../Topics/TopicNameNotContainA/Partition-Processing-Destination.md).  
  
> [!NOTE]  
>  Tasks described here do not apply to Analysis Services tabular models.  You cannot map input columns to partition columns for tabular models. You can instead use the Analysis Services Execute DDL task [Analysis Services Execute DDL Task](../../Topics/TopicNameNotContainA/Analysis-Services-Execute-DDL-Task.md) to process the partition.  
  
## Options  
 **Connection manager**  
 Select an existing connection manager from the list, or create a new connection by clicking **New**.  
  
 **New**  
 Create a new connection by using the **Add Analysis Services Connection Manager** dialog box.  
  
 **List of available partitions**  
 Select the partition to process.  
  
 **Processing method**  
 Select the processing method. The default value of this option is **Full**.  
  
|Value|Description|  
|-----------|-----------------|  
|Add (incremental)|Perform an incremental processing of the partition.|  
|Full|Perform full processing of the partition.|  
|Data only|Perform an update processing of the partition.|  
  
## See Also  
 [Integration Services Error and Message Reference](../../Topics/TopicNameNotContainA/Integration-Services-Error-and-Message-Reference.md)   
 [Partition Processing Destination Editor (Mappings Page)](../../Topics/TopicNameNotContainA/Partition-Processing-Destination-Editor--Mappings-Page-.md)   
 [Partition Processing Destination Editor (Advanced Page)](../../Topics/TopicNameNotContainA/Partition-Processing-Destination-Editor--Advanced-Page-.md)