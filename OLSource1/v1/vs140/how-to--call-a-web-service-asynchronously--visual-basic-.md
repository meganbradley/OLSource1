---
title: "How to: Call a Web Service Asynchronously (Visual Basic)"
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
  - "asynchronous calls"
  - "Web services, accessing"
ms.assetid: ff8046f4-f1f2-4d8b-90b7-95e3f7415418
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Call a Web Service Asynchronously (Visual Basic)
This example attaches a handler to a Web service's asynchronous handler event, so that it can retrieve the result of an asynchronous method call. This example used the DemoTemperatureService Web service at http://www.xmethods.net.  
  
 When you reference a Web service in your project in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Integrated Development Environment (IDE), it is added to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, and the IDE generates a client proxy class to access a specified Web service  
  
 The proxy class allows you to call the Web service methods synchronously, where your application waits for the function to complete. In addition, the proxy creates additional members to help call the method asynchronously. For each Web service function, *NameOfWebServiceFunction*, the proxy creates a *NameOfWebServiceFunction*<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> subroutine, a *NameOfWebServiceFunction*<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> event, and a *NameOfWebServiceFunction*<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class. This example demonstrates how to use the asynchronous members to access the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function of the DemoTemperatureService Web service.  
  
> [!NOTE]
>  This code does not work in Web applications, because ASP.NET does not support the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
### To call a Web service asynchronously  
  
1.  Reference the DemoTemperatureService Web service at http://www.xmethods.net. The address is  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Add an event handler for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> event:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  You cannot use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement to associate an event handler with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object's events.  
  
3.  Add a field to track if the event handler has been added to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> event:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Add a method to add the event handler to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> event, if necessary, and to call the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     To call the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> Web method asynchronously, call the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method. When the Web method finishes, its return value is passed to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> event handler.  
  
## See Also  
 [Accessing Application Web Services](../vs140/accessing-application-web-services--visual-basic-.md)   
 [My.WebServices Object](../vs140/my.webservices-object.md)