---
title: "How to: Export a Ribbon from the Ribbon Designer to Ribbon XML"
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
  - "custom Ribbon, XML"
  - "customizing the Ribbon, XML"
  - "Ribbon [Office development in Visual Studio], XML"
  - "Ribbon [Office development in Visual Studio], exporting"
  - "XML [Office development in Visual Studio], Ribbon"
  - "Ribbon Designer [Office development in Visual Studio]"
  - "exporting Ribbon"
ms.assetid: 96e0e9ed-4392-4f45-ac33-b6f7c22ea321
caps.latest.revision: 37
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
# How to: Export a Ribbon from the Ribbon Designer to Ribbon XML
  The **Ribbon (Visual Designer)** item does not support all possible types of Ribbon customization. To customize the Ribbon in advanced ways, you can export the Ribbon from the designer to Ribbon XML and edit the XML directly.  
  
> [!NOTE]  
>  Not all property values appear in the Ribbon XML file. For more information, see [Ribbon Overview](../VS_officedev/ribbon-overview.md).  
  
 [!INCLUDE[appliesto_ribbon](../VS_officedev/includes/appliesto_ribbon_md.md)]  
  
### To export a Ribbon from the Ribbon Designer to Ribbon XML  
  
1.  Right-click the Ribbon code file in **Solution Explorer**, and then click **View Designer**.  
  
2.  Right-click the Ribbon Designer, and then click **Export Ribbon to XML**.  
  
     Visual Studio adds a Ribbon XML file and a Ribbon XML code file to your project.  
  
3.  In the Ribbon code class, locate the comments that start with `TODO:`.  
  
4.  Copy the code block in these comments to the **ThisAddin**, **ThisWorkbook**, or **ThisDocument** class, depending on which type of solution you are developing.  
  
     This code enables the Microsoft Office application to discover and load your custom Ribbon. For more information, see [Ribbon XML](../VS_officedev/ribbon-xml.md).  
  
5.  In the **ThisAddin**, **ThisWorkbook**, or **ThisDocument** class, uncomment the code block.  
  
     After you uncomment the code, it should resemble the following example. In this example, the Ribbon class is called `MyRibbon`.  
  
     [!code[Trin_Ribbon_Custom_Tab_XML#1](../VS_officedev/codesnippet/CSharp/how-to--export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml_1.cs)]
[!code[Trin_Ribbon_Custom_Tab_XML#1](../VS_officedev/codesnippet/VisualBasic/how-to--export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml_1.vb)]  
  
6.  Switch to the Ribbon XML code file and find the `Ribbon Callbacks` region.  
  
     This is where you write callback methods to handle user actions, such as clicking a button.  
  
7.  Create a callback method for each event handler that you wrote in the Ribbon Designer code.  
  
8.  Move all your event handler code from the event handlers to the callback methods, and modify the code to work with the Ribbon extensibility (RibbonX) programming model.  
  
     For information about writing callback methods and using the RibbonX programming model, see [Ribbon XML](../VS_officedev/ribbon-xml.md).  
  
## See Also  
 [Ribbon Overview](../VS_officedev/ribbon-overview.md)   
 [Ribbon Designer](../VS_officedev/ribbon-designer.md)   
 [Ribbon XML](../VS_officedev/ribbon-xml.md)   
 [Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-the-ribbon-designer.md)   
 [Walkthrough: Creating a Custom Tab by Using Ribbon XML](../VS_officedev/walkthrough--creating-a-custom-tab-by-using-ribbon-xml.md)  
  
  