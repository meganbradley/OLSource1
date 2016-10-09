---
title: "Troubleshooting Inherited Event Handlers in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "troubleshooting events"
  - "inherited events"
  - "troubleshooting Visual Basic, event handlers"
  - "event handling, troubleshooting"
  - "event handlers, troubleshooting"
ms.assetid: e1c8759f-5370-4308-8476-8c48b73509bf
caps.latest.revision: 11
ms.author: "shoag"
manager: "wpickett"
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
# Troubleshooting Inherited Event Handlers in Visual Basic
This topic lists common issues that arise with event handlers in inherited components.  
  
## Procedures  
  
#### Code in Event Handler Executes Twice for Every Call  
  
-   An inherited event handler must not include a [Handles](../VS_visualbasic/handles-clause--visual-basic-.md) clause. The method in the base class is already associated with the event and will fire accordingly. Remove the `Handles` clause from the inherited method.  
  
     [!code[VbVbalrEvents#32](../VS_visualbasic/codesnippet/VisualBasic/troubleshooting-inherited-event-handlers-in-visual-basic_1.vb)]  
  
-   If the inherited method does not have a `Handles` keyword, verify that your code does not contain an extra [AddHandler Statement](../VS_visualbasic/addhandler-statement.md) or any additional methods that handle the same event.  
  
## See Also  
 [Events](../VS_visualbasic/events--visual-basic-.md)