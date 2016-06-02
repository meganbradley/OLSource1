---
title: CDC Splitter
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 167bc5c6-fa36-439d-987c-b20acd1a77e2
---
# CDC Splitter
  The CDC splitter splits a single flow of change rows from a CDC source data flow into different data flows for Insert, Update and Delete operations. The data flow is split based on the required column `__$operation` and its standard values in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] change tables.  
  
|Value of Operation|Output|Description|  
|------------------------|------------|-----------------|  
|1|Delete|Deleted Row|  
|2|Insert|Inserted row \(not available when using **Net with Merge** CDC mode\)|  
|3|Update|Before\-update row \(available only when using **All with Old Values** CDC mode\)|  
|4|Update|After\-update row \(follows the Before\-update\)|  
|5|Update|Merge row \(available only when using **Net with Merge** CDC mode\)|  
|Other|Error||  
  
 You can use the splitter to connect to pre\-defined INSERT, DELETE, and UPDATE outputs for further processing.  
  
 The CDC Splitter transformation has one regular input and one error output.  
  
## Error Handling  
 The CDC Splitter transformation has an error output. Input rows with an invalid value of the $operation column are considered erroneous and are handled according to the **ErrorRowDisposition** property of the input.  
  
 The component error output includes the following output columns:  
  
-   **Error Code**: Set to 1.  
  
-   **Error Column**: The source column causing the error \(for conversion errors\).  
  
-   **Error Row Columns**: The input columns of the row that caused the error.  
  
## Configuring the CDC Splitter  
 There are no configurable properties for the CDC splitter.  
  
 For more information about using the CDC splitter, see CDC Components for Microsoft SQL Server Integration Services.  
  
 The **Advanced Editor** dialog box contains the properties that can be set programmatically.  
  
 To open the **Advanced Editor** dialog box:  
  
-   In the **Data Flow** screen of your [!INCLUDE[ssISCurrent](../../Token\Other/ssISCurrent_md.md)] project, right click the CDC splitter and select **Show Advanced Editor**.  
  
## See Also  
 [Direct the CDC Stream According to the Type of Change](../../Topics\TopicNameNotContainA/Direct-the-CDC-Stream-According-to-the-Type-of-Change.md)  
  
  