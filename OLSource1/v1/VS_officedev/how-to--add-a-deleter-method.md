---
title: "How to: Add a Deleter Method"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "BDC [SharePoint development in Visual Studio], deleting data"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Deleter"
  - "BDC [SharePoint development in Visual Studio], Deleter"
  - "BDC [SharePoint development in Visual Studio], removing data"
  - "BDC [SharePoint development in Visual Studio], deleting entity instances"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], deleting entity instances"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], deleting data"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], removing data"
ms.assetid: 3362eaf4-5dc7-4450-9009-b296308ae61f
caps.latest.revision: 21
ms.author: "kempb"
manager: "douge"
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
# How to: Add a Deleter Method
  You can enable an end user to delete a data record from an external list on a SharePoint site by adding a *Deleter* method to the model. For more information, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
### To create a Deleter method  
  
1.  On the BDC designer, choose an entity.  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information about this window, see [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md).  
  
3.  In the **Add a Method** list, choose **Create a Deleter Method**.  
  
     Visual Studio adds the following elements to the model. These elements appear in the **BDC Method Details** window.  
  
    -   A method named **Delete**.  
  
    -   An input parameter for the method.  
  
    -   A type descriptor for the parameter.  
  
    -   A method instance for the method.  
  
     For more information, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
4.  In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.  
  
     The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Creating a Business Data Connectivity Model](../VS_officedev/creating-a-business-data-connectivity-model.md).  
  
5.  Add code to the Deleter method to delete a record. The following example deletes a line item from a sales order by using the AdventureWorks sample database for SQL Server.  
  
    > [!NOTE]  
    >  The method in this example uses two input parameters.  
  
    > [!NOTE]  
    >  Replace the value of the `ServerName` field with the name of your server.  
  
     [!code[SP_BDC#6](../VS_officedev/codesnippet/CSharp/how-to--add-a-deleter-method_1.cs)]
[!code[SP_BDC#6](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-deleter-method_1.vb)]  
  
## See Also  
 [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Finder Method](../VS_officedev/how-to--add-a-finder-method.md)   
 [How to: Add a Specific Finder Method](../VS_officedev/how-to--add-a-specific-finder-method.md)   
 [How to: Add a Creator Method](../VS_officedev/how-to--add-a-creator-method.md)   
 [How to: Add an Updater Method](../VS_officedev/how-to--add-an-updater-method.md)   
 [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md)   
 [How to: Add a Parameter to a Method](../VS_officedev/how-to--add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../VS_officedev/how-to--define-a-method-instance.md)  
  
  