---
title: "MFC ActiveX Controls: Returning Error Codes From a Method"
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
  - "MFC ActiveX controls, error codes"
  - "SetNotSupported method, using"
  - "errors [C++], ActiveX control error codes"
  - "GetNotSupported method"
  - "FireError method"
  - "SCODE, MFC ActiveX controls"
  - "ThrowError method"
ms.assetid: 771fb9c9-2413-4dcc-b386-7bc4c4adeafd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Returning Error Codes From a Method
This article describes how to return error codes from an ActiveX control method.  
  
 To indicate that an error has occurred within a method, you should use the [COleControl::ThrowError](../vs140/colecontrol--throwerror.md) member function, which takes an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> (status code) as a parameter. You can use a predefined <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or define one of your own.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is meant to be used only as a means of returning an error from within a property's Get or Set function or an automation Method. These are the only times that the appropriate exception handler will be present on the stack.  
  
 Helper functions exist for the most common predefined <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>s, such as [COleControl::SetNotSupported](../vs140/colecontrol--setnotsupported.md), [COleControl::GetNotSupported](../vs140/colecontrol--getnotsupported.md), and [COleControl::SetNotPermitted](../vs140/colecontrol--setnotpermitted.md).  
  
 For a list of predefined <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>s and instructions on defining custom <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>s, see the section [Handling Errors in Your ActiveX Control](../vs140/mfc-activex-controls--advanced-topics.md) in ActiveX Controls: Advanced Topics.  
  
 For more information on reporting exceptions in other areas of your code, see [COleControl::FireError](../vs140/colecontrol--fireerror.md) and the section [Handling Errors in Your ActiveX Control](../vs140/mfc-activex-controls--advanced-topics.md) in ActiveX Controls: Advanced Topics.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)