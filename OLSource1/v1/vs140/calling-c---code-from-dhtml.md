---
title: "Calling C++ Code from DHTML"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DHTML, calling C++ code from"
ms.assetid: 37329acd-4c22-40ca-a85a-b7480748f75f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Calling C++ Code from DHTML
A DHTML control can be hosted in a container, such as Test Container or Internet Explorer. See [Testing Properties and Events with Test Container](../vs140/testing-properties-and-events-with-test-container.md) for information on how to access Test Container.  
  
 The container hosting the control communicates with the control using the normal control interfaces. DHTML uses the dispatch interface that ends with "UI" to communicate with your C++ code and your HTML resource. In [Modifying the ATL DHTML Control](../vs140/modifying-the-atl-dhtml-control.md), you can practice adding the methods to be called by these different interfaces.  
  
 To see an example of calling C++ code from DHTML, [create a DHTML control](../vs140/creating-an-atl-dhtml-control.md) using the ATL Control Wizard and examine the code in the header file and in the HTML file.  
  
## Declaring WebBrowser Methods in the Header File  
 To invoke C++ methods from the DHTML UI, you must add methods to your control's UI interface. For example, the header file created by the ATL Control Wizard contains the C++ method <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, which is a member of the UI interface of the wizard-generated control.  
  
 Examine <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the control's .h file:  
  
 [!code[NVC_ATL_COM#4](../vs140/codesnippet/CPP/calling-c---code-from-dhtml_1.h)]  
  
 The first parameter, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, is a pointer to the body object's dispatch interface. The second parameter, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, identifies the color to apply to the control.  
  
## Calling C++ Code in the HTML File  
 Once you have declared the WebBrowser methods in the header file, you can invoke the methods from the HTML file. Notice in the HTML file that the ATL Control Wizard inserts three Windows dispatch methods: three <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> methods that dispatch messages to change the background color of the control.  
  
 Examine one of the methods in the HTML file:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 In the HTML code above, the window external method, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, is called as part of the button tag. The method has two parameters: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which references the body of the HTML document, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which indicates that the control's background color will be changed to red when the button is clicked. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> following the tag is the button's label.  
  
 See [Modifying the ATL DHTML Control](../vs140/modifying-the-atl-dhtml-control.md) for more information about providing your own methods. See [Identifying the Elements of the DHTML Control Project](../vs140/identifying-the-elements-of-the-dhtml-control-project.md) for more information about the HTML file.  
  
## See Also  
 [Support for DHTML Control](../vs140/atl-support-for-dhtml-controls.md)