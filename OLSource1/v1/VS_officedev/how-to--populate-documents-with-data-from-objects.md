---
title: "How to: Populate Documents with Data from Objects"
ms.custom: na
ms.date: "09/16/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents [Office development in Visual Studio], populating with data"
  - "data [Office development in Visual Studio], adding to documents"
ms.assetid: 83e6ebac-e468-4bef-a91c-78c7bf597a75
caps.latest.revision: 41
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Populate Documents with Data from Objects
  Accesing data in a data object works the same way in document-level projects for Microsoft Office Word as it does in Windows Forms projects. You use the same tools and code to bring the data from an object into your solution, and you can use Windows Forms controls to display the data. In addition, you can display data by using host controls. Host controls are native objects in Microsoft Office Word that have been enhanced with events and data binding capability. For more information, see [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md).  
  
 [!INCLUDE[appliesto_controls](../VS_officedev/includes/appliesto_controls_md.md)]  
  
 You must complete three basic steps to populate the document with data from an object:  
  
-   Add a control to the document that you can bind to data.  
  
-   Add a data object to the document.  
  
-   Connect the data object to the BindingSource.   
  
## Adding a Data Object  
  
#### To add a data object  
  
-   Open the **Data Sources** window and create a data source from an object. For more information, see [How to: Connect to Data in Objects](../Topic/How%20to:%20Connect%20to%20Data%20in%20Objects.md).  
  
## Connecting the Data Object to the BindingSource  
 In document-level projects, you add controls to your document and bind them to data at design time.  
  
 In VSTO Add-in projects, you create controls and bind them at run time.  
  
### Document-Level Projects  
  
##### To connect the data object to the BindingSource  
  
1.  Drag the data field you want from the **Data Sources** window to your document. This automatically creates a control.  
  
2.  In your code, create an instance of the type of the object that you chose for the data source.  
  
3.  Assign the instance to the \<xref:System.Windows.Forms.BindingSource.DataSource*> property of the \<xref:System.Windows.Forms.BindingSource>.  
  
### Application-Level Projects  
  
##### To connect the data object to the BindingSource  
  
1.  In your code, create an instance of the type of the object that is associated with the data source.  
  
2.  Create an instance of a \<xref:System.Windows.Forms.BindingSource>.  
  
3.  Assign the data source instance to the \<xref:System.Windows.Forms.BindingSource.DataSource*> property of the \<xref:System.Windows.Forms.BindingSource>.  
  
4.  Add the data source as a databinding to the control.  
  
## See Also  
 
 [Add new data sources](../Topic/Add%20new%20data%20sources.md)   
 [Bind Windows Forms controls to data in Visual Stduio](Bind%20Windows%20Forms%20controls%20to%20data%20in%20Visual%20Studio.xml)
 
 [How to: Populate Documents with Data from a Database](../VS_officedev/how-to--populate-documents-with-data-from-a-database.md)   
 [How to: Update a Data Source with Data from a Host Control](../VS_officedev/how-to--update-a-data-source-with-data-from-a-host-control.md)   
 [Connecting to Data in Windows Forms Applications](../Topic/Connecting%20to%20Data%20in%20Windows%20Forms%20Applications.md)   
 [BindingSource Component Overview](../Topic/BindingSource%20Component%20Overview.md)  
  
  