---
title: "SAP BW Destination Editor (Advanced Page)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 862957db-bbc6-4dda-bc0e-591457f1baa7
caps.latest.revision: 11
manager: jhubbard
---
# SAP BW Destination Editor (Advanced Page)
Use the **Advanced** page of the **SAP BW Destination Editor** to set advanced settings such as package size and time-out information.  
  
 To learn more about the SAP BW destination of the [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] Connector 1.1 for SAP BW, see [SAP BW Destination](../../Topics/TopicNameNotContainA/SAP-BW-Destination.md).  
  
> [!IMPORTANT]  
>  The documentation for the Microsoft Connector 1.1 for SAP BW assumes familiarity with the SAP Netweaver BW environment. For more information about SAP Netweaver BW, or for information about how to configure SAP Netweaver BW objects and processes, see your SAP documentation.  
  
 **To open the Advanced page**  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)], open the [!INCLUDE[ssISnoversion](../../Topics/TopicNameContainA/includes/ssISnoversion_md.md)] package that contains the SAP BW destination.  
  
2.  On the **Data Flow** tab, double-click the SAP BW destination.  
  
3.  In the **SAP BW Destination Editor**, click **Advanced** to open the **Advanced** page of the editor.  
  
## Options  
  
> [!NOTE]  
>  If you do not know all the values that are required to configure the destination, you might have to ask your SAP administrator.  
  
 **Package size**  
 Specify how many rows of data will be transferred at a time. The optimal value for this parameter depends on the SAP Netweaver BW system and on additional processing of the data that might occur. Typically, values between 2000 and 20000 offer the best performance.  
  
 **Trigger process chain**  
 (Optional) Specify the name of a process chain to be triggered after the loading of data is completed.  
  
 **Timeout for waiting InfoPackage**  
 Specify the maximum number of seconds that the destination should wait for the InfoPackage to finish.  
  
 **Wait for data transfer to finish**  
 Specify whether the destination should wait until the SAP Netweaver BW system has finished loading the data.  
  
 **No InfoPackage Start (Only Wait)**  
 Specify that the destination does not trigger an InfoPackage, but just waits for notification that the SAP Netweaver BW system has started loading the data.  
  
## See Also  
 [SAP BW Destination Editor (Connection Manager Page)](../../Topics/TopicNameNotContainA/SAP-BW-Destination-Editor--Connection-Manager-Page-.md)   
 [SAP BW Destination Editor (Mappings Page)](../../Topics/TopicNameNotContainA/SAP-BW-Destination-Editor--Mappings-Page-.md)   
 [SAP BW Destination Editor (Error Output Page)](../../Topics/TopicNameNotContainA/SAP-BW-Destination-Editor--Error-Output-Page-.md)   
 [Microsoft Connector for SAP BW F1 Help](../../Topics/TopicNameNotContainA/Microsoft-Connector-for-SAP-BW-F1-Help.md)