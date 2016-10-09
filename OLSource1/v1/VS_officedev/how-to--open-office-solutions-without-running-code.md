---
title: "How to: Open Office Solutions without Running Code"
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
  - "Office solutions [Office development in Visual Studio], opening"
  - "opening Office solutions"
  - "bypassing assemblies"
  - "solutions [Office development in Visual Studio], opening"
  - "assemblies [Office development in Visual Studio], bypassing"
  - "Office documents [Office development in Visual Studio, opening without running code"
  - "documents [Office development in Visual Studio], opening without running code"
ms.assetid: a853d91c-9fd6-421a-b3a2-956b6b494b96
caps.latest.revision: 23
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
# How to: Open Office Solutions without Running Code
  A Microsoft Office solution created with managed code extensions runs even if the Security setting in the end user's Office application is set to High. This is because .NET assembly code security is managed by the Microsoft .NET Framework, not by Microsoft Office.  
  
 However, there are times when you might want to open a document without running the code. For example, code that runs when the document opens might alter the contents, but you want to update the way the document looks before the code changes it. Or you might want to send the document with certain information in it to someone, and you do not want the code to run and possibly alter the contents.  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
 There are several ways to open a document or workbook that contains managed code extensions without running the assembly code.  
  
### To bypass the assembly by using the SHIFT key  
  
-   Open documents and workbooks from the **File** menu while holding down the SHIFT key to prevent Word and Excel from raising initialization events while the document is opening.  
  
    > [!NOTE]  
    >  If you open a document or workbook from the **Getting Started** task pane, holding down SHIFT does not bypass the code. Also, holding down SHIFT does not prevent events from being raised after the document is open.  
  
     This method is useful if you want to open a document to make changes without the code running and altering the document first.  
  
### To bypass an assembly by renaming or removing it  
  
-   If you have the necessary permissions on the computer where the assembly is located, you can rename or remove the assembly so the document or workbook cannot find it. This results in an error being raised every time the Office document is opened.  
  
     If the solution is used by multiple people, this method prevents the solution from running for all of them. This can be useful if a problem is found in the code or a referenced server and you want to stop all users from executing it.  
  
## See Also  
 [Securing Office Solutions](../VS_officedev/securing-office-solutions.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [Application and Deployment Manifests in Office Solutions](../VS_officedev/application-and-deployment-manifests-in-office-solutions.md)  
  
  