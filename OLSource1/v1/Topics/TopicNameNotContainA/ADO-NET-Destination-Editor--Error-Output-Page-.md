---
title: ADO NET Destination Editor (Error Output Page)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1a56c3cf-fb6a-416d-a62c-bb19fe441ae5
manager: jhubbard
---
# ADO NET Destination Editor (Error Output Page)
Use the **Error Output** page of the **ADO NET Destination Editor** dialog box to specify error handling options.  
  
 To learn more about the ADO NET destination, see [ADO NET Destination](../../Topics/TopicNameNotContainA/ADO-NET-Destination.md).  
  
 **To open the Error Output page**  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], open the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] package that has the ADO NET destination.  
  
2.  On the **Data Flow** tab, double-click the ADO NET destination.  
  
3.  In the **ADO NET Destination Editor**, click **Error Output**.  
  
## Options  
 **Input or Output**  
 View the name of the input.  
  
 **Column**  
 Not used.  
  
 **Error**  
 Specify what should happen when an error occurs: ignore the failure, redirect the row, or fail the component.  
  
 **Related Topics:** [Error Handling in Data](../../Topics/TopicNameNotContainA/Error-Handling-in-Data.md)  
  
 **Truncation**  
 Not used.  
  
 **Description**  
 View the description of the operation.  
  
 **Set this value to selected cells**  
 Specify what should happen to all the selected cells when an error or truncation occurs: ignore the failure, redirect the row, or fail the component.  
  
 **Apply**  
 Apply the error handling option to the selected cells.  
  
## See Also  
 [ADO NET Destination Editor (Connection Manager Page)](../../Topics/TopicNameNotContainA/ADO-NET-Destination-Editor--Connection-Manager-Page-.md)   
 [ADO NET Destination Editor (Mappings Page)](../../Topics/TopicNameNotContainA/ADO-NET-Destination-Editor--Mappings-Page-.md)