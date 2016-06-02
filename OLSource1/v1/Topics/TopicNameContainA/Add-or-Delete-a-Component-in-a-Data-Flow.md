---
title: Add or Delete a Component in a Data Flow
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d99124f9-0994-4f40-a48e-fdca6a4383e7
---
# Add or Delete a Component in a Data Flow
  Data flow components are sources, destinations, and transformations in a data flow. Before you can add components to a data flow, the control flow in the package must include a Data Flow task.  
  
 The following procedures describe how to add or delete a component in the data flow of a package.  
  
### To add a component to a data flow  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)], open the [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] project that contains the package you want.  
  
2.  In Solution Explorer, double\-click the package to open it.  
  
3.  Click the **Control Flow** tab, and then double\-click the Data Flow task that contains the data flow to which you want to add a component.  
  
4.  In the Toolbox, expand **Data Flow Sources**, **Data Flow Transformations**, or **Data Flow Destinations**, and then drag a data flow item to the design surface of the **Data Flow** tab.  
  
5.  To save the updated package, click **Save Selected Items** on the **File** menu.  
  
### To delete a component from a data flow  
  
1.  In [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)], open the [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] project that contains the package you want.  
  
2.  In Solution Explorer, double\-click the package to open it.  
  
3.  Click the **Control Flow** tab, and then double\-click the Data Flow task that contains the data flow from which you want to delete a component.  
  
4.  Right\-click the data flow component, and then click **Delete**.  
  
5.  Confirm the delete operation.  
  
6.  To save the updated package, click **Save Selected Items** on the **File** menu.  
  
## See Also  
 [Connect Components in a Data Flow](../../Topics\TopicNameContainA/Connect-Components-in-a-Data-Flow.md)   
 [Configure an Error Output in a Data Flow Component](../../Topics\TopicNameContainA/Configure-an-Error-Output-in-a-Data-Flow-Component.md)   
 [Data Flow](../../Topics\TopicNameNotContainA/Data-Flow.md)  
  
  