---
title: "Default Object Instances Provided by My.Forms and My.WebServices (Visual Basic)"
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
  - "My.WebServices object, developing applications"
  - "My.Forms object, developing applications"
  - "rapid application development (RAD), My.Forms"
  - "rapid application development (RAD), My.WebServices"
ms.assetid: de930027-9108-4f0c-b97c-5e7db4d6ef79
caps.latest.revision: 5
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
# Default Object Instances Provided by My.Forms and My.WebServices (Visual Basic)
The [My.Forms](../VS_visualbasic/my.forms-object.md) and [My.WebServices](../VS_visualbasic/my.webservices-object.md) objects provide access to forms, data sources, and XML Web services used by your application. They do this by providing collections of *default instances* of each of these objects.  
  
## Default Instances  
 A default instance is an instance of the class that is provided by the runtime and does not need to be declared and instantiated using the `Dim` and `New` statements. The following example demonstrates how you might have declared and instantiated an instance of a \<xref:System.Windows.Forms.Form> class called `Form1`, and how you are now able to get a default instance of this \<xref:System.Windows.Forms.Form> class through `My.Forms`.  
  
 [!code[VbVbcnMy#5](../VS_visualbasic/codesnippet/VisualBasic/default-object-instances-provided-by-my.forms-and-my.webservices--visual-basic-_1.vb)]  
  
 [!code[VbVbcnMy#6](../VS_visualbasic/codesnippet/VisualBasic/default-object-instances-provided-by-my.forms-and-my.webservices--visual-basic-_2.vb)]  
  
 The `My.Forms` object returns a collection of default instances for every `Form` class that exists in your project. Similarly, `My.WebServices` provides a default instance of the proxy class for every Web service that you have created a reference to in your application.  
  
## See Also  
 [My.Forms Object](../VS_visualbasic/my.forms-object.md)   
 [My.WebServices Object](../VS_visualbasic/my.webservices-object.md)   
 [How My Depends on Project Type](../VS_visualbasic/how-my-depends-on-project-type--visual-basic-.md)