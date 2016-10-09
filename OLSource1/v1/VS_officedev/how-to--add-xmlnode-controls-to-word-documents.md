---
title: "How to: Add XMLNode Controls to Word Documents"
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
  - "XMLNode control, adding to documents"
  - "controls [Office development in Visual Studio], adding to documents"
ms.assetid: d583b9d4-bd13-46e3-9eb7-da18fcb7eb8c
caps.latest.revision: 29
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
# How to: Add XMLNode Controls to Word Documents
  **Important** The information set out in this topic regarding Microsoft Word is presented exclusively for the benefit and use of individuals and organizations who are located outside the United States and its territories or who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft before January 2010, when Microsoft removed an implementation of particular functionality related to custom XML from Microsoft Word. This information regarding Microsoft Word may not be read or used by individuals or organizations in the United States or its territories who are using, or developing programs that run on, Microsoft Word products that were licensed by Microsoft after January 10, 2010; those products will not behave the same as products licensed before that date or purchased and licensed for use outside the United States.  
  
 [!INCLUDE[appliesto_wdalldoc](../VS_officedev/includes/appliesto_wdalldoc_md.md)]  
  
 When you map a non-repeating XML schema element to a Microsoft Office Word document, Visual Studio automatically adds an \<xref:Microsoft.Office.Tools.Word.XMLNode> control to your document. For information about mapping repeating XML schema elements, see [How to: Add XMLNodes Controls to Word Documents](../VS_officedev/how-to--add-xmlnodes-controls-to-word-documents.md).  
  
> [!NOTE]  
>  The \<xref:Microsoft.Office.Tools.Word.XMLNode> control is not available from the **Toolbox** or the **Data Sources** window, and it cannot be created programmatically.  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
### To add an XMLNode control to a document  
  
1.  In the document in the Visual Studio designer, on the Ribbon, click the **Developer** tab.  
  
    > [!NOTE]  
    >  If the **Developer** tab is not visible, you must first show it. For more information, see [How to: Show the Developer Tab on the Ribbon](../VS_officedev/how-to--show-the-developer-tab-on-the-ribbon.md).  
  
2.  In the **XML** group, click **Schema**.  
  
     The **Templates and Add-ins** dialog box opens.  
  
3.  Click the **XML Schema** tab.  
  
4.  Click **Add Schema**.  
  
     The **Add Schema** dialog box opens.  
  
5.  Select an XML schema that contains non-repeating schema elements from the **Add Schema** dialog box and click **Open**.  
  
     The **Schema Settings** dialog box appears.  
  
6.  Assign an alias or click **OK** to add the schema without an alias.  
  
     The schema is added to the **Add Schema** dialog box.  
  
7.  In the **Add Schema** dialog box, click **OK**.  
  
8.  The **XML Structure** task pane opens.  
  
9. Click the non-repeating schema element on the **XML Structure** task pane to add it to the document.  
  
     An \<xref:Microsoft.Office.Tools.Word.XMLNode> control is created and added to the project.  
  
## See Also  
 [XMLNode Control](../VS_officedev/xmlnode-control.md)   
 [Automating Word by Using Extended Objects](../VS_officedev/automating-word-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  