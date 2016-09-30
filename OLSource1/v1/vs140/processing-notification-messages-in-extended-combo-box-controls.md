---
title: "Processing Notification Messages in Extended Combo Box Controls"
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
  - "extended combo boxes, notifications"
  - "notifications, extended combo box controls"
ms.assetid: 4e442758-d054-4746-bb1a-6ff84accb127
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Processing Notification Messages in Extended Combo Box Controls
As users interact with the extended combo box, the control (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) sends notification messages to its parent window, usually a view or dialog object. Handle these messages if you want to do something in response. For example, when the user activates the drop-down list or clicks in the control's edit box, the **CBEN_BEGINEDIT** notification is sent.  
  
 Use the Properties window to add notification handlers to the parent class for those messages you want to implement.  
  
 The following list describes the various notifications sent by the extended combo box control.  
  
-   **CBEN_BEGINEDIT** Sent when the user activates the drop-down list or clicks in the control's edit box.  
  
-   **CBEN_DELETEITEM** Sent when an item has been deleted.  
  
-   **CBEN_DRAGBEGIN** Sent when the user begins dragging the image of the item displayed in the edit portion of the control.  
  
-   **CBEN_ENDEDIT** Sent when the user has concluded an operation within the edit box or has selected an item from the control's drop-down list.  
  
-   **CBEN_GETDISPINFO** Sent to retrieve display information about a callback item.  
  
-   **CBEN_INSERTITEM** Sent when a new item has been inserted in the control.  
  
## See Also  
 [Using CComboBoxEx](../vs140/using-ccomboboxex.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)