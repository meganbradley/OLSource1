---
title: "Built-in Collections in Expressions (Report Builder and SSRS)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 78d5e3b8-9320-4e4b-a025-e2de3cf7afa7
caps.latest.revision: 9
manager: mblythe
---
# Built-in Collections in Expressions (Report Builder and SSRS)
In an expression in a report, you can include references to the following built-in collections: ReportItems, Parameters, Fields, DataSets, DataSources, Variables, and built-in fields for global information such as the report name. Not all collections appear in the **Expression** dialog box. The DataSets and DataSources collections are available only at run-time for published reports on a report server. The ReportItems collection is collection of text boxes in a report region, for example, the text boxes on a page or in a page header.  
  
 For more information, see [Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expressions--Report-Builder-and-SSRS-.md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
##  <a name="Collections"></a> Understanding Built-in Collections  
 The following table lists the built-in collections available when you write an expression. Each row includes the case-sensitive programmatic name for the collection, whether you can use the Expression dialog box to interactively add a reference to the collection, an example, and a description that includes when the collection values are initialized and available for use.  
  
|Built-in Collection|Category in the Expression dialog box|Example|Description|  
|--------------------------|-------------------------------------------|-------------|-----------------|  
|**Globals**|Built-in Fields|`=Globals.ReportName`<br /><br /> `- or -`<br /><br /> `=Globals.PageNumber`|Represents global variables useful for reports, such as the report name or page number. Always available.<br /><br /> For more information, see [Built-in Globals and Users References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Built-in-Globals-and-Users-References--Report-Builder-and-SSRS-.md).|  
|**User**|Built-in Fields|`=User.UserID`<br /><br /> - or -<br /><br /> `=User.Language`|Represents a collection of data about the user running the report, such as the language setting or the user ID. Always available.<br /><br /> For more information, see [Built-in Globals and Users References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Built-in-Globals-and-Users-References--Report-Builder-and-SSRS-.md).|  
|**Parameters**|Parameters|`=Parameters("ReportMonth").Value`<br /><br /> - or -<br /><br /> `=Parameters!ReportYear.Value`|Represents the collection of report parameters, each of which can be single-value or multivalue. Not available until processing initialization is complete. For more information, see [Parameters Collection References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Parameters-Collection-References--Report-Builder-and-SSRS-.md).|  
|**Fields(** *<Dataset\>* **)**|Fields|`=Fields!Sales.Value`|Represents the collection of fields of the dataset that are available to the report. Available after data is retrieved from a data source into a dataset. For more information, see [Dataset Fields Collection References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Dataset-Fields-Collection-References--Report-Builder-and-SSRS-.md).|  
|**DataSets**|Not Displayed|`=DataSets("TopEmployees").CommandText`|Represents the collection of datasets referenced from the body of a report definition. Does not include data sources used only in page headers or page footers. Not available in local preview. For more information, see [DataSources and DataSets Collection References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/DataSources-and-DataSets-Collection-References--Report-Builder-and-SSRS-.md).|  
|**DataSources**|Not Displayed|`=DataSources("AdventureWorks2012").Type`|Represents the collection of data sources referenced from within the body of a report. Does not include data sources used only in page headers or page footers. Not available in local preview. For more information, see [DataSources and DataSets Collection References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/DataSources-and-DataSets-Collection-References--Report-Builder-and-SSRS-.md).|  
|**Variables**|`Variables`|`=Variables!CustomTimeStamp.Value`|Represents the collection of report variables and group variables. For more information, see [Report and Group Variables Collections References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Report-and-Group-Variables-Collections-References--Report-Builder-and-SSRS-.md).|  
|**ReportItems**|Not Displayed|`=ReportItems("Textbox1").Value`|Represents the collection of text boxes for a report item. This collection can be used to summarize items on the page for including in a page header or page footer. For more information, see [ReportItems Collection References (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/ReportItems-Collection-References--Report-Builder-and-SSRS-.md).|  
  
##  <a name="Syntax"></a> Using Collection Syntax in an Expression  
 To refer to a collection from an expression, use standard [!INCLUDE[msCoName](../../Topics/TopicNameContainA/includes/msCoName_md.md)] [!INCLUDE[vbprvb](../../Topics/TopicNameContainA/includes/vbprvb_md.md)] syntax for an item in a collection. The following table shows examples of collection syntax.  
  
|Syntax|Example|  
|------------|-------------|  
|*Collection!ObjectName.Property*|`=Fields!Sales.Value`|  
|*Collection!ObjectName("Property")*|`=Fields!Sales("Value")`|  
|*Collection("ObjectName").Property*|`=Fields("Sales").Value`|  
|*Collection("Member")*|`=User("Language")`|  
|*Collection.Member*|`=User.Language`|  
  
## See Also  
 [Add an Expression (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Add-an-Expression--Report-Builder-and-SSRS-.md)   
 [Expression Examples (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Examples--Report-Builder-and-SSRS-.md)