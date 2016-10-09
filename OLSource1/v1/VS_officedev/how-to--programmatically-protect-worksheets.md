---
title: "How to: Programmatically Protect Worksheets"
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
  - "protection, adding to worksheets"
  - "documents [Office development in Visual Studio], document protection"
  - "document protection, adding to worksheets"
  - "worksheets, protecting"
ms.assetid: 50bde1ff-918a-42ca-ba1b-f22139f8717a
caps.latest.revision: 47
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
# How to: Programmatically Protect Worksheets
  The protection feature in Microsoft Office Excel helps prevent users and code from modifying objects in a worksheet. By default, all cells are locked after you turn on protection.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 In document-level customizations, you can protect worksheets by using the Excel designer. You can also protect a worksheet programmatically at run time in any project type.  
  
> [!NOTE]  
>  You cannot add Windows Forms controls to areas of a worksheet that are protected.  
  
## Using the Designer  
  
#### To protect a worksheet in the designer  
  
1.  In the **Changes** group of the **Review** tab, click **Protect Sheet**.  
  
     The **Protect Sheet** dialog box appears. You can set a password and optionally specify certain actions that users are allowed to perform with the worksheet, such as format cells or insert rows.  
  
 You can also allow users to edit specific ranges in protected worksheets.  
  
#### To allow editing in specific ranges  
  
1.  In the **Changes** group of the **Review** tab, click **Allow Users to Edit Ranges**.  
  
     The **Allow Users to Edit Ranges** dialog box appears. You can specify ranges that are unlocked using a password, and users who can edit ranges without a password.  
  
## Using Code at Run Time  
 The following code sets the password (using the variable getPasswordFromUser, which contains a password obtained from the user) and allows only sorting.  
  
#### To protect a worksheet by using code in a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Protect*> method of the worksheet. This example assumes that you are working with a worksheet named `Sheet1`.  
  
     [!code[Trin_VstcoreExcelAutomation#27](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#27](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-worksheets_1.vb)]  
  
#### To protect a worksheet by using code in a VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Worksheet.Protect*> method of the active worksheet.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#17](../VS_officedev/codesnippet/CSharp/how-to--programmatically-protect-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#17](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-protect-worksheets_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Remove Protection from Worksheets](../VS_officedev/how-to--programmatically-remove-protection-from-worksheets.md)   
 [How to: Programmatically Protect Workbooks](../VS_officedev/how-to--programmatically-protect-workbooks.md)   
 [How to: Programmatically Hide Worksheets](../VS_officedev/how-to--programmatically-hide-worksheets.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Worksheet Host Item](../VS_officedev/worksheet-host-item.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  