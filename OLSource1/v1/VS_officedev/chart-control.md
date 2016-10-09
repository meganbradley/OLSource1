---
title: "Chart Control"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VST.ProjectItem.ExcelChart"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Chart control [Office development in Visual Studio], events"
  - "Chart control [Office development in Visual Studio]"
  - "Chart control [Office development in Visual Studio], data binding"
ms.assetid: 64f1a7cc-cc66-47da-aaeb-44a62ae53909
caps.latest.revision: 51
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
# Chart Control
  The \<xref:Microsoft.Office.Tools.Excel.Chart> control is a chart object that exposes events. When you add a chart to a worksheet, Visual Studio creates a \<xref:Microsoft.Office.Tools.Excel.Chart> object that you can program against directly without having to traverse the Microsoft Office Excel object model.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Creating the Control  
 You can add \<xref:Microsoft.Office.Tools.Excel.Chart> controls to a Microsoft Office Excel worksheet at design time or at run time in a document-level project.  
  
 You can add \<xref:Microsoft.Office.Tools.Excel.Chart> controls to a worksheet at run time in a VSTO Add-in. For more information, see [How to: Add Chart Controls to Worksheets](../VS_officedev/how-to--add-chart-controls-to-worksheets.md).  
  
> [!NOTE]  
>  Dynamically created chart objects are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md).  
  
## Formatting  
 All formatting that can be applied to a \<xref:Microsoft.Office.Interop.Excel.Chart> can also be applied to a \<xref:Microsoft.Office.Tools.Excel.Chart> control. This includes borders, fonts, chart type, gridlines, legend, and data labels.  
  
## Events  
 The following events are available for the \<xref:Microsoft.Office.Tools.Excel.Chart> control:  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.ActivateEvent>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.BeforeDoubleClick>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.BeforeRightClick>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.BindingContextChanged>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.Calculate>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.Deactivate>  
  
-   \<xref:System.ComponentModel.Component.Disposed>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.DragOver>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.DragPlot>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.MouseDown>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.MouseMove>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.MouseUp>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.Resize>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.SelectEvent>  
  
-   \<xref:Microsoft.Office.Tools.Excel.Chart.SeriesChange>  
  
## See Also  
 [Office Development Samples and Walkthroughs](../VS_officedev/office-development-samples-and-walkthroughs.md)   
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Controls on Office Documents](../VS_officedev/controls-on-office-documents.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [How to: Add Chart Controls to Worksheets](../VS_officedev/how-to--add-chart-controls-to-worksheets.md)   
 [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  