---
title: "How to: Create an Add Extension Method Used by a Collection Initializer (Visual Basic)"
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
ms.assetid: f64b52c7-8b11-4410-93a6-cb3aeebcc772
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Create an Add Extension Method Used by a Collection Initializer (Visual Basic)
When you use a collection initializer to create a collection, the Visual Basic compiler searches for an `Add` method of the collection type for which the parameters for the `Add` method match the types of the values in the collection initializer. This `Add` method is used to populate the collection with the values from the collection initializer.  
  
 If no matching `Add` method exists and you cannot modify the code for the collection, you can add an extension method called `Add` that takes the parameters that are required by the collection initializer. This is typically what you need to do when you use collection initializers for generic collections.  
  
## Example  
 The following example shows how to add an extension method to the generic <xref:System.Collections.Generic.List`1?qualifyHint=False> type so that a collection initializer can be used to add objects of type `Employee`. The extension method enables you to use the shortened collection initializer syntax.  
  
 [!code[VbVbalrCollectionInitializersHowTo1#1](../vs140/codesnippet/VisualBasic/how-to--create-an-add-extension-method-used-by-a-collection-initializer--visual-basic-_1.vb)]
  
  
 [!code[VbVbalrCollectionInitializersHowTo1#2](../vs140/codesnippet/VisualBasic/how-to--create-an-add-extension-method-used-by-a-collection-initializer--visual-basic-_2.vb)]
  
  
 [!code[VbVbalrCollectionInitializersHowTo1#3](../vs140/codesnippet/VisualBasic/how-to--create-an-add-extension-method-used-by-a-collection-initializer--visual-basic-_3.vb)]
  
  
## See Also  
 [Collection Initializers Overview (Visual Basic)](../vs140/collection-initializers--visual-basic-.md)   
 [How to: Create a Collection Used by a Collection Initializer](../vs140/how-to--create-a-collection-used-by-a-collection-initializer--visual-basic-.md)