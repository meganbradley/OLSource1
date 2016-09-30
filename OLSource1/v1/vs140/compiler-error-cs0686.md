---
title: "Compiler Error CS0686"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0686"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0686"
ms.assetid: 821ea0c9-87d8-4902-8f0b-dcad72312132
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0686
Accessor 'accessor' cannot implement interface member 'member' for type 'type'. Use an explicit interface implementation.  
  
 Suggested: This error can occur when implementing an interface that contains method names which conflict with the auto-generated methods associated with a property or event. The get/set methods for properties are generated as get_property and set_property, and the add/remove methods for events are generated as add_event and remove_event. If an interface contains either of these methods, a conflict occurs. To avoid this error, implement the methods using an explicit interface implementation. To do this, specify the function as:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS0686:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This error can also occur when declaring events.  The event construct automatically generates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> methods, which could conflict with the methods of the same name in an interface, as in the following sample:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>