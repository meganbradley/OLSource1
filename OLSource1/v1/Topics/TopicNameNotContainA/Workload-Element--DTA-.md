---
title: Workload Element (DTA)
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
ms.assetid: 68ffd473-6546-4015-98d0-3763165de65c
manager: jhubbard
---
# Workload Element (DTA)
Specifies the workload to be used for a tuning session.  
  
## Syntax  
  
```  
  
<DTAInput>  
    <Server>  
...code removed...  
    <Workload>...</Workload>  
```  
  
## Element Characteristics  
  
|Characteristic|Description|  
|--------------------|-----------------|  
|**Data type and length**|None.|  
|**Default value**|None.|  
|**Occurrence**|Required once for each **DTAInput** element.|  
  
## Element Relationships  
  
|Relationship|Elements|  
|------------------|--------------|  
|**Parent element**|[Start and Use the Database Engine Tuning Advisor](../../Topics/TopicNameNotContainA/Start-and-Use-the-Database-Engine-Tuning-Advisor.md)|  
|**Child elements**|[File Element (DTA)](../../Topics/TopicNameNotContainA/File-Element--DTA-.md)<br /><br /> [Database Element for Workload (DTA)](../../Topics/TopicNameNotContainA/Database-Element-for-Workload--DTA-.md)<br /><br /> [EventString Element (DTA)](../../Topics/TopicNameNotContainA/EventString-Element--DTA-.md)|  
  
## Remarks  
 A workload is a set of [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statements that execute against a database or databases that you want to tune. The Database Engine Tuning Advisor can use [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] scripts, trace files, and trace tables as workloads.  
  
 If you specify a workload in an XML input file and a workload on the command line with the **dta** tool, the workload specified on the command line will be used for tuning. All tuning options specified on the command line override those that are specified in an XML input file. The only exception is if a user-specified configuration is entered in the evaluate mode in the XML input file. For example, if a configuration is entered in the **Configuration** element of the XML input file and the **EvaluateConfiguration** element is also specified as one of the tuning options, the tuning options specified in the XML input file will override any tuning options entered at the command line.  
  
 One workload must be specified for each tuning session.  
  
## Example  
 The following code example specifies the **MyDatabase.MyDBOwner.TuningTable001** trace table for the **Workload** element. The **TuningTable001** was created by using the Tuning template with SQL Server Profiler and saving the trace output as a table.  
  
```  
<DTAXML ...>  
  <DTAInput>  
    <Server>  
...code removed here...  
    </Server>  
    <Workload>  
      <Database>  
        <Name>MyDatabase</Name>  
        <Schema>  
          <Name>MyDBOwner</Name>  
            <Table>  
              <Name>TuningTable001</Name>  
            </Table>  
        </Schema>  
      </Database>  
    </Workload>  
...code removed here...  
  </DTAInput>  
</DTAXML>  
```  
  
## See Also  
 [XML Input File Reference (Database Engine Tuning Advisor)](../../Topics/TopicNameNotContainA/XML-Input-File-Reference--Database-Engine-Tuning-Advisor-.md)