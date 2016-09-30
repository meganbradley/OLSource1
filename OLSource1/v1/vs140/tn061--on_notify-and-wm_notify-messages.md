---
title: "TN061: ON_NOTIFY and WM_NOTIFY Messages"
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
  - "ON_NOTIFY"
  - "WM_NOTIFY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_NOTIFY_EX message"
  - "TN061"
  - "ON_NOTIFY message"
  - "ON_NOTIFY_EX_RANGE message"
  - "ON_NOTIFY_RANGE message"
  - "notification messages"
  - "WM_NOTIFY message"
ms.assetid: 04a96dde-7049-41df-9954-ad7bb5587caf
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN061: ON_NOTIFY and WM_NOTIFY Messages
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This technical note provides background information on the new **WM_NOTIFY** message and describes the recommended (and most common) way of handling **WM_NOTIFY** messages in your MFC application.  
  
 **Notification Messages in Windows 3.x**  
  
 In Windows 3.x, controls notify their parents of events such as mouse clicks, changes in content and selection, and control background painting by sending a message to the parent. Simple notifications are sent as special **WM_COMMAND** messages, with the notification code (such as **BN_CLICKED**) and control ID packed into <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and the control's handle in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Note that since <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are full, there is no way to pass any additional data — these messages can be only simple notification. For instance, in the **BN_CLICKED** notification, there's no way to send information about the location of the mouse cursor when the button was clicked.  
  
 When controls in Windows 3.x need to send a notification message that includes additional data, they use a variety of special-purpose messages, including <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and so on. These messages can be reflected back to the control that sent them. For more information, see [TN062: Message Reflection for Windows Controls](../vs140/tn062--message-reflection-for-windows-controls.md).  
  
 **Notification Messages in Win32**  
  
 For controls that existed in Windows 3.1, the Win32 API uses most of the notification messages that were used in Windows 3.x. However, Win32 also adds a number of sophisticated, complex controls to those supported in Windows 3.x. Frequently, these controls need to send additional data with their notification messages. Rather than adding a new **WM_\*** message for each new notification that needs additional data, the designers of the Win32 API chose to add just one message, **WM_NOTIFY**, which can pass any amount of additional data in a standardized fashion.  
  
 **WM_NOTIFY** messages contain the ID of the control sending the message in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and a pointer to a structure in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This structure is either an **NMHDR** structure or some larger structure that has an **NMHDR** structure as its first member. Note that since the **NMHDR** member is first, a pointer to this structure can be used as either a pointer to an **NMHDR** or as a pointer to the larger structure depending on how you cast it.  
  
 In most cases, the pointer will point to a larger structure and you'll need to cast it when you use it. In only a few notifications, such as the common notifications (whose names start with **NM_**) and the tool tip control's **TTN_SHOW** and **TTN_POP** notifications, is an **NMHDR** structure actually used.  
  
 The **NMHDR** structure or initial member contains the handle and ID of the control sending the message and the notification code (such as **TTN_SHOW**). The format of the **NMHDR** structure is shown below:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For a **TTN_SHOW** message, the **code** member would be set to **TTN_SHOW**.  
  
 Most notifications pass a pointer to a larger structure that contains an **NMHDR** structure as its first member. For instance, consider the structure used by the list view control's **LVN_KEYDOWN** notification message, which is sent when a key is pressed in a list view control. The pointer points to an **LV_KEYDOWN** structure, which is defined as shown below:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Note that since the **NMHDR** member is first in this structure, the pointer you're passed in the notification message can be cast to either a pointer to an **NMHDR** or a pointer to an **LV_KEYDOWN**.  
  
 **Notifications Common to All New Windows Controls**  
  
 Some notifications are common to all of the new Windows controls. These notifications pass a pointer to an **NMHDR** structure.  
  
|Notification code|Sent because|  
|-----------------------|------------------|  
|**NM_CLICK**|User clicked left mouse button in the control|  
|**NM_DBLCLK**|User double-clicked left mouse button in the control|  
|**NM_RCLICK**|User clicked right mouse button in the control|  
|**NM_RDBLCLK**|User double-clicked right mouse button in the control|  
|**NM_RETURN**|User pressed the ENTER key while control has input focus|  
|**NM_SETFOCUS**|Control has been given input focus|  
|**NM_KILLFOCUS**|Control has lost input focus|  
|**NM_OUTOFMEMORY**|Control could not complete an operation because there was not enough memory available|  
  
##  \<a name="_mfcnotes_on_notify.3a_.handling_wm_notify_messages_in_mfc_applications">\</a> ON_NOTIFY: Handling WM_NOTIFY Messages in MFC Applications  
 The function <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> handles notification messages. Its default implementation checks the message map for notification handlers to call. In general, you do not override <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Instead, you provide a handler function and add a message-map entry for that handler to the message map of your owner window's class.  
  
 ClassWizard, via the ClassWizard property sheet, can create the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> message-map entry and provide you with a skeleton handler function. For more information on using ClassWizard to make this easier, see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md).  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> message-map macro has the following syntax:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 where the italicized parameters are replaced with:  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The code for the notification message to be handled, such as **LVN_KEYDOWN**.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The child identifier of the control for which the notification is sent.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The member function to be called when this notification is sent.  
  
 Your member function must be declared with the following prototype:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Remarks  
 where the italicized parameters are:  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to the notification structure, as described in the section above.  
  
 *result*  
 A pointer to the result code you'll set before you return.  
  
## Example  
 To specify that you want the member function <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to handle **LVN_KEYDOWN** messages from the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> whose ID is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, you would use ClassWizard to add the following to your message map:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In the example above, the function provided by ClassWizard is:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Note that ClassWizard provides a pointer of the proper type automatically. You can access the notification structure through either <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
##  \<a name="_mfcnotes_on_notify_range">\</a> ON_NOTIFY_RANGE  
 If you need to process the same **WM_NOTIFY** message for a set of controls, you can use **ON_NOTIFY_RANGE** rather than <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For instance, you may have a set of buttons for which you want to perform the same action for a certain notification message.  
  
 When you use **ON_NOTIFY_RANGE**, you specify a contiguous range of child identifiers for which to handle the notification message by specifying the beginning and ending child identifiers of the range.  
  
 ClassWizard does not handle **ON_NOTIFY_RANGE**; to use it, you need to edit your message map yourself.  
  
 The message-map entry and function prototype for **ON_NOTIFY_RANGE** are as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 where the italicized parameters are replaced with:  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The code for the notification message to be handled, such as **LVN_KEYDOWN**.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The first identifier in the contiguous range of identifiers.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The last identifier in the contiguous range of identifiers.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The member function to be called when this notification is sent.  
  
 Your member function must be declared with the following prototype:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Remarks  
 where the italicized parameters are:  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The child identifier of the control that sent the notification.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to the notification structure, as described above.  
  
 *result*  
 A pointer to the result code you'll set before you return.  
  
##  \<a name="_mfcnotes_tn061_on_notify_ex.2c_.on_notify_ex_range">\</a> ON_NOTIFY_EX, ON_NOTIFY_EX_RANGE  
 If you want more than one object in the notification routing to handle a message, you can use **ON_NOTIFY_EX** (or **ON_NOTIFY_EX_RANGE**) rather than <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> (or **ON_NOTIFY_RANGE**). The only difference between the **EX** version and the regular version is that the member function called for the **EX** version returns a **BOOL** that indicates whether or not message processing should continue. Returning **FALSE** from this function allows you to process the same message in more than one object.  
  
 ClassWizard does not handle **ON_NOTIFY_EX** or **ON_NOTIFY_EX_RANGE**; if you want to use either of them, you need to edit your message map yourself.  
  
 The message-map entry and function prototype for **ON_NOTIFY_EX** and **ON_NOTIFY_EX_RANGE** are as follows. The meanings of the parameters are the same as for the non-**EX** versions.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The prototype for both of the above is the same:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Remarks  
 In both cases, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> holds the child identifier of the control that sent the notification.  
  
 Your function must return **TRUE** if the notification message has been completely handled or **FALSE** if other objects in the command routing should have a chance to handle the message.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)