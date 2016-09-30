---
title: "Containers: Client-Item Notifications"
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
  - "notifications, container client item"
  - "OLE containers, client-item notifications"
  - "client items and OLE containers"
ms.assetid: e1f1c427-01f5-45f2-b496-c5bce3d76340
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Containers: Client-Item Notifications
This article discusses the overridable functions that the MFC framework calls when server applications modify items in your client application's document.  
  
 [COleClientItem](../vs140/coleclientitem-class.md) defines several overridable functions that are called in response to requests from the component application, which is also called the server application. These overridables usually act as notifications. They inform the container application of various events, such as scrolling, activation, or a change of position, and of changes that the user makes when editing or otherwise manipulating the item.  
  
 The framework notifies your container application of changes through a call to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, an overridable function whose implementation is required. This protected function receives two arguments. The first specifies the reason the server changed the item:  
  
|Notification|Meaning|  
|------------------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The OLE item's appearance has changed.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The OLE item has been saved.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The OLE item has been closed.|  
|**OLE_RENAMED**|The server document containing the OLE item has been renamed.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The OLE item has changed from one state to another.|  
|**OLE_CHANGED_ASPECT**|The OLE item's draw aspect has been changed by the framework.|  
  
 These values are from the **OLE_NOTIFICATION** enumeration, which is defined in AFXOLE.H.  
  
 The second argument to this function specifies how the item has changed or what state it has entered:  
  
|When first argument is|Second argument|  
|----------------------------|---------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Is not used.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Specifies the aspect of the OLE item that has changed.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Describes the state being entered (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, **loadedState**, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).|  
  
 For more information about the states a client item can assume, see [Containers: Client-Item States](../vs140/containers--client-item-states.md).  
  
 The framework calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> when an item is being activated for in-place editing. Implementation is required for applications that support in-place editing. The MFC Application Wizard provides a basic implementation, which assigns the item's coordinates to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object that is passed as an argument to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 If an OLE item's position or size changes during in-place editing, the container's information about the item's position and clipping rectangles must be updated and the server must receive information about the changes. The framework calls <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for this purpose. The MFC Application Wizard provides an override that calls the base class's function. You should edit the function that the application wizard writes for your <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>-derived class so that the function updates any information retained by your client-item object.  
  
## See Also  
 [Containers](../vs140/containers.md)   
 [Containers: Client-Item States](../vs140/containers--client-item-states.md)   
 [COleClientItem::OnChangeItemPosition](../vs140/coleclientitem--onchangeitemposition.md)