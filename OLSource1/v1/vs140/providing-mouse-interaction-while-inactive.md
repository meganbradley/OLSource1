---
title: "Providing Mouse Interaction While Inactive"
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
  - "MFC ActiveX controls, mouse interaction"
ms.assetid: b09106bf-44c7-4b9b-a6d9-0d624f16f5b3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Providing Mouse Interaction While Inactive
If your control is not immediately activated, you may still want it to process <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messages, even though the control has no window of its own. This can be accomplished by enabling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>'s implementation of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface, which is disabled by default. (See the *ActiveX SDK* for a description of this interface.) To enable it, include the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flag in the set of flags returned by [COleControl::GetControlFlags](../vs140/colecontrol--getcontrolflags.md):  
  
 [!code[NVC_MFC_AxOpt#5](../vs140/codesnippet/CPP/providing-mouse-interaction-while-inactive_1.cpp)]  
[!code[NVC_MFC_AxOpt#10](../vs140/codesnippet/CPP/providing-mouse-interaction-while-inactive_2.cpp)]  
[!code[NVC_MFC_AxOpt#7](../vs140/codesnippet/CPP/providing-mouse-interaction-while-inactive_3.cpp)]  
  
 The code to include this flag is automatically generated if you select the **Mouse Pointer Notifications When Inactive** option on the [Control Settings](../vs140/control-settings--mfc-activex-control-wizard.md) page when creating your control with the **MFC ActiveX Control Wizard**.  
  
 When the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface is enabled, the container delegates <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> messages to it. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>'s implementation of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> dispatches the messages through your control's message map after adjusting the mouse coordinates appropriately. You can process the messages just like ordinary window messages by adding the corresponding entries to the message map. In your handlers for these messages, avoid using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member variable (or any member function that uses it) without first checking that its value is not **NULL**.  
  
 You may also want an inactive control to be the target of an OLE drag-and-drop operation. This requires activating the control at the moment the user drags an object over it, so that the control's window can be registered as a drop target. To cause activation to occur during a drag, override [COleControl::GetActivationPolicy](../vs140/colecontrol--getactivationpolicy.md), and return the **POINTERINACTIVE_ACTIVATEONDRAG** flag:  
  
 [!code[NVC_MFC_AxOpt#11](../vs140/codesnippet/CPP/providing-mouse-interaction-while-inactive_4.cpp)]  
  
 Enabling the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface typically means that you want the control to be capable of processing mouse messages at all times. To get this behavior in a container that doesn't support the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> interface, you need to have your control always activated when visible, which means the control should include the **OLEMISC_ACTIVATEWHENVISIBLE** flag among its miscellaneous flags. However, to prevent this flag from taking effect in a container that does support <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you can also specify the **OLEMISC_IGNOREACTIVATEWHENVISIBLE** flag:  
  
 [!code[NVC_MFC_AxOpt#12](../vs140/codesnippet/CPP/providing-mouse-interaction-while-inactive_5.cpp)]  
  
## See Also  
 [MFC ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md)