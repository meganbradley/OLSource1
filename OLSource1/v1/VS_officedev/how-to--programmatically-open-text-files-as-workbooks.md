---
title: "How to: Programmatically Open Text Files as Workbooks"
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
  - "workbooks, opening text files as"
  - "text [Office development in Visual Studio], text files"
  - "text files, opening as workbooks"
ms.assetid: 056ae3d0-7fe7-4c28-a2a5-5a948baee0e6
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
# How to: Programmatically Open Text Files as Workbooks
  You can open a text file as a workbook. You must pass in the name of the text file you want to open. You can specify several optional parameters, such as which row number to start parsing on and the column format of the data in the file.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
## Example  
 [!code[Trin_VstcoreExcelAutomation#80](../VS_officedev/codesnippet/CSharp/how-to--programmatically-open-text-files-as-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#80](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-open-text-files-as-workbooks_1.vb)]  
  
## Compiling the Code  
 This example requires the following components:  
  
-   A comma-delimited text file named `Test.txt` that contains at least three lines of text.  
  
-   The text file `Test.txt` to be stored on drive C.  
  
## See Also  
 [Working with Workbooks](../VS_officedev/working-with-workbooks.md)   
 [How to: Programmatically Open Workbooks](../VS_officedev/how-to--programmatically-open-workbooks.md)   
 [How to: Programmatically Create New Workbooks](../VS_officedev/how-to--programmatically-create-new-workbooks.md)   
 [How to: Programmatically Save Workbooks](../VS_officedev/how-to--programmatically-save-workbooks.md)   
 [How to: Programmatically Close Workbooks](../VS_officedev/how-to--programmatically-close-workbooks.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)  
  
  