---
title: "ActiveX Control Containers: Using Controls in a Non-Dialog Container"
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
  - "Create method [C++], ActiveX controls"
  - "CreateControl method"
  - "ActiveX controls [C++], creating"
  - "ActiveX control containers [C++], non-dialog containers"
  - "ActiveX control containers [C++], inserting controls"
ms.assetid: 46f195b0-b8ca-4409-8cca-fbfaf2c9ab9f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ActiveX Control Containers: Using Controls in a Non-Dialog Container
In some applications, such as an SDI or MDI application, you will want to embed a control in a window of the application. The **Create** member function of the wrapper class, inserted by Visual C++, can create an instance of the control dynamically, without the need for a dialog box.  
  
 The **Create** member function has the following parameters:  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 A pointer to the text to be displayed in the control's Text or Caption property (if any).  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Windows styles. For a complete list, see [CWnd::CreateControl](../vs140/cwnd--createcontrol.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the control's size and position.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the control's parent window, usually a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the control ID and can be used by the container to refer to the control.  
  
 One example of using this function to dynamically create an ActiveX control would be in a form view of an SDI application. You could then create an instance of the control in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> handler of the application.  
  
 For this example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the main view class, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the wrapper class, and CIRC.H is the header (.H) file of the wrapper class.  
  
 Implementing this feature is a four-step process.  
  
### To dynamically create an ActiveX control in a non-dialog window  
  
1.  Insert CIRC.H in CMYVIEW.H, just before the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class definition:  
  
     [!code[NVC_MFC_AxCont#12](../vs140/codesnippet/CPP/activex-control-containers--using-controls-in-a-non-dialog-container_1.h)]  
  
2.  Add a member variable (of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to the protected section of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class definition located in CMYVIEW.H:  
  
     [!code[NVC_MFC_AxCont#13](../vs140/codesnippet/CPP/activex-control-containers--using-controls-in-a-non-dialog-container_2.h)]  
    [!code[NVC_MFC_AxCont#14](../vs140/codesnippet/CPP/activex-control-containers--using-controls-in-a-non-dialog-container_3.h)]  
  
3.  Add a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> message handler to class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
4.  In the handler function, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, make a call to the control's <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function using the **this** pointer as the parent window:  
  
     [!code[NVC_MFC_AxCont#15](../vs140/codesnippet/CPP/activex-control-containers--using-controls-in-a-non-dialog-container_4.cpp)]  
  
5.  Rebuild the project. A Circ control will be created dynamically whenever the application's view is created.  
  
## See Also  
 [ActiveX Control Containers](../vs140/activex-control-containers.md)