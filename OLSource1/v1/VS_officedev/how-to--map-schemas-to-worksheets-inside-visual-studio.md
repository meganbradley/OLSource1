---
title: "How to: Map Schemas to Worksheets Inside Visual Studio"
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
  - "XML schemas [Office development in Visual Studio], mapping"
  - "mappings [Office development in Visual Studio], XML schemas to Excel worksheets"
  - "Excel [Office development in Visual Studio], XML schemas"
  - "worksheets [Office development in Visual Studio], XML schemas"
ms.assetid: cef3f751-c1cf-46f3-9177-0bacdcee4121
caps.latest.revision: 36
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
# How to: Map Schemas to Worksheets Inside Visual Studio
  You can map an XML schema to a worksheet while the worksheet is open in Visual Studio. You use the same Microsoft Office Excel tools that you use when the workbook is open outside of Visual Studio. The Office project creates the same objects whether you map the schema to the worksheet before or after you create your Excel solution.  
  
 [!INCLUDE[appliesto_xlalldoc](../VS_officedev/includes/appliesto_xlalldoc_md.md)]  
  
> [!NOTE]  
>  You cannot use multipart XML schemas in Excel solutions.  
  
### To map an XML schema to an Excel worksheet in Visual Studio  
  
1.  Open the Excel workbook or template project inside Visual Studio.  
  
2.  Click in the worksheet to move the focus to the designer.  
  
3.  On the Ribbon, click the **Developer** tab.  
  
    > [!NOTE]  
    >  If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the Developer Tab on the Ribbon](../VS_officedev/how-to--show-the-developer-tab-on-the-ribbon.md).  
  
4.  In the **XML** group, click **Source**.  
  
     The **XML Source** window opens.  
  
5.  In the **XML Source** window, click **XML Maps**.  
  
     The **XML Maps** dialog box opens.  
  
6.  In the **XML Maps** dialog box, click **Add**.  
  
7.  Browse to your schema file, select it, and then click **Open**.  
  
8.  Click **OK**.  
  
     The schema is represented in the **XML Source** window. In your project, a typed \<xref:System.Data.DataSet> is generated based on the schema, and a \<xref:System.Windows.Forms.BindingSource> is created.  
  
9. Drag elements from the **XML Source** window to the places in your worksheet where you want the corresponding controls to be created.  
  
     If you drag a non-repeating schema element, the Office project generates an \<xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control that is automatically bound to the \<xref:System.Windows.Forms.BindingSource>.  
  
     If you drag a repeating schema element, the Office project generates a \<xref:Microsoft.Office.Tools.Excel.ListObject> control that is not automatically bound to a data source. For more information, see [XML Schemas and Data in Document-Level Customizations](../VS_officedev/xml-schemas-and-data-in-document-level-customizations.md).  
  
## See Also  
 [How to: Map Schemas to Word Documents Inside Visual Studio](../VS_officedev/how-to--map-schemas-to-word-documents-inside-visual-studio.md)   
 [XML Schemas and Data in Document-Level Customizations](../VS_officedev/xml-schemas-and-data-in-document-level-customizations.md)  
  
  