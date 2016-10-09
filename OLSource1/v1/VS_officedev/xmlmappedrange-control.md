---
title: "XmlMappedRange Control"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "XMLMappedRange control, data binding"
  - "XMLMappedRange control"
  - "XMLMappedRange control, events"
ms.assetid: af1ae1b7-6cbe-4d6b-bc22-d9a3c8740665
caps.latest.revision: 40
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
# XmlMappedRange Control
  The \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control is a range that is created only when a non-repeating schema element is mapped onto a cell in Microsoft Office Excel. For example, when the `maxOccurs` attribute of a schema element equals 1. After Visual Studio creates the XML mapped range, you can program against it directly without having to traverse the Excel object model. You can only delete a \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control within Excel when the element mapping is removed.  
  
 [!INCLUDE[appliesto_xlalldoc](../VS_officedev/includes/appliesto_xlalldoc_md.md)]  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Use XML Mapping in Excel?](http://go.microsoft.com/fwlink/?LinkID=130288).  
  
## Binding Data to the Control  
 An \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control supports binding to a single data field (simple data binding). The \<xref:Microsoft.Office.Tools.Excel.ListObject> control can supports complex data binding, and is automatically created when a repeating schema element is mapped onto a cell. For more information, see [ListObject Control](../VS_officedev/listobject-control.md).  
  
 The \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control are bound to a data source using the \<xref:System.Windows.Forms.Control.DataBindings*> property. When an \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> is added to a worksheet cell, Visual Studio automatically generates a data set from the data in the mapped cells, and binds the control to that data set. The default data binding property of the \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> is \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Value2*>.  
  
 If the data in the bound data set is updated through any mechanism, the \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control reflects the changes.  
  
## Formatting  
 You can apply the same formatting to an \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control that you can apply to a \<xref:Microsoft.Office.Interop.Excel.Range>. This includes borders, fonts, number format, and styles.  
  
## Events  
 The events available for the \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control are:  
  
-   \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.BeforeDoubleClick>  
  
-   \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.BeforeRightClick>  
  
-   \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.BindingContextChanged>  
  
-   \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Change>  
  
-   \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Selected>  
  
-   \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Deselected>  
  
-   \<xref:System.ComponentModel.Component.Disposed>  
  
-   \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange.SelectionChange>  
  
## See Also  
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [How to: Add XMLMappedRange Controls to Worksheets](../VS_officedev/how-to--add-xmlmappedrange-controls-to-worksheets.md)   
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [How to: Map Schemas to Worksheets Inside Visual Studio](../VS_officedev/how-to--map-schemas-to-worksheets-inside-visual-studio.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  