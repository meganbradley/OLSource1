---
title: "Containers: Implementing a Container"
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
  - "applications [OLE], OLE container"
  - "OLE containers, implementing"
ms.assetid: af1e2079-619a-4eac-9327-985ad875823a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Containers: Implementing a Container
This article summarizes the procedure for implementing a container and points you to other articles that provide more detailed explanations about implementing containers. It also lists some optional OLE features you may want to implement and the articles describing these features.  
  
#### To prepare your CWinApp-derived class  
  
1.  Initialize the OLE libraries by calling **AfxOleInit** in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function.  
  
2.  Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to assign the menu and accelerator resources used when an embedded item is activated in-place. For more information on this topic, see [Activation](../vs140/activation--c---.md).  
  
 These features are provided for you automatically when you use the MFC Application Wizard to create a container application. See [Creating an MFC EXE Program](../vs140/mfc-application-wizard.md).  
  
#### To prepare your view class  
  
1.  Keep track of selected items by maintaining a pointer, or list of pointers if you support multiple selection, to the selected items. Your <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function must draw all OLE items.  
  
2.  Override <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to check whether the item passed to it is currently selected.  
  
3.  Implement an **OnInsertObject** message handler to display the **Insert Object** dialog box.  
  
4.  Implement an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message handler to transfer focus from the view to an in-place active OLE embedded item.  
  
5.  Implement an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message handler to inform an OLE embedded item that it needs to change its rectangle to reflect the change in size of its containing view.  
  
 Because the implementation of these features varies dramatically from one application to the next, the application wizard provides only a basic implementation. You will likely have to customize these functions to get your application to function properly. For an example of this, see the [CONTAINER](../vs140/visual-c---samples.md) sample.  
  
#### To handle embedded and linked items  
  
1.  Derive a class from [COleClientItem](../vs140/coleclientitem-class.md). Objects of this class represent items that have been embedded in or linked to your OLE document.  
  
2.  Override **OnChange**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. These functions handle sizing, positioning, and modifying embedded and linked items.  
  
 The application wizard will derive the class for you, but you will likely need to override **OnChange** and the other functions listed with it in step 2 in the preceding procedure. The skeleton implementations need to be customized for most applications, because these functions are implemented differently from one application to the next. For examples of this, see the MFC samples [DRAWCLI](../vs140/visual-c---samples.md) and [CONTAINER](../vs140/visual-c---samples.md).  
  
 You must add a number of items to the container application's menu structure to support OLE. For more information on these, see [Menus and Resources: Container Additions](../vs140/menus-and-resources--container-additions.md).  
  
 You may also want to support some of the following features in your container application:  
  
-   In-place activation when editing an embedded item.  
  
     For more information, see [Activation](../vs140/activation--c---.md).  
  
-   Creation of OLE items by dragging and dropping a selection from a server application.  
  
     For more information, see [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md).  
  
-   Links to embedded objects or combination container/server applications.  
  
     For more information, see [Containers: Advanced Features](../vs140/containers--advanced-features.md).  
  
## See Also  
 [Containers](../vs140/containers.md)   
 [Containers: Client Items](../vs140/containers--client-items.md)