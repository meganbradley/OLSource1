---
title: "Controlling Color, Line Style, and other Shape Properties"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c06d0066-24aa-4c65-b91c-c2089b81ec8d
caps.latest.revision: 6
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Controlling Color, Line Style, and other Shape Properties
Some shape properties such as color can be 'exposed’ – that is, linked to a domain property of the shape. Others have to be controlled directly.  
  
## Exposing a property  
 Some shape properties such as color can be linked to the value of a domain property.  
  
 In the DSL Definition, select a shape, connector or diagram class. On its context menu, choose **Add Exposed**, and then choose the property you want, such as Fill Color.  
  
 The shape now has a domain property that you can set in program code or as a user.  
  
## Dynamically updating an exposed property  
 Typically you want to make the exposed property dependent on another property. For example, you might want a shape to turn red whenever a particular domain property is less than zero. To make this dependency, create a [rule](../vs140/rules-propagate-changes-within-the-model.md). For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>