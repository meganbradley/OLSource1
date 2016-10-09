---
title: "How to: Add a Finder Method"
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
  - "BDC [SharePoint development in Visual Studio], get entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], return entities"
  - "BDC [SharePoint development in Visual Studio], return entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Finder method"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], get entities"
  - "BDC [SharePoint development in Visual Studio], Finder method"
ms.assetid: 5de2cae3-d1f7-4a68-aac0-458967aca692
caps.latest.revision: 25
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
# How to: Add a Finder Method
  To enable the Business Data Connectivity service to display a list of entities in a web part or list, you must create a *Finder* method. A Finder method is a special method that returns a collection of entity instances. For more information, see [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md).  
  
### To create a Finder method  
  
1.  On the BDC designer, choose an entity.  
  
     For more information, see [How to: Add an Entity to a Model](../VS_officedev/how-to--add-an-entity-to-a-model.md).  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information about the **BDC Method Details** window, see [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md).  
  
3.  In the **Add a Method** list, choose **Create Finder Method**.  
  
     Visual Studio adds a method, a return parameter, and a type descriptor.  
  
4.  Configure the type descriptor as an entity collection type descriptor. For more information about how to create an entity collection type descriptor, see [How to: Define the Type Descriptor of a Parameter](../VS_officedev/how-to--define-the-type-descriptor-of-a-parameter.md).  
  
    > [!NOTE]  
    >  You do not have to perform this step if you have added a Specific Finder method to the entity. Visual Studio uses the type descriptor that you defined in the Specific Finder method.  
  
5.  In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**. For more information about the service code file, see [Creating a Business Data Connectivity Model](../VS_officedev/creating-a-business-data-connectivity-model.md).  
  
6.  Add code to the Finder method. This code performs the following tasks:  
  
    -   Retrieves data from a data source.  
  
    -   Returns a list of entities to the BDC service.  
  
     The following example returns a collection of `Contact` entities by using data from the AdventureWorks sample database for SQL Server.  
  
    > [!NOTE]  
    >  Replace the value of the `ServerName` field with the name of your server.  
  
     [!code[SP_BDC#2](../VS_officedev/codesnippet/CSharp/how-to--add-a-finder-method_1.cs)]
[!code[SP_BDC#2](../VS_officedev/codesnippet/VisualBasic/how-to--add-a-finder-method_1.vb)]  
  
## See Also  
 [BDC Model Design Tools Overview](../VS_officedev/bdc-model-design-tools-overview.md)   
 [Designing a Business Data Connectivity Model](../VS_officedev/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Specific Finder Method](../VS_officedev/how-to--add-a-specific-finder-method.md)   
 [How to: Add a Creator Method](../VS_officedev/how-to--add-a-creator-method.md)   
 [How to: Add a Deleter Method](../VS_officedev/how-to--add-a-deleter-method.md)   
 [How to: Add an Updater Method](../VS_officedev/how-to--add-an-updater-method.md)   
 [How to: Add a Parameter to a Method](../VS_officedev/how-to--add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../VS_officedev/how-to--define-a-method-instance.md)  
  
  