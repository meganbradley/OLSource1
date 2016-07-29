---
title: "Column Element for Index (DTA)"
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
ms.assetid: ba9fac20-26bd-4333-940e-842c15241b46
caps.latest.revision: 15
manager: jhubbard
---
# Column Element for Index (DTA)
Specifies the columns on which the index is created for a user-specified configuration.  
  
## Syntax  
  
```  
  
<Create>  
  <Index>  
    <Name>...</Name>  
    <Column [Type | SortOrder]>  
     ...code removed here...  
     </Column>  
```  
  
## Element Attributes  
  
 **Type**: Optional. Specifies the index column type. Use a **string** data type to specify this attribute with one of the following allowed values:  
  
-   **KeyColumn**  
  
     Specifies that the column is referenced by an index key. Use the following syntax to set this attribute:  
  
    ```  
    <Column Type="KeyColumn">  
    ```  
  
     For more information about key columns, see [Clustered and Nonclustered Indexes Described](../../Topics/TopicNameNotContainA/Clustered-and-Nonclustered-Indexes-Described.md).  
  
-   **IncludedColumn**  
  
     Specifies that the column is an included column (instead of a key column). Use the following syntax to set this attribute:  
  
    ```  
    <Column Type="IncludedColumn">  
    ```  
  
     For more information about included columns, see [Create Indexes with Included Columns](../../Topics/TopicNameNotContainA/Create-Indexes-with-Included-Columns.md).  
  
 **SortOrder**: Optional. Specifies the sorting order of the column. Use a **string** data type to specify either an **"Ascending"** or **"Descending"** sorting order as follows:  
  
```  
<Column SortOrder="Ascending">  
```  
  
## Element Characteristics  
  
|Characteristic|Description|  
|--------------------|-----------------|  
|**Data type and length**|None.|  
|**Default value**|None.|  
|**Occurrence**|Can specify up to 1024 columns for the **Index** element.|  
  
## Element Relationships  
  
|Relationship|Elements|  
|------------------|--------------|  
|**Parent element**|[Index Element (DTA)](../../Topics/TopicNameNotContainA/Index-Element--DTA-.md)|  
|**Child elements**|[Name Element for Column (DTA)](../../Topics/TopicNameNotContainA/Name-Element-for-Column--DTA-.md)|  
  
## Example  
 For a usage example of this element, see the [XML Input File Sample with User-specified Configuration (DTA)](../../Topics/TopicNameNotContainA/XML-Input-File-Sample-with-User-specified-Configuration--DTA-.md).  
  
## See Also  
 [XML Input File Reference (Database Engine Tuning Advisor)](../../Topics/TopicNameNotContainA/XML-Input-File-Reference--Database-Engine-Tuning-Advisor-.md)