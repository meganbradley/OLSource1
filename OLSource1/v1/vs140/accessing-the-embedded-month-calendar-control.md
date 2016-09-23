---
title: "Accessing the Embedded Month Calendar Control"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - DateTimePicker control [MFC], accessing month calendar
  - CDateTimeCtrl class, accessing embedded control
  - month calendar controls, embedded in date/time picker
  - CMonthCalCtrl class, changing the font
  - month calendar controls, changing the font
  - DateTimePicker control [MFC]
ms.assetid: 355e97ed-cf81-4df3-a2f8-9ddbbde93227
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Accessing the Embedded Month Calendar Control
The embedded month calendar control object can be accessed from the `CDateTimeCtrl` object with a call to the [GetMonthCalCtrl](../vs140/cdatetimectrl--getmonthcalctrl.md) member function.  
  
> [!NOTE]
>  The embedded month calendar control is used only when the date and time picker control does not have the **DTS_UPDOWN** style set.  
  
 This is useful if you want to modify certain attributes before the embedded control is displayed. To accomplish this, handle the **DTN_DROPDOWN** notification, retrieve the month calendar control (using [CDateTimeCtrl::GetMonthCalCtrl](../vs140/cdatetimectrl--getmonthcalctrl.md)), and make your modifications. Unfortunately, the month calendar control is not persistent.  
  
 In other words, when the user requests the display of the month calendar control, a new month calendar control is created (before the **DTN_DROPDOWN** notification). The control is destroyed (after the **DTN_CLOSEUP** notification) when dismissed by the user. This means that any attributes you modify, before the embedded control is displayed, are lost when the embedded control is dismissed.  
  
 The following example demonstrates this procedure, using a handler for the **DTN_DROPDOWN** notification. The code changes the background color of the month calendar control, with a call to [SetMonthCalColor](../vs140/cdatetimectrl--setmonthcalcolor.md), to gray. The code is as follows:  
  
 [!code[NVC_MFCControlLadenDialog#5](../vs140/codesnippet/CPP/accessing-the-embedded-month-calendar-control_1.cpp)]
  
  
 As stated previously, all modifications to properties of the month calendar control are lost, with two exceptions, when the embedded control is dismissed. The first exception, the colors of the month calendar control, has already been discussed. The second exception is the font used by the month calendar control. You can modify the default font by making a call to [CDateTimeCtrl::SetMonthCalFont](../vs140/cdatetimectrl--setmonthcalfont.md), passing the handle of an existing font. The following example (where `m_dtPicker` is the date and time control object) demonstrates one possible method:  
  
 [!code[NVC_MFCControlLadenDialog#6](../vs140/codesnippet/CPP/accessing-the-embedded-month-calendar-control_2.cpp)]
  
  
 Once the font has been changed, with a call to `CDateTimeCtrl::SetMonthCalFont`, the new font is stored and used the next time a month calendar is to be displayed.  
  
## See Also  
 [Using CDateTimeCtrl](../vs140/using-cdatetimectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)