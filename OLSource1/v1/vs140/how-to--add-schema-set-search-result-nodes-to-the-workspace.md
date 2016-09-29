---
title: "How to: Add Schema Set Search Result Nodes to the Workspace"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ff33b3cc-4db9-4b4e-9378-b45ed5999b18
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add Schema Set Search Result Nodes to the Workspace
This topic explains how to add nodes that are highlighted in the XML Schema Explorer as the result of a keyword search in the workspace.  
  
> [!NOTE]
>  Only global nodes can be added to the [workspace](../vs140/xml-schema-designer-workspace.md).  
  
 This example uses the sample [Purchase Order Schema](../vs140/sample-xsd-file--purchase-order-schema.md).  
  
### To add schema set result nodes  
  
1.  Follow the steps in [How to: Create and Edit an XSD Schema File](../vs140/how-to--create-and-edit-an-xsd-schema-file.md).  
  
2.  Type "purchaseOrder" in the search text box of the [XML Explorer](../vs140/xml-schema-explorer.md) toolbar and click on the search button.  
  
     ![XML Schema Explorer Keyword Search](../vs140/media/schemaexplorersearch.gif "SchemaExplorerSearch")  
  
     The search results are highlighted in the XML Schema Explorer and marked by ticks on the vertical scroll bar.  
  
3.  Add the search results to the workspace by clicking the **Add highlighted nodes to Workspace** button on the summary results pane.  
  
     ![XML Schema Explorer Search Result](../vs140/media/schemaexplorersearchresult.gif "SchemaExplorerSearchResult")  
  
     The `purchaseOrder` node and the `PurchaseOrderType` node appear next to each other on the design surface of the [Graph View](../vs140/graph-view.md). Because the two nodes are related (the `purchaseOrder` element is of the `PurchaseOrderType` type), an arrow is drawn between them.