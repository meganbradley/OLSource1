---
title: "How to: Create a Collection Used by a Collection Initializer (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - collection initializers [Visual Basic]
ms.assetid: c858db10-424d-47e0-92cd-e08087cc5ebc
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Create a Collection Used by a Collection Initializer (Visual Basic)
When you use a collection initializer to create a collection, the Visual Basic compiler searches for an `Add` method of the collection type for which the parameters for the `Add` method match the types of the values in the collection initializer. This `Add` method is used to populate the collection with the values from the collection initializer.  
  
## Example  
 The following example shows an `OrderCollection` collection that contains a public `Add` method that a collection initializer can use to add objects of type `Order`. The `Add` method enables you to use the shortened collection initializer syntax.  
  
 [!code[VbVbalrCollectionInitializersHowTo2#4](../vs140/codesnippet/VisualBasic/how-to--create-a-collection-used-by-a-collection-initializer--visual-basic-_1.vb)]
  
  
 [!code[VbVbalrCollectionInitializersHowTo2#1](../vs140/codesnippet/VisualBasic/how-to--create-a-collection-used-by-a-collection-initializer--visual-basic-_2.vb)]
  
  
 [!code[VbVbalrCollectionInitializersHowTo2#2](../vs140/codesnippet/VisualBasic/how-to--create-a-collection-used-by-a-collection-initializer--visual-basic-_3.vb)]
  
  
 [!code[VbVbalrCollectionInitializersHowTo2#3](../vs140/codesnippet/VisualBasic/how-to--create-a-collection-used-by-a-collection-initializer--visual-basic-_4.vb)]
  
  
## See Also  
 [Collection Initializers Overview (Visual Basic)](../vs140/collection-initializers--visual-basic-.md)   
 [How to: Create an Add Extension Method Used by a Collection Initializer](../vs140/how-to--create-an-add-extension-method-used-by-a-collection-initializer--visual-basic-.md)