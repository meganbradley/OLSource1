---
title: "How to: Search Data in a DataRepeater Control (Visual Studio)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "DataRepeater, implementing search"
  - "DataRepeater, searching data"
ms.assetid: a8ab5d17-b94f-43c4-8dd7-d0450226d73f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Search Data in a DataRepeater Control (Visual Studio)
When you are using a <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control that contains many records, you may want to let users search for a specific record. Rather than searching the data in the control itself, you can implement a search by querying the underlying <xref:System.Windows.Forms.BindingSource*>. If the item is found, you can then use the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater.CurrentItemIndex*> property to select the item and scroll it into view.  
  
### To implement search  
  
1.  Drag a <xref:System.Windows.Forms.TextBox*> control from the **Toolbox** onto the form that contains the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control.  
  
2.  In the Properties window, change the **Name** property to **SearchTextBox**.  
  
3.  Drag a <xref:System.Windows.Forms.Button*> control from the **Toolbox** onto the form that contains the <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*> control.  
  
4.  In the Properties window, change the **Name** property to **SearchButton**. Change the **Text** property to **Search**.  
  
5.  Double-click the <xref:System.Windows.Forms.Button*> control to open the Code Editor, and add the following code to the `SearchButton_Click` event handler.  
  
     [!code[VbPowerPacksDataRepeaterSearch#1](../vs140/codesnippet/VisualBasic/how-to--search-data-in-a-datarepeater-control--visual-studio-_1.vb)]
[!code[VbPowerPacksDataRepeaterSearch#1](../vs140/codesnippet/CSharp/how-to--search-data-in-a-datarepeater-control--visual-studio-_1.cs)]  
  
     Replace *ProductsBindingSource* with the name of the <xref:System.Windows.Forms.BindingSource*> for your <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>, and replace *ProductID* with the name of the field that you want to search.  
  
## See Also  
 <xref:Microsoft.VisualBasic.PowerPacks.DataRepeater*>   
 [Introduction to the DataRepeater Control (Visual Basic)](../vs140/introduction-to-the-datarepeater-control--visual-studio-.md)   
 [Troubleshooting the DataRepeater Control (Visual Basic)](../vs140/troubleshooting-the-datarepeater-control--visual-studio-.md)   
 [How to: Change the Appearance of a DataRepeater Control (Visual Basic)](../vs140/how-to--change-the-appearance-of-a-datarepeater-control--visual-studio-.md)