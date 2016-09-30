---
title: "OLE Control Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.classes.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX classes [C++]"
  - "custom controls [MFC], classes"
  - "ActiveX controls [C++], OLE control classes"
  - "ActiveX control classes [C++]"
  - "OLE controls [C++], classes"
  - "OLE control classes [C++]"
  - "reusable component classes"
ms.assetid: 96495ec3-319e-4163-b839-1af0428ed9dd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OLE Control Classes
These are the primary classes you use when writing OLE controls. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class in an OLE control module is like the [CWinApp](../vs140/cwinapp-class.md) class in an application. Each module implements one or more OLE controls; these controls are represented by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects. These controls communicate with their containers using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> classes encapsulate COM interfaces for pictures and fonts, while the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> classes help you implement property pages and property persistence for your control.  
  
 [COleControlModule](../vs140/colecontrolmodule-class.md)  
 Replaces the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class for your OLE control module. Derive from the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class to develop an OLE control module object. It provides member functions for initializing your OLE control's module.  
  
 [COleControl](../vs140/colecontrol-class.md)  
 Derive from the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class to develop an OLE control. Derived from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, this class inherits all the functionality of a Windows window object plus additional OLE-specific functionality, such as event firing and the ability to support methods and properties.  
  
 [CConnectionPoint](../vs140/cconnectionpoint-class.md)  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class defines a special type of interface used to communicate with other OLE objects, called a connection point. A connection point implements an outgoing interface that is able to initiate actions on other objects, such as firing events and change notifications.  
  
 [CPictureHolder](../vs140/cpictureholder-class.md)  
 Encapsulates the functionality of a Windows picture object and the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> COM interface; used to implement the custom Picture property of an OLE control.  
  
 [CFontHolder](../vs140/cfontholder-class.md)  
 Encapsulates the functionality of a Windows font object and the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> COM interface; used to implement the stock Font property of an OLE control.  
  
 [COlePropertyPage](../vs140/colepropertypage-class.md)  
 Displays the properties of an OLE control in a graphical interface, similar to a dialog box.  
  
 [CPropExchange](../vs140/cpropexchange-class.md)  
 Supports the implementation of property persistence for your OLE controls. Analogous to [CDataExchange](../vs140/cdataexchange-class.md) for dialog boxes.  
  
 [CMonikerFile](../vs140/cmonikerfile-class.md)  
 Takes a moniker, or a string representation that it can make into a moniker, and binds it synchronously to the stream for which the moniker is a name.  
  
 [CAsyncMonikerFile](../vs140/casyncmonikerfile-class.md)  
 Works similarly to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; however, it binds the moniker asynchronously to the stream for which the moniker is a name.  
  
 [CDataPathProperty](../vs140/cdatapathproperty-class.md)  
 Implements an OLE control property that can be loaded asynchronously.  
  
 [CCachedDataPathProperty](../vs140/ccacheddatapathproperty-class.md)  
 Implements an OLE control property transferred asynchronously and cached in a memory file.  
  
 [COleCmdUI](../vs140/colecmdui-class.md)  
 Allows an Active document to receive commands that originate in its container's user interface (such as FileNew, Open, Print, and so on), and allows a container to receive commands that originate in the Active document's user interface.  
  
 [COleSafeArray](../vs140/colesafearray-class.md)  
 Works with arrays of arbitrary type and dimension.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)