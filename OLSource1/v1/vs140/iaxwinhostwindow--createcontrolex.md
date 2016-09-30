---
title: "IAxWinHostWindow::CreateControlEx"
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
  - "IAxWinHostWindow.CreateControlEx"
  - "IAxWinHostWindow::CreateControlEx"
  - "CreateControlEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControlEx method"
ms.assetid: 53b135eb-b896-45b7-8aac-f83db6688db2
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindow::CreateControlEx
Creates an ActiveX control, initializes it, and hosts it in the specified window, similar to [IAxWinHostWindow::CreateControl](../vs140/iaxwinhostwindow--createcontrol.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A string identifying the control to create. Can be a CLSID (must include the braces), ProgID, URL, or raw HTML (prefixed with **MSHTML:**).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A handle to the window to be used for hosting.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An interface pointer for a stream containing initialization data for the control. Can be **NULL**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the **IUnknown** interface of the created control. Can be **NULL**.  
  
 *riidAdvise*  
 [in] The interface identifier of an outgoing interface on the contained object. Can be **IID_NULL**.  
  
 *punkAdvise*  
 [in] A pointer to the **IUnknown** interface of the sink object to be connected to the connection point on the contained object specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value.  
  
## Remarks  
 Unlike the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> also allows you to receive an interface pointer to the newly created control and set up an event sink to receive events fired by the control.  
  
 To create a licensed ActiveX control, see [IAxWinHostWindowLic::CreateControlLicEx](../vs140/iaxwinhostwindowlic--createcontrollicex.md).  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindow Interface](../vs140/iaxwinhostwindow-interface.md)   
 [IAxWinHostWindow::CreateControl](../vs140/iaxwinhostwindow--createcontrol.md)   
 [IAxWinHostWindow::AttachControl](../vs140/iaxwinhostwindow--attachcontrol.md)   
 [CAxWindow::CreateControlEx](../vs140/caxwindow--createcontrolex.md)   
 [AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md)