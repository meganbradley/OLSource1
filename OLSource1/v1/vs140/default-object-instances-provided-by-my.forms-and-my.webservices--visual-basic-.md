---
title: "Default Object Instances Provided by My.Forms and My.WebServices (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Default Object Instances Provided by My.Forms and My.WebServices (Visual Basic)
The [My.Forms](../vs140/my.forms-object.md) and [My.WebServices](../vs140/my.webservices-object.md) objects provide access to forms, data sources, and XML Web services used by your application. They do this by providing collections of *default instances* of each of these objects.  
  
## Default Instances  
 A default instance is an instance of the class that is provided by the runtime and does not need to be declared and instantiated using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statements. The following example demonstrates how you might have declared and instantiated an instance of a \<xref:System.Windows.Forms.Form*> class called <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and how you are now able to get a default instance of this \<xref:System.Windows.Forms.Form*> class through <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [!code[VbVbcnMy#5](../vs140/codesnippet/VisualBasic/default-object-instances-provided-by-my.forms-and-my.webservices--visual-basic-_1.vb)]  
  
 [!code[VbVbcnMy#6](../vs140/codesnippet/VisualBasic/default-object-instances-provided-by-my.forms-and-my.webservices--visual-basic-_2.vb)]  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object returns a collection of default instances for every <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class that exists in your project. Similarly, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> provides a default instance of the proxy class for every Web service that you have created a reference to in your application.  
  
## See Also  
 [My.Forms Object](../vs140/my.forms-object.md)   
 [My.WebServices Object](../vs140/my.webservices-object.md)   
 [How My Depends on Project Type](../vs140/how-my-depends-on-project-type--visual-basic-.md)