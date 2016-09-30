---
title: "How to: Create a Master-Detail Form by Using Two DataRepeater Controls (Visual Studio)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Create a Master/Detail Form by Using Two DataRepeater Controls (Visual Studio)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "DataRepeater, master/detail tables"
ms.assetid: eec43ae3-05d8-45a1-8d41-3803c6359dbe
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Master-Detail Form by Using Two DataRepeater Controls (Visual Studio)
You can display related data by using two or more \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> controls to create a master/detail form. For example, you might want to display a list of customers in one \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>, and when the user selects a customer, display a list of that customer's orders in a second \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>.  
  
 You can display related data by dragging detail items that share the same master table node from the **Data Sources** window onto a \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control. For example, if you have a data source that has a Customers table and a related Orders table, you see both tables as top-level nodes in the tree view in the **Data Sources** window. Expand the Customers node so that you can see the columns. Notice that the last column in the list is an expandable node that represents the Orders table. This node represents the related orders for a customer.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To display related data in two DataRepeater controls  
  
1.  Drag two \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> controls from the **Visual Basic PowerPacks** tab in the **Toolbox** to a form or container control.  
  
2.  Drag the sizing and position handles to size the controls and position them side-by-side.  
  
3.  On the **Data** menu, click **Show Data Sources**.  
  
    > [!NOTE]
    >  If the **Data Sources** window is empty, add a data source to it. For more information, see [Data Sources Overview](assetId:///ed28c625-bb89-4037-bfde-cfa435d182a2).  
  
4.  In the **Data Sources** window, select the top-level node for the master table.  
  
5.  Change the drop type of the master table to Details by clicking **Details** in the drop-down list on the table node.  
  
6.  Drag the master table node onto the item template region of the first \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control.  
  
7.  Expand the master table node and select the detail node for the related table.  
  
8.  Change the drop type of the detail table to Details by clicking **Details** in the drop-down list on the table node.  
  
9. Select this table node and drag it onto the item template region of the second \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>   
 [Introduction to the DataRepeater Control (Visual Basic)](../vs140/introduction-to-the-datarepeater-control--visual-studio-.md)   
 [How to: Display Bound Data in a DataRepeater Control (Visual Basic)](../vs140/how-to--display-bound-data-in-a-datarepeater-control--visual-studio-.md)   
 [How to: Display Related Data in a Windows Application](assetId:///60b1f1ec-6257-42ab-83f0-06d54ed364fd)   
 [How to: Change the Appearance of a DataRepeater Control (Visual Basic)](../vs140/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-.md)   
 [Troubleshooting the DataRepeater Control (Visual Basic)](../vs140/troubleshooting-the-datarepeater-control--visual-studio-.md)