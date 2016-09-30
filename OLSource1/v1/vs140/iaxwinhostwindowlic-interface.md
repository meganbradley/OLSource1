---
title: "IAxWinHostWindowLic Interface"
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
  - "IAxWinHostWindowLic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IAxWinHostWindowLic interface"
ms.assetid: 750f1520-6bce-428c-aca0-fccbe3f063c7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindowLic Interface
This interface provides methods for manipulating a licensed control and its host object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CreateControlLic](../vs140/iaxwinhostwindowlic--createcontrollic.md)|Creates a licensed control and attaches it to the host object.|  
|[CreateControlLicEx](../vs140/iaxwinhostwindowlic--createcontrollicex.md)|Creates a licensed control, attaches it to the host object, and optionally sets up an event handler.|  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> inherits from [IAxWinHostWindow](../vs140/iaxwinhostwindow-interface.md) and adds methods that support the creation of licensed controls.  
  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses the members of this interface.  
  
## Requirements  
 The definition of this interface is available as IDL or C++, as shown below.  
  
|Definition type|File|  
|---------------------|----------|  
|IDL|ATLIFace.idl|  
|C++|ATLIFace.h (also included in ATLBase.h)|