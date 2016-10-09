---
title: "How to: Programmatically Cache a Data Source in an Office Document"
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
  - "Office applications [Office development in Visual Studio], data"
  - "datasets [Office development in Visual Studio], caching"
  - "StartCaching method"
  - "data caching [Office development in Visual Studio], programmatically"
  - "data [Office development in Visual Studio], caching"
ms.assetid: 70b3fc06-7534-407e-898b-36f84e9a7516
caps.latest.revision: 43
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
# How to: Programmatically Cache a Data Source in an Office Document
  You can programmatically add a data object to the data cache in a document by calling the `StartCaching` method of a host item, such as a \<xref:Microsoft.Office.Tools.Word.Document>, \<xref:Microsoft.Office.Tools.Excel.Workbook>, or \<xref:Microsoft.Office.Tools.Excel.Worksheet>. Remove a data object from the data cache by calling the `StopCaching` method of a host item.  
  
 The `StartCaching` method and the `StopCaching` method are both private, but they appear in IntelliSense.  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
 When you use the `StartCaching` method to add a data object to the data cache, the data object does not need to be declared with the \<xref:Microsoft.VisualStudio.Tools.Applications.Runtime.CachedAttribute> attribute. However, the data object must meet certain requirements to be added to the data cache. For more information, see [Caching Data](../VS_officedev/caching-data.md).  
  
### To programmatically cache a data object  
  
1.  Declare the data object at the class level, not inside a method. This example assumes that you are declaring a \<xref:System.Data.DataSet> named `dataSet1` that you want to cache programmatically.  
  
     [!code[Trin_VstcoreDataExcel#12](../VS_officedev/codesnippet/CSharp/how-to--programmatically-cache-a-data-source-in-an-office-document_1.cs)]
[!code[Trin_VstcoreDataExcel#12](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-cache-a-data-source-in-an-office-document_1.vb)]  
  
2.  Instantiate the data object, and then call the `StartCaching` method of the document or worksheet instance and pass in the name of the data object.  
  
     [!code[Trin_VstcoreDataExcel#13](../VS_officedev/codesnippet/CSharp/how-to--programmatically-cache-a-data-source-in-an-office-document_2.cs)]
[!code[Trin_VstcoreDataExcel#13](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-cache-a-data-source-in-an-office-document_2.vb)]  
  
### To stop caching a data object  
  
1.  Call the `StopCaching` method of the document or worksheet instance and pass in the name of the data object. This example assumes that you have a \<xref:System.Data.DataSet> named `dataSet1` that you want to stop caching.  
  
     [!code[Trin_VstcoreDataExcel#14](../VS_officedev/codesnippet/CSharp/how-to--programmatically-cache-a-data-source-in-an-office-document_3.cs)]
[!code[Trin_VstcoreDataExcel#14](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-cache-a-data-source-in-an-office-document_3.vb)]  
  
    > [!NOTE]  
    >  Do not call `StopCaching` from the event handler for the `Shutdown` event of a document or worksheet. By the time the `Shutdown` event is raised, it is too late to modify the data cache. For more information about the `Shutdown` event, see [Events in Office Projects](../VS_officedev/events-in-office-projects.md).  
  
## See Also  
 [Caching Data](../VS_officedev/caching-data.md)   
 [How to: Cache Data for Use Offline or on a Server](../VS_officedev/how-to--cache-data-for-use-offline-or-on-a-server.md)   
 [How to: Cache Data in a Password-Protected Document](../VS_officedev/how-to--cache-data-in-a-password-protected-document.md)   
 [Accessing Data in Documents on the Server](../VS_officedev/accessing-data-in-documents-on-the-server.md)   
 [Saving Data](../Topic/Saving%20Data.md)  
  
  