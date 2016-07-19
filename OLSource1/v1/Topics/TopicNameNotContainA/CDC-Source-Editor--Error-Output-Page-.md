---
title: CDC Source Editor (Error Output Page)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8a4c2cb8-fd2f-4c45-824f-b93473a8981e
manager: jhubbard
---
# CDC Source Editor (Error Output Page)
Use the **Error Output** page of the **CDC Source Editor** dialog box to select error handling options.  
  
 To learn more about the CDC source, see [CDC Source](../../Topics/TopicNameNotContainA/CDC-Source.md).  
  
## Task List  
 **To open the CDC Source Editor Error Output Page**  
  
1.  In [!INCLUDE[ssBIDevStudio](../../Topics/TopicNameContainA/includes/ssBIDevStudio_md.md)], open the [!INCLUDE[ssISCurrent](../../Topics/TopicNameContainA/includes/ssISCurrent_md.md)] package that has the CDC source.  
  
2.  On the **Data Flow** tab, double-click the CDC source.  
  
3.  In the **CDC Source Editor**, click **Error Output**.  
  
## Options  
 **Input/Output**  
 View the name of the data source.  
  
 **Column**  
 View the external (source) columns that you selected on the **Connection Manager** page of the **CDC Source Editor** dialog box.  
  
 **Error**  
 Select how the CDC source should handle errors in a flow: ignore the failure, redirect the row, or fail the component.  
  
 **Truncation**  
 Select how the CDC source should handle truncation in a flow: ignore the failure, redirect the row, or fail the component.  
  
 **Description**  
 Not used.  
  
 **Set this value to selected cells**  
 Select how the CDC source handles all selected cells when an error or truncation occurs: ignore the failure, redirect the row, or fail the component.  
  
 **Apply**  
 Apply the error handling options to the selected cells.  
  
## Error Handling Options  
 You use the following options to configure how the CDC source handles errors and truncations.  
  
 **Fail Component**  
 The Data Flow task fails when an error or a truncation occurs. This is the default behavior.  
  
 **Ignore Failure**  
 The error or the truncation is ignored and the data row is directed to the CDC source output.  
  
 **Redirect Flow**  
 The error or the truncation data row is directed to the error output of the CDC source. In this case the CDC source error handling is used. For more information, see [CDC Source](../../Topics/TopicNameNotContainA/CDC-Source.md).  
  
## See Also  
 [CDC Source Editor (Connection Manager Page)](../../Topics/TopicNameNotContainA/CDC-Source-Editor--Connection-Manager-Page-.md)   
 [CDC Source Editor (Columns Page)](../../Topics/TopicNameNotContainA/CDC-Source-Editor--Columns-Page-.md)