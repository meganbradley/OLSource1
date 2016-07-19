---
title: Row Count Transformation
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b68293b9-a68c-40be-9d81-77342da1be29
manager: jhubbard
---
# Row Count Transformation
The Row Count transformation counts rows as they pass through a data flow and stores the final count in a variable.  
  
 A [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] package can use row counts to update the variables used in scripts, expressions, and property expressions. (For example, the variable that stores the row count can update the message text in an e-mail message to include the number of rows.) The variable that the Row Count transformation uses must already exist, and it must be in the scope of the Data Flow task to which the data flow with the Row Count transformation belongs.  
  
 The transformation stores the row count value in the variable only after the last row has passed through the transformation. Therefore, the value of the variable is not updated in time to use the updated value in the data flow that contains the Row Count transformation. You can use the updated variable in a separate data flow.  
  
 This transformation has one input and one output. It does not support an error output.  
  
## Configuration of the Row Count Transformation  
 You can set properties through [!INCLUDE[ssIS](../../Topics/TopicNameContainA/includes/ssIS_md.md)] Designer or programmatically.  
  
 The **Advanced Editor** dialog box reflects the properties that can be set programmatically. For more information about the properties that you can set in the **Advanced Editor** dialog box or programmatically, click one of the following topics:  
  
-   [Common Properties](../../Topics/TopicNameNotContainA/Common-Properties.md)  
  
-   [Transformation Custom Properties](../../Topics/TopicNameNotContainA/Transformation-Custom-Properties.md)  
  
## Related Tasks  
 For information about how to set the properties of this component, see [Set the Properties of a Data Flow Component](../../Topics/TopicNameContainA/Set-the-Properties-of-a-Data-Flow-Component.md).  
  
## See Also  
 [Integration Services (SSIS) Variables](../../Topics/TopicNameNotContainA/Integration-Services--SSIS--Variables.md)   
 [Data Flow](../../Topics/TopicNameNotContainA/Data-Flow.md)   
 [Integration Services Transformations](../../Topics/TopicNameNotContainA/Integration-Services-Transformations.md)