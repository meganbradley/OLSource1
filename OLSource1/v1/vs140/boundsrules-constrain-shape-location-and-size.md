---
title: "BoundsRules Constrain Shape Location and Size"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language, events"
ms.assetid: 4d08e541-fc67-4e68-bf31-30d346aa2aa0
caps.latest.revision: 20
---
# BoundsRules Constrain Shape Location and Size
A *Bounds Rule* is a class that defines limits on the size and location of a shape. It provides a method that is called repeatedly while a user is dragging a shape or the corners or sides of a shape.  
  
 The following example constrains a rectangular shape to be a bar of fixed size, either horizontal or vertical. When the user drags the corners or sides, the outline flips between the two permitted configurations of height and width.  
  
 The bounds rule is a class derived from \<xref:Microsoft.VisualStudio.Modeling.Diagrams.BoundsRules*>. An instance of the rule is created in the shape:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Notice that both the location and size can be constrained if you want.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Modeling.Diagrams.BoundsRules*>   
 [Responding to changes in the model](../vs140/responding-to-and-propagating-changes.md)