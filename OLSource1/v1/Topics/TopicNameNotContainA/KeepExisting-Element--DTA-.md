---
title: "KeepExisting Element (DTA)"
ms.custom: na
ms.date: 06/29/2016
ms.devlang: 
  - XML
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e67aae61-d06d-4a03-85ba-6516c3502dce
caps.latest.revision: 14
manager: jhubbard
---
# KeepExisting Element (DTA)
Specifies the physical design structures (indexes, indexed views, or partitioning) that Database Engine Tuning Advisor must retain when generating its recommendation.  
  
## Syntax  
  
```  
  
<DTAInput>  
...code removed...  
    <TuningOptions>  
      <KeepExisting>...</KeepExisting>  
```  
  
## Element Characteristics  
  
|Characteristic|Description|  
|--------------------|-----------------|  
|**Data type and length**|**string**, length limit enforced by the server.|  
|**Allowed values**|**NONE**<br /> No existing structures.<br /><br /> **ALL**<br /> All existing structures.<br /><br /> **ALIGNED**<br /> All partition-aligned structures.<br /><br /> **CL_IDX**<br /> All clustered indexes on tables.<br /><br /> **IDX**<br /> All clustered and nonclustered indexes on tables.<br /><br /> Use only one of these values with this element.|  
|**Default value**|None.|  
|**Occurrence**|Optional. Can use only once for each **TuningOptions** element.|  
  
## Element Relationships  
  
|Relationship|Elements|  
|------------------|--------------|  
|**Parent element**|[TuningOptions Element (DTA)](../../Topics/TopicNameNotContainA/TuningOptions-Element--DTA-.md)|  
|**Child elements**|None.|  
  
## Example  
 For a usage example of this element, see the [Simple XML Input File Sample (DTA)](../../Topics/TopicNameNotContainA/Simple-XML-Input-File-Sample--DTA-.md).  
  
## See Also  
 [XML Input File Reference (Database Engine Tuning Advisor)](../../Topics/TopicNameNotContainA/XML-Input-File-Reference--Database-Engine-Tuning-Advisor-.md)