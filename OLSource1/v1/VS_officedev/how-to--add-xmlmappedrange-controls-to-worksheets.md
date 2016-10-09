---
title: "How to: Add XMLMappedRange Controls to Worksheets"
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
  - "XMLMappedRange control, adding to worksheets"
  - "controls [Office development in Visual Studio], adding to worksheets"
ms.assetid: e1d4f2a8-1157-49c2-9158-a1253b709cb8
caps.latest.revision: 25
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
# How to: Add XMLMappedRange Controls to Worksheets
  When you map an XML element to a cell in Microsoft Office Excel, Visual Studio automatically adds an \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control to your worksheet.  
  
 [!INCLUDE[appliesto_xlalldoc](../VS_officedev/includes/appliesto_xlalldoc_md.md)]  
  
> [!NOTE]  
>  The \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control is not available on the **Toolbox** or the **Data Sources** window. Additionally, you cannot create \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> controls programmatically.  
  
### To add an XMLMappedRange control to a worksheet  
  
1.  Open the Excel workbook in the Visual Studio designer.  
  
2.  Open the worksheet where you want to add the control.  
  
3.  On the **Developer** tab, click **Source**.  
  
    > [!NOTE]  
    >  If the **Developer** tab is not visible on the Ribbon, you must enable it. For more information, see [How to: Show the Developer Tab on the Ribbon](../VS_officedev/how-to--show-the-developer-tab-on-the-ribbon.md).  
  
     The **XML Source** task pane appears.  
  
4.  In the **XML Source** task pane, click **XML Maps**.  
  
5.  In the **XML Maps** dialog box, click **Add**.  
  
     The **XML Source** dialog box appears.  
  
6.  Select an XML schema from the **XML Source** dialog box and click **Open**.  
  
     The schema is added to the **XML Maps** dialog box.  
  
7.  In the **XML Maps** dialog box, click **OK**.  
  
8.  Drag an element from the **XML Source** task pane to a cell on the worksheet.  
  
     An \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> is created and added to the project.  
  
    > [!NOTE]  
    >  If you drag a parent element from the **XML Source** task pane, a \<xref:Microsoft.Office.Tools.Excel.ListObject> control is created.  
  
## See Also  
 [XmlMappedRange Control](../VS_officedev/xmlmappedrange-control.md)   
 [Automating Excel by Using Extended Objects](../VS_officedev/automating-excel-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [How to: Map Schemas to Worksheets Inside Visual Studio](../VS_officedev/how-to--map-schemas-to-worksheets-inside-visual-studio.md)  
  
  