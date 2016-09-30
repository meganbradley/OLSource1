---
title: "Default Control Events"
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
  - "C++"
helpviewer_keywords: 
  - "Dialog editor, default control events"
  - "controls [C++], default control events"
  - "events [C++], controls"
  - "dialog box controls, events"
ms.assetid: 75556b23-18f5-4390-97a4-2ecad3309741
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Default Control Events
The following control names have the accompanying default events:  
  
|Control name|Default event|  
|------------------|-------------------|  
|Animate|**ACN_START**|  
|Check box|**BN_CLICKED**|  
|Combo box|**CBN_SELCHANGE**|  
|Custom|**TTN_GETDISPINFO**|  
|Date time picker|**DTN_DATETIMECHANGE**|  
|Edit box|**EN_CHANGE**|  
|Group Box|(Not applicable)|  
|Hot key|**NM_OUTOFMEMORY**|  
|IP address|**IPN_FIELDCHANGED**|  
|List|**LVN_ITEMCHANGE**|  
|List box|**LBN_SELCHANGE**|  
|Month calendar|**MCN_SELCHANGE**|  
|Picture Control|(Not applicable)|  
|Progress|**NM_CUSTOMDRAW**|  
|Push button|**BN_CLICKED**|  
|Radio button|**BN_CLICKED**|  
|Rich edit|**EN_CHANGE**|  
|Scroll bar|**NM_THEMECHANGED**|  
|Slider|**NM_CUSTOMDRAW**|  
|Spin|**UDN_DELTAPOS**|  
|Static Text|(Not applicable)|  
|Tab|**TCN_SELCHANGE**|  
|Tree|**TVN_SELCHANGE**|  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
## Requirements  
 Win32  
  
## See Also  
 [Defining Member Variables for Dialog Controls](../vs140/defining-member-variables-for-dialog-controls.md)   
 [Message Types Associated with User-Interface Objects](../vs140/message-types-associated-with-user-interface-objects.md)   
 [Editing a Message Handler](../vs140/editing-a-message-handler.md)   
 [Defining a Message Handler for a Reflected Message](../vs140/defining-a-message-handler-for-a-reflected-message.md)   
 [Declaring a Variable Based on Your New Control Class](../vs140/declaring-a-variable-based-on-your-new-control-class.md)   
 [Overriding a Virtual Function](../vs140/overriding-a-virtual-function--visual-c---.md)