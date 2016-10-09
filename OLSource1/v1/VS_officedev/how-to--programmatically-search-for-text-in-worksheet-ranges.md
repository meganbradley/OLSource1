---
title: "How to: Programmatically Search for Text in Worksheet Ranges"
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
  - "worksheets, searching"
  - "text [Office development in Visual Studio], searching in worksheets"
  - "text searches, worksheets"
ms.assetid: a6902711-fefb-450a-a76b-b1446d11c423
caps.latest.revision: 48
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
# How to: Programmatically Search for Text in Worksheet Ranges
  The \<xref:Microsoft.Office.Interop.Excel.Range.Find*> method of the \<xref:Microsoft.Office.Interop.Excel.Range> object enables you to search for text within the range. This text can also be any of the error strings that can appear in a worksheet cell such as `#NULL!` or `#VALUE!`. For more information about error strings, see [Cell Error Values](HV10038459).  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 The following example searches a range named `Fruits` and modifies the font for cells that contain the word "apples". This procedure also uses the \<xref:Microsoft.Office.Interop.Excel.Range.FindNext*> method, which uses the previously set search settings to repeat the search. You specify the cell after which to search, and the \<xref:Microsoft.Office.Interop.Excel.Range.FindNext*> method handles the rest.  
  
> [!NOTE]  
>  The \<xref:Microsoft.Office.Interop.Excel.Range.FindNext*> method's search wraps back to the beginning of the search range after it has reached the end of the range. Your code must ensure that the search does not wrap around in an infinite loop. The sample procedure shows one way to handle this using the \<xref:Microsoft.Office.Interop.Excel.Range.Address*> property.  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Use the Find Method in an Excel Add-in?](http://go.microsoft.com/fwlink/?LinkID=130294).  
  
### To search for text in a worksheet range  
  
1.  Declare variables for tracking the entire range, the first found range, and the current found range.  
  
     [!code[Trin_VstcoreExcelAutomation#58](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_1.cs)]
[!code[Trin_VstcoreExcelAutomation#58](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_1.vb)]  
  
2.  Search for the first match, specifying all the parameters except the cell to search after.  
  
     [!code[Trin_VstcoreExcelAutomation#59](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_2.cs)]
[!code[Trin_VstcoreExcelAutomation#59](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_2.vb)]  
  
3.  Continue searching as long as there are matches.  
  
     [!code[Trin_VstcoreExcelAutomation#60](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_3.cs)]
[!code[Trin_VstcoreExcelAutomation#60](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_3.vb)]  
  
4.  Compare the first found range (`firstFind`) to **Nothing**. If `firstFind` contains no value, the code stores away the found range (`currentFind`).  
  
     [!code[Trin_VstcoreExcelAutomation#61](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_4.cs)]
[!code[Trin_VstcoreExcelAutomation#61](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_4.vb)]  
  
5.  Exit the loop if the address of the found range matches the address of the first found range.  
  
     [!code[Trin_VstcoreExcelAutomation#62](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_5.cs)]
[!code[Trin_VstcoreExcelAutomation#62](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_5.vb)]  
  
6.  Set the appearance of the found range.  
  
     [!code[Trin_VstcoreExcelAutomation#63](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_6.cs)]
[!code[Trin_VstcoreExcelAutomation#63](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_6.vb)]  
  
7.  Perform another search.  
  
     [!code[Trin_VstcoreExcelAutomation#64](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_7.cs)]
[!code[Trin_VstcoreExcelAutomation#64](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_7.vb)]  
  
 The following example shows the complete method.  
  
## Example  
 [!code[Trin_VstcoreExcelAutomation#57](../VS_officedev/codesnippet/CSharp/how-to--programmatically-search-for-text-in-worksheet-ranges_8.cs)]
[!code[Trin_VstcoreExcelAutomation#57](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-search-for-text-in-worksheet-ranges_8.vb)]  
  
## See Also  
 [Working with Ranges](../VS_officedev/working-with-ranges.md)   
 [How to: Programmatically Apply Styles to Ranges in Workbooks](../VS_officedev/how-to--programmatically-apply-styles-to-ranges-in-workbooks.md)   
 [How to: Programmatically Refer to Worksheet Ranges in Code](../VS_officedev/how-to--programmatically-refer-to-worksheet-ranges-in-code.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  