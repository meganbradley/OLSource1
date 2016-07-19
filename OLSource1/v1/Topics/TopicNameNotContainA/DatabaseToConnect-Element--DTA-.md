---
title: DatabaseToConnect Element (DTA)
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
ms.assetid: 65153a66-3aee-4429-99b7-0816ac23c285
manager: jhubbard
---
# DatabaseToConnect Element (DTA)
Specifies the first database to which Database Engine Tuning Advisor connects when tuning a workload.  
  
## Syntax  
  
```  
  
    <TuningOptions>  
...code removed here...  
      <DatabaseToConnect>...</DatabaseToConnect>  
```  
  
## Element Characteristics  
  
|Characteristic|Description|  
|--------------------|-----------------|  
|**Data type and length**|**string**, unlimited length.|  
|**Default value**|None.|  
|**Occurrence**|Optional. Can use once for each **TuningOptions** element.|  
  
## Element Relationships  
  
|Relationship|Elements|  
|------------------|--------------|  
|**Parent element**|[TuningOptions Element (DTA)](../../Topics/TopicNameNotContainA/TuningOptions-Element--DTA-.md)|  
|**Child elements**|None|  
  
## Remarks  
 Use **DatabaseToConnect** to specify the name of the first database to which you want Database Engine Tuning Advisor to connect when it starts the tuning session. You can specify only one database with this element. If multiple database names are specified, Database Engine Tuning Advisor returns an error.  
  
## Example  
 For a usage example, see the [XML Input File Sample with Inline Workload (DTA)](../../Topics/TopicNameNotContainA/XML-Input-File-Sample-with-Inline-Workload--DTA-.md).  
  
## See Also  
 [XML Input File Reference (Database Engine Tuning Advisor)](../../Topics/TopicNameNotContainA/XML-Input-File-Reference--Database-Engine-Tuning-Advisor-.md)