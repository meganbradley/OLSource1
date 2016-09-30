---
title: "COleControl::GetActivationPolicy"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleControl::GetActivationPolicy"
  - "COleControl.GetActivationPolicy"
  - "GetActivationPolicy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActivationPolicy method"
ms.assetid: e5a0a2ef-d582-47fb-a02b-b21c36f63c4d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetActivationPolicy
Alters the default activation behavior of a control that supports the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A combination of flags from the **POINTERINACTIVE** enumeration. Possible flags are:  
  
 **POINTERINACTIVE_ACTIVATEONENTRY**  
 The object should be in-place activated when the mouse enters it during a mouse move operation.  
  
 **POINTERINACTIVE_DEACTIVATEONLEAVE**  
 The object should be deactivated when the mouse leaves the object during a mouse move operation.  
  
 **POINTERINACTIVE_ACTIVATEONDRAG**  
 The object should be in-place activated when the mouse is dragged over it during a drag and drop operation.  
  
## Remarks  
 When the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface is enabled, the container will delegate <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> messages to it. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>'s implementation of this interface will dispatch these messages through your control's message map, after adjusting the mouse coordinates appropriately.  
  
 Whenever the container receives a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message with the mouse pointer over an inactive object supporting <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, it should call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on the interface and return flags from the **POINTERINACTIVE** enumeration.  
  
 You can process these messages just like ordinary window messages, by adding the corresponding entries to the message map. In your handlers, avoid using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member variable (or any member functions that uses it) without first checking that its value is non-**NULL**.  
  
 Any object intended to do more than set the mouse cursor and/or fire a mouse move event, such as give special visual feedback, should return the **POINTERINACTIVE_ACTIVATEONENTRY** flag and draw the feedback only when active. If the object returns this flag, the container should activate it in-place immediately and then forward it the same message that triggered the call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 If both the **POINTERINACTIVE_ACTIVATEONENTRY** and **POINTERINACTIVE_DEACTIVATEONLEAVE** flags are returned, then the object will only be activated when the mouse is over the object. If only the **POINTERINACTIVE_ACTIVATEONENTRY** flag is returned, then the object will only be activated once when the mouse first enters the object.  
  
 You may also want an inactive control to be the target of an OLE drag and drop operation. This requires activating the control at the moment the user drags an object over it, so that the control's window can be registered as a drop target. To cause activation to occur during a drag, return the **POINTERINACTIVE_ACTIVATEONDRAG** flag:  
  
 [!code[NVC_MFCAxCtl#1](../vs140/codesnippet/CPP/colecontrol--getactivationpolicy_1.cpp)]  
  
 The information communicated by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> should not be cached by a container. Instead, this method should be called every time the mouse enters an inactive object.  
  
 If an inactive object does not request to be in-place activated when the mouse enters it, its container should dispatch subsequent <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> messages to this object by calling [OnInactiveSetCursor](../vs140/colecontrol--oninactivesetcursor.md) as long as the mouse pointer stays over the object.  
  
 Enabling the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface typically means that you want the control to be capable of processing mouse messages at all times. To get this behaviour in a container that doesn't support the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface, you will need to have your control always activated when visible, which means the control should have the **OLEMISC_ACTIVATEWHENVISIBLE** flag among its miscellaneous flags. However, to prevent this flag from taking effect in a container that does support <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, you can also specify the **OLEMISC_IGNOREACTIVATEWHENVISIBLE** flag:  
  
 [!code[NVC_MFCAxCtl#10](../vs140/codesnippet/CPP/colecontrol--getactivationpolicy_2.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnInactiveSetCursor](../vs140/colecontrol--oninactivesetcursor.md)   
 [COleControl::OnInactiveMouseMove](../vs140/colecontrol--oninactivemousemove.md)