---
title: "How to: Visualize a Collection Association (Class Designer)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.classdesigner.collectionassociationline"
  - "vs.classdesigner.ShowAssociationException"
helpviewer_keywords: 
  - "collection associations"
  - "collections, collection associations"
  - "Class Designer [Visual Studio], collection associations"
ms.assetid: 54e39838-2fc9-4dc2-85b6-7e88a743108e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Visualize a Collection Association (Class Designer)
Properties and fields that are collections of other types can be displayed on the class diagram as a collection association. Unlike a regular association, which displays a field or property as a line linking the owning class to the field's type, a collection association is displayed as a line linking the owning class to the collected type.  
  
### To create a collection association  
  
1.  In code, create a property or field whose type is itself a strongly-typed collection.  
  
2.  In the class diagram, expand the class so that properties and fields are shown.  
  
3.  In the class, right-click the field or property and choose **Show as Collection Association**.  
  
     The property or field is shown as an association line linking to the collected type.  
  
## See Also  
 [How to: Define Associations Between Types](../VS_csharp/how-to--create-associations-between-types--class-designer-.md)   
 [Designing Classes and Types](../VS_csharp/designing-classes-and-types--class-designer-.md)   
 [Viewing Types and Relationships on Class Diagrams](../VS_csharp/viewing-types-and-relationships--class-designer-.md)