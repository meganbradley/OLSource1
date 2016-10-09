---
title: "How to: Programmatically Add Pictures and Word Art to Documents"
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
  - "documents [Office development in Visual Studio], adding pictures"
  - "Word documents, adding pictures"
  - "Word documents, adding Word Art"
  - "graphics, adding to Word documents"
  - "WordArt, adding to documents"
ms.assetid: 944e1858-bc7c-471f-b5e7-adf3b0fa574d
caps.latest.revision: 24
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
# How to: Programmatically Add Pictures and Word Art to Documents
  You can add pictures and drawing objects to your documents at design time or during run time. WordArt enables you to add decorative text to Microsoft Office Word documents. These special text effects are drawing objects that you can customize and insert into your document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Adding a Picture at Design Time  
 If you are developing a document-level customization, you can add a picture to the document at design time.  
  
#### To add a picture to a Word document at design time  
  
1.  Place your cursor where you want to insert the picture in the document.  
  
2.  Click the **Insert** tab of the Ribbon.  
  
3.  In the **Illustrations** group, click **Picture**.  
  
4.  In the **Insert Picture** dialog box, navigate to the picture you want to insert, and click **Insert**.  
  
     The picture is added to your document at the current cursor location.  
  
## Adding a Picture at Run Time  
 You can insert a picture into a document at the current cursor location.  
  
#### To add a picture at the cursor location  
  
1.  Call the \<xref:Microsoft.Office.Interop.Word.InlineShapes.AddPicture*> method of the \<xref:Microsoft.Office.Interop.Word.InlineShapes> collection and pass in the name of the file.  
  
     [!code[Trin_VstcoreWordAutomation#108](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-pictures-and-word-art-to-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#108](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-pictures-and-word-art-to-documents_1.cs)]  
  
## Adding WordArt at Design Time  
 If you are developing a document-level customization, you can add WordArt to the document at design time.  
  
#### To add WordArt to a Word document at design time  
  
1.  Place your cursor where you want to insert the WordArt in the document.  
  
2.  Click the **Insert** tab of the Ribbon.  
  
3.  In the **Text** group, click **WordArt**, and then select a WordArt style.  
  
4.  Add the text that you want to appear in the document to the **Edit WordArt Text** dialog box and click **OK**.  
  
     The text is added to your document with the selected WordArt style applied.  
  
## Adding WordArt at Run Time  
 You can insert WordArt into a document at the current cursor location. The procedure is different for document-level customizations and VSTO Add-ins.  
  
#### To add WordArt at the cursor location in a document-level customization  
  
1.  Get the left and top position of the current cursor location.  
  
     [!code[Trin_VstcoreWordAutomation#109](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-pictures-and-word-art-to-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#109](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-pictures-and-word-art-to-documents_2.cs)]  
  
2.  Call the \<xref:Microsoft.Office.Interop.Word.Shapes.AddTextEffect*> method of the \<xref:Microsoft.Office.Interop.Word.Shapes> object in the document.  
  
     [!code[Trin_VstcoreWordAutomation#110](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-pictures-and-word-art-to-documents_3.vb)]
[!code[Trin_VstcoreWordAutomation#110](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-pictures-and-word-art-to-documents_3.cs)]  
  
#### To add WordArt at the cursor location in a VSTO Add-in  
  
1.  Get the left and top position of the current cursor location.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#109](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-pictures-and-word-art-to-documents_4.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#109](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-pictures-and-word-art-to-documents_4.cs)]  
  
2.  Call the \<xref:Microsoft.Office.Interop.Word.Shapes.AddTextEffect*> method of the \<xref:Microsoft.Office.Interop.Word.Shapes> object of the active document (or a different document that you specify).  
  
     [!code[Trin_VstcoreWordAutomationAddIn#110](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-pictures-and-word-art-to-documents_5.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#110](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-pictures-and-word-art-to-documents_5.cs)]  
  
## Compiling the Code  
  
-   A picture named **SamplePicture.jpg** must exist on drive C.  
  
## See Also  
 [How to: Programmatically Open Existing Documents](../VS_officedev/how-to--programmatically-open-existing-documents.md)   
 [How to: Programmatically Insert Text into Word Documents](../VS_officedev/how-to--programmatically-insert-text-into-word-documents.md)   
 [How to: Programmatically Restore Selections After Searches](../VS_officedev/how-to--programmatically-restore-selections-after-searches.md)   
 [How to: Programmatically Save Documents](../VS_officedev/how-to--programmatically-save-documents.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  