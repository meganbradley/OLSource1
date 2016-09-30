---
title: "MFC ActiveX Controls: Accessing Ambient Properties"
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
  - "MFC ActiveX controls, accessing ambient properties"
  - "properties [MFC], accessing ambient"
ms.assetid: fdc9db29-e6b0-45d2-a879-8bd60e2058a7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Accessing Ambient Properties
This article discusses how an ActiveX control can access the ambient properties of its control container.  
  
 A control can obtain information about its container by accessing the container's ambient properties. These properties expose visual characteristics, such as the container's background color, the current font used by the container, and operational characteristics, such as whether the container is currently in user mode or designer mode. A control can use ambient properties to tailor its appearance and behavior to the particular container in which it is embedded. However, a control should never assume that its container will support any particular ambient property. In fact, some containers may not support any ambient properties at all. In the absence of an ambient property, a control should assume a reasonable default value.  
  
 To access an ambient property, make a call to [COleControl::GetAmbientProperty](../vs140/colecontrol--getambientproperty.md). This function expects the dispatch ID for the ambient property as the first parameter (the file OLECTL.H defines dispatch IDs for the standard set of ambient properties).  
  
 The parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> function are the dispatch ID, a variant tag indicating the expected property type, and a pointer to memory where the value should be returned. The type of data to which this pointer refers will vary depending on the variant tag. The function returns **TRUE** if the container supports the property, otherwise it returns **FALSE**.  
  
 The following code example obtains the value of the ambient property called "UserMode." If the property is not supported by the container, a default value of **TRUE** is assumed:  
  
 [!code[NVC_MFC_AxUI#30](../vs140/codesnippet/CPP/mfc-activex-controls--accessing-ambient-properties_1.cpp)]  
  
 For your convenience, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> supplies helper functions that access many of the commonly used ambient properties and return appropriate defaults when the properties are not available. These helper functions are as follows:  
  
-   [COleControl::AmbientBackColor](../vs140/colecontrol--ambientbackcolor.md)  
  
-   [AmbientDisplayName](../vs140/colecontrol--ambientdisplayname.md)  
  
-   [AmbientFont](../vs140/colecontrol--ambientfont.md)  
  
    > [!NOTE]
    >  Caller must call **Release( )** on the returned font.  
  
-   [AmbientForeColor](../vs140/colecontrol--ambientforecolor.md)  
  
-   [AmbientLocaleID](../vs140/colecontrol--ambientlocaleid.md)  
  
-   [AmbientScaleUnits](../vs140/colecontrol--ambientscaleunits.md)  
  
-   [AmbientTextAlign](../vs140/colecontrol--ambienttextalign.md)  
  
-   [AmbientUserMode](../vs140/colecontrol--ambientusermode.md)  
  
-   [AmbientUIDead](../vs140/colecontrol--ambientuidead.md)  
  
-   [AmbientShowHatching](../vs140/colecontrol--ambientshowhatching.md)  
  
-   [AmbientShowGrabHandles](../vs140/colecontrol--ambientshowgrabhandles.md)  
  
 If the value of an ambient property changes (through some action of the container), the **OnAmbientPropertyChanged** member function of the control is called. Override this member function to handle such a notification. The parameter for **OnAmbientPropertyChanged** is the dispatch ID of the affected ambient property. The value of this dispatch ID may be **DISPID_UNKNOWN**, which indicates that one or more ambient properties has changed, but information about which properties were affected is unavailable.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)