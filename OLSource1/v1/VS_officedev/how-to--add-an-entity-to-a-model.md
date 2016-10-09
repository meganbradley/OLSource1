---
title: "How to: Add an Entity to a Model"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "EntityTool"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "BDC [SharePoint development in Visual Studio], entity"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], adding an entity"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], entity"
  - "BDC [SharePoint development in Visual Studio], adding an entity"
ms.assetid: 139a6639-dabe-4e14-bb64-e5f4efb6f2fb
caps.latest.revision: 23
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
# How to: Add an Entity to a Model
  To create an entity, add an entity control from the Visual Studio **Toolbox** onto the Business Data Connectivity (BDC) designer.  
  
### To add an entity to the model  
  
1.  Create a BDC project, or open an existing BDC project. For more information, see [Creating a Business Data Connectivity Model](../VS_officedev/creating-a-business-data-connectivity-model.md).  
  
2.  In the **Toolbox**, from the **BusinessDataCatalog** group, add an **Entity** control onto the designer.  
  
     The new entity appears on the designer. Visual Studio adds an `<Entity>` element to the XML of the BDC model file in your project. For more information about the attributes of an Entity element, see [Entity](http://go.microsoft.com/fwlink/?LinkId=169296).  
  
3.  On the designer, open the shortcut menu for the entity, choose **Add**, and then choose **Identifier**.  
  
     A new identifier appears on the entity.  
  
    > [!NOTE]  
    >  You can change the name of the entity and the identifier in the **Properties** window.  
  
4.  Define the fields of the entity in a class. You can either add a new class to the project or use an existing class created by using other tools such as the Object Relational Designer (O/R Designer). The following example shows an entity class named Contact.  
  
     [!code[SP_BDC_Entity_Data_Class#1](../VS_officedev/codesnippet/CSharp/how-to--add-an-entity-to-a-model_1.cs)]
[!code[SP_BDC_Entity_Data_Class#1](../VS_officedev/codesnippet/VisualBasic/how-to--add-an-entity-to-a-model_1.vb)]  
  
## See Also  
 [How to: Add a Creator Method](../VS_officedev/how-to--add-a-creator-method.md)   
 [How to: Add a Deleter Method](../VS_officedev/how-to--add-a-deleter-method.md)   
 [How to: Add an Updater Method](../VS_officedev/how-to--add-an-updater-method.md)   
 [How to: Add a Finder Method](../VS_officedev/how-to--add-a-finder-method.md)   
 [How to: Add a Specific Finder Method](../VS_officedev/how-to--add-a-specific-finder-method.md)  
  
  