---
title: "AtlAxAttachControl"
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
  - "AtlAxAttachControl"
  - "ATL::AtlAxAttachControl"
  - "ATL.AtlAxAttachControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAxAttachControl function"
ms.assetid: 80b5b2e8-dc67-4b22-ba95-632a089dbe47
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAxAttachControl
Attaches a previously created control to the specified window.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to the **IUnknown** of the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Handle to the window that will host the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] A pointer to a pointer to the **IUnknown** of the container object.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 Use [AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md) and [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md) to simultaneously create and attach a control.  
  
> [!NOTE]
>  The control object being attached must be correctly initialized before calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)