---
title: "How to: Populate Documents with Data from a Database"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents, populating with data"
  - "data, adding to documents"
ms.assetid: 1eb5b13d-7359-407e-8be8-e42c1829f10c
caps.latest.revision: 48
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Populate Documents with Data from a Database
  You can access data in document-level projects for Microsoft Office in the same way that you access data in Windows Forms projects. You use the same tools and code to bring the data from a database into your solution, and you can use Windows Forms controls to display the data.  
  
 In addition, you can display data by using host controls. Host controls are native objects in Microsoft Office Word that have been enhanced with events and data binding capability. For more information, see [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md).  
  
 [!INCLUDE[appliesto_wdalldoc](../VS_officedev/includes/appliesto_wdalldoc_md.md)]  
  
 The following example shows how to add data-bound controls in document-level projects using a designer. For an example of how to add data-bound controls in VSTO Add-in projects at run time, see [Walkthrough: Simple Data Binding in VSTO add-in Project](../VS_officedev/walkthrough--simple-data-binding-in-vsto-add-in-project.md).  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [Binding Data to Word 2007 Content Controls Using Visual Studio Tools for the Office System (3.0)](http://go.microsoft.com/fwlink/?LinkId=136785).  
  
## Adding a Control to a Document at Design Time  
  
#### To populate a document with data from a database  
  
1.  Open a Word document-level project in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)], with the document open in the designer.  
  
2.  Open the **Data Sources** window and create a data source from a database. For more information, see [How to: Connect to Data in a Database](../Topic/How%20to:%20Connect%20to%20Data%20in%20a%20Database.md).  
  
3.  Drag the field you want from the **Data Sources** window to your document.  
  
 A content control is added to the document. The type of content control depends on the data type of the field you selected. For more information, see [Content Controls](../VS_officedev/content-controls.md).  
  
 You can add a different control by selecting the data field in the **Data Sources** window and then choosing a different control from the drop-down list.  
  
## Objects in the Project  
 In addition to the control, the following data-related objects are automatically added to your project:  
  
-   A typed dataset that encapsulates the data tables that you connected to in the database. For more information, see [Dataset tools in Visual Studio](../Topic/Dataset%20tools%20in%20Visual%20Studio.md).  
  
-   A \<xref:System.Windows.Forms.BindingSource> that connects the control to the typed dataset. For more information, see [BindingSource Component Overview](../Topic/BindingSource%20Component%20Overview.md).  
  
-   A TableAdapter that connects the typed dataset to the database. For more information, see [TableAdapter Overview](../Topic/TableAdapter%20Overview.md).  
  
-   A TableAdapterManager, which is used to coordinate table adapters in the dataset to enable hierarchical updates. For more information, see [Hierarchical Update](../Topic/Hierarchical%20Update.md) and [TableAdapterManager Overview](../Topic/TableAdapterManager%20Overview.md).  
  
 When you run the project, the control displays the first record in the data source. You can use the \<xref:System.Windows.Forms.BindingSource> to enable users to scroll through the records.  
  
#### To scroll through the records  
  
-   Use \<xref:System.Windows.Forms.BindingSource> methods such as \<xref:System.Windows.Forms.BindingSource.MoveNext*> and \<xref:System.Windows.Forms.BindingSource.MovePrevious*>.  
  
 For information about how to send updates to the typed dataset and the database, see [How to: Update a Data Source with Data from a Host Control](../VS_officedev/how-to--update-a-data-source-with-data-from-a-host-control.md).  
  
## See Also  
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [Add new data sources](../Topic/Add%20new%20data%20sources.md)   
 [Binding Windows Forms controls to data in Visual Studio](../Topic/Binding%20Windows%20Forms%20controls%20to%20data%20in%20Visual%20Studio.md)   
 [How to: Populate Documents with Data from Objects](../VS_officedev/how-to--populate-documents-with-data-from-objects.md)   
 [How to: Update a Data Source with Data from a Host Control](../VS_officedev/how-to--update-a-data-source-with-data-from-a-host-control.md)   
 [Using Local Database Files in Office Solutions Overview](../VS_officedev/using-local-database-files-in-office-solutions-overview.md)   
 [Connecting to Data in Windows Forms Applications](../Topic/Connecting%20to%20Data%20in%20Windows%20Forms%20Applications.md)   
 [BindingSource Component Overview](../Topic/BindingSource%20Component%20Overview.md)  
  
  